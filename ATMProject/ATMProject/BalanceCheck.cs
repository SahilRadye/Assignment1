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
    public partial class BalanceCheck : Form
    {
        UserData dataStore;
        public BalanceCheck()
        {
            InitializeComponent();
            dataStore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void BalanceCheck_Load(object sender, EventArgs e)
        {

            
        }

        private void userDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                long cardNo = long.Parse(Form1.instance.txtcardNo.Text);
                int pin = Convert.ToInt32(Form1.instance.txtpinNo.Text);

                userDataGrid.DataSource = dataStore.AvailableBalance(cardNo, pin);
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
