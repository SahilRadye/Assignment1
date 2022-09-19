using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using BankDataLibrary;

namespace ATMProject
{
    public partial class MenuForm : Form
    {

        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
        }

        private void btnBalanceCheck_Click(object sender, EventArgs e)
        {

            BalanceCheck balance = new BalanceCheck();
            balance.Show();
            this.Hide();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            DepositCash deposit = new DepositCash();
            deposit.Show();
            this.Hide();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawCash withdraw = new WithdrawCash();
            withdraw.Show();
            this.Hide();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
            this.Hide();
        }
    }
}
