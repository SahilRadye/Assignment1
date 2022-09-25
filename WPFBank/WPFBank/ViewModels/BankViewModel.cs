using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBank.Commands;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;
using WPFBank.Models;
using System.Configuration;
using WPFBank.Views;
using System.Windows.Controls;

namespace WPFBank.ViewModels
{
    public class BankViewModel : INotifyPropertyChanged
    {
        UserData dataStore = null;
        ObservableCollection<User> user = null;
        ObservableCollection<Transaction> transaction = null;
        public static BankViewModel instance;

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            //Raise the PropertyChanged Event in Case somebody subscribed to it
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); //Raise the event
        }
        #endregion

        #region Properties

        private User userObj = new User();
        private Transaction transactionObj = new Transaction();

        public string UI_CardNo
        {
            get { return userObj.CardNo.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    userObj.CardNo = long.Parse(value);
                    OnPropertyChanged("UI_CardNo");
                }
            }
        }

        public string UI_Name
        {
            get { return userObj.Name.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    userObj.Name = value;
                    OnPropertyChanged("UI_Name");
                }
            }
        }

        public string UI_PinNo
        {
            get { return userObj.PinNo.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    userObj.PinNo = Convert.ToInt32(value);
                    OnPropertyChanged("UI_PinNo");
                }
            }
        }

        public string UI_Balance
        {
            get { return userObj.Balance.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    userObj.Balance = decimal.Parse(value);
                    OnPropertyChanged("UI_Balance");
                }
            }
        }

        public string UI_Transaction_Id
        {
            get { return transactionObj.Transaction_Id.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    transactionObj.Transaction_Id = long.Parse(value);
                    OnPropertyChanged("UI_Transaction_Id");
                }
            }
        }

        public string UI_Transaction_Type
        {
            get { return transactionObj.Transaction_Type.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    transactionObj.Transaction_Type = value;
                    OnPropertyChanged("UI_Transaction_Type");
                }
            }
        }

        public string UI_DateTime
        {
            get { return transactionObj.DateTime.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    transactionObj.DateTime = DateTime.Parse(value);
                    OnPropertyChanged("UI_DateTime");
                }
            }
        }

        public string UI_Amount
        {
            get { return transactionObj.Amount.ToString(); }
            set
            {
                if (value != string.Empty)
                {
                    transactionObj.Amount = decimal.Parse(value);
                    OnPropertyChanged("UI_Amount");
                }
            }
        }

        public ObservableCollection<User> UserList
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }

        public ObservableCollection<Transaction> TransactionList
        {
            get { return transaction; }
            set
            {
                transaction = value;
                OnPropertyChanged("Transaction");
            }
        }


        #endregion

        #region Constructor

        public BankViewModel()
        {
            dataStore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
            instance = this;
            TransactionList = new ObservableCollection<Transaction>();
            UserList = new ObservableCollection<User>();
            _login = new RelayCommand(Login, CanLogin);
            _balance = new RelayCommand(Balance);
            _transaction = new RelayCommand(Transaction);
            _amount = new RelayCommand(Amount);
            _statement = new RelayCommand(MiniStatement);
        }

        #endregion

        #region Commands

        #region Login Command

        private ICommand _login;

        public ICommand LoginCommand
        {
            get { return _login; }
        }

        public bool CanLogin(object obj)
        {
            if (this.UI_CardNo != String.Empty && this.UI_PinNo != String.Empty)
            {
                return true;
            }
            return false;
        }

        public void Login(object obj)
        {
            long cardNo = long.Parse(this.UI_CardNo);
            int pin = Convert.ToInt32(this.UI_PinNo);

            int count = dataStore.ValidUser(cardNo, pin);


            if (count == 0)
            {
                MessageBox.Show("Error : Invalid Credentials", "Alert");

            }
            else
            {
                MessageBox.Show("Welcome", "ATM Services");
                MenuForm menu = new MenuForm();
                menu.Show();
            }
        }

        #endregion


        #region Menu Commands

        private ICommand _balance;

        public ICommand CheckBalance
        {
            get { return _balance; }
        }

        public void Balance(object obj)
        {
            CheckBalance balance = new CheckBalance();
            balance.Show();
        }



        private ICommand _transaction;

        public ICommand CheckTransaction
        {
            get { return _transaction; }
        }

        public void Transaction(object obj)
        {
            CheckTransaction transaction = new CheckTransaction();
            transaction.Show();
        }

        #endregion


        #region Balance

        private ICommand _amount;

        public ICommand CheckAmount
        {
            get { return _amount; }
        }

        public void Amount(object obj)
        {
            long cardno = long.Parse(LoginForm.instance.txtCardNo.Text);

            User user = dataStore.AvailableBalance1(cardno);

            if (user != null)
            {
                this.UI_Balance = user.Balance.ToString();
            }
        }
        #endregion

        #region Transaction Command

        private ICommand _statement;

        public ICommand Statement
        {
            get { return _statement; }
        }

        public void MiniStatement(object obj)
        {
            long cardno = long.Parse(LoginForm.instance.txtCardNo.Text);

            var data = dataStore.GetAllTransaction(cardno).ToList();

            TransactionList = new ObservableCollection<Transaction>(data); 
        }

        #endregion

        #endregion
    }
}
