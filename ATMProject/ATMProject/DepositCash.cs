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
    public partial class DepositCash : Form
    {
        UserData dataStore;
        long transactionNo = 225698846611;
        public DepositCash()
        {
            InitializeComponent();
            dataStore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void DepositCash_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txtAmount.Text);
            long cardNo = long.Parse(Form1.instance.txtcardNo.Text);
            long transId = transactionNo;

            try
            {
                int count = dataStore.DepositCash(transId, amount, cardNo);
                if(count == 1)
                {
                    MessageBox.Show("Deposit Successfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                int count1 = dataStore.DepositAdd(cardNo, amount);
                if (count1 == 1)
                {
                    MessageBox.Show("Money Credited to your Account Successfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.Close();
        }
    }
}
