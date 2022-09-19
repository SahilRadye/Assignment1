using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace BankDataLibrary
{

    public class UserData
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        public UserData(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }


        public int ValidUser(long cardNo, int pinNo)
        {
            try
            {                
                string query = "select CardNo , PinNo from User1 where CardNo = @cardno and PinNo = @password";

                command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@cardno", cardNo);
                command.Parameters.AddWithValue("@password", pinNo);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                int count = 0;

                if (reader.Read())
                {
                    count++;
                }
                return count;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }


        public List<User> AvailableBalance(long cardNo, int pinNo)
        {

            try
            {
                string query = "select CardNo , AccNo, Name, Address , ContactNo ,Balance  from User1 where CardNo = @cardno and PinNo = @password";

                command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@cardno", cardNo);
                command.Parameters.AddWithValue("@password", pinNo);


                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                List<User> userList = new List<User>();

                while(reader.Read())
                {
                    User user = new User();
                    user.CardNo = (long)reader["CardNo"];
                    user.AccNo = (long)reader["AccNo"];
                    user.Name = (string)reader["Name"].ToString();
                    user.Address = (string)reader["Address"].ToString();
                    user.ContactNo = (long)reader["ContactNo"];
                    user.Balance = (decimal)reader["Balance"];

                    userList.Add(user);
                }
                return userList;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        public List<Transaction> GetAllTransaction(long cardNo)
        {
            try
            {
                string sql = "Select CardNo , Transaction_Id , Trans_Type , Trans_Date , Amount from Transaction where CardNo = @cardNo Order by Trans_Date Desc LIMIT 3";
                command = new MySqlCommand(sql, connection);

                command.Parameters.AddWithValue("@cardNo", cardNo);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                List<Transaction> transactionList = new List<Transaction>();

                while (reader.Read())
                {
                    Transaction transaction = new Transaction();
                    transaction.CardNo = (long)reader["CardNo"];
                    transaction.Transaction_Id = (long)reader["Transaction_Id"];
                    transaction.Transaction_Type = reader["Trans_Type"].ToString();
                    transaction.DateTime = reader["Trans_Date"] as DateTime?;
                    transaction.Amount = (decimal)reader["Amount"];

                    transactionList.Add(transaction);

                }
                return transactionList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        public int WithdrawCash(long transId , int amount , long cardNo)
        {

            try
            {
                string sql = "INSERT INTO Transaction VALUES (@Transaction_Id, 'Withdraw' , curdate()  , @Amount , @CardNo);";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("Transaction_Id", transId);
                command.Parameters.AddWithValue("Amount", amount);
                command.Parameters.AddWithValue("CardNo", cardNo);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count1 = command.ExecuteNonQuery();

                return count1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }



        public int Count(long num)
        {
            string query= "select * from Transaction where CardNo = @cardno and Trans_Type = 'Withdraw' and Trans_Date = curdate()";

            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("cardno",num);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();
            //int count = command.ExecuteNonQuery();
            int count = 1;
            while (reader.Read())
            {
                count++;
            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return count;
        }



        public int CashDebited(long cardNo, int amount)
        {
            int balance = 0;
            string query = "select Balance from user1 where CardNo = @cardNo";

            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("cardNo", cardNo);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    balance = reader.GetInt32(0);
                    break;
                }
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            int total = balance - amount;

            string query1 = "Update User1 Set Balance = @balance where CardNo = @cardNo";
            command = new MySqlCommand(query1, connection);
            command.Parameters.AddWithValue("cardNo", cardNo);
            command.Parameters.AddWithValue("balance", total);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            int count1 = command.ExecuteNonQuery();

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return count1;

        }



        public int DepositCash(long transId, int amount, long cardNo)
        {
            try
            {
                string sql = "INSERT INTO Transaction VALUES (@Transaction_Id, 'Deposit' , curdate()  , @Amount , @CardNo);";

                command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("Transaction_Id", transId);
                command.Parameters.AddWithValue("Amount", amount);
                command.Parameters.AddWithValue("CardNo", cardNo);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                int count1 = command.ExecuteNonQuery();

                return count1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }



        public int DepositAdd(long cardNo ,int amount)
        {
            int balance = 0;
            string query = "select Balance from user1 where CardNo = @cardNo";

            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("cardNo", cardNo);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    balance = reader.GetInt32(0);
                    break;
                }
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            int total = balance + amount;

            string query1 = "Update User1 Set Balance = @balance where CardNo = @cardNo";
            command = new MySqlCommand(query1, connection);
            command.Parameters.AddWithValue("cardNo", cardNo);
            command.Parameters.AddWithValue("balance", total);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            int count1 = command.ExecuteNonQuery();

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return count1;
        }
        
    }
}
