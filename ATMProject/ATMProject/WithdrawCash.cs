using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankDataLibrary;
using System.Configuration;

namespace ATMProject
{
    public partial class WithdrawCash : Form
    {
        UserData dataStore;
        long transactionNo = 225698846521;
        public WithdrawCash()
        {
            InitializeComponent();
            dataStore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void WithdrawCash_Load(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            
            int amount = Convert.ToInt32(txtAmount.Text);
            long cardNo = long.Parse(Form1.instance.txtcardNo.Text);
            long transId = transactionNo;


            if ((amount >= 500) && (amount <= 20000))
            {
                try
                {
                    int num = dataStore.Count(cardNo);
                    if (num < 3)
                    {

                        int count = dataStore.WithdrawCash(transId, amount, cardNo);
                        if (count == 1)
                        {
                            MessageBox.Show("Withdraw Process Successfull");
                            MessageBox.Show("Please Wait for Your Cash", "Cash", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        int count1 = dataStore.CashDebited(cardNo, amount);
                        if (count1 == 1)
                        {
                            MessageBox.Show("Money Debited from your Account", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please try Tomorrow your Withdraw limit is over");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if (amount <= 500)
            {
                MessageBox.Show("Minimum Withdraw of Rs.500", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (amount >= 20000)
            {
                MessageBox.Show("Limit of Rs.20000", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
            this.Close();
        }
    }
}
