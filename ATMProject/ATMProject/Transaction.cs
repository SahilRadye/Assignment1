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
    public partial class Transaction : Form
    {
        UserData dataStore;
        public Transaction()
        {
            InitializeComponent();
            dataStore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            try
            {
                long cardNo = long.Parse(Form1.instance.txtcardNo.Text);

                dataTransaction.DataSource = dataStore.GetAllTransaction(cardNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
