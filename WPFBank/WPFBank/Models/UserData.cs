using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WPFBank.Models
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
      

        public User AvailableBalance1(long cardNo)
        {

            try
            {
                User user = new User();
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
                         
                        user.Balance = reader.GetInt32(0);
                        break;
                    }
                }
                return user;

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
                string sql = "Select CardNo , Transaction_Id , Trans_Type , Trans_Date , Amount from Transaction where CardNo = @cardNo Order by Trans_Date Desc";
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
    }
}
