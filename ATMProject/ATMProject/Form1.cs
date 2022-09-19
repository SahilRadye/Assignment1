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
using BankDataLibrary;

namespace ATMProject
{
    public partial class Form1 : Form
    {
        UserData dataStore;

        public static Form1 instance;
        public TextBox txtcardNo;
        public TextBox txtpinNo;
        public Form1()
        {
            InitializeComponent();
            dataStore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
            instance = this;
            txtcardNo = txtCardNumber;
            txtpinNo = txtPin;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //connection = connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
                //connection = new MySqlConnection("Server=localhost;port=3306;database=atm;User Id=root;password=worldline;");
                long cardNo = long.Parse(txtCardNumber.Text);
                int pin = Convert.ToInt32(txtPin.Text);

                int count = dataStore.ValidUser(cardNo, pin);    


                if (count == 0)
                {
                    MessageBox.Show("Error : Invalid Credentials", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCardNumber.Clear();
                    txtPin.Clear();

                    txtCardNumber.Focus();
                }
                else
                {
                    MenuForm menu = new MenuForm();
                    menu.Show();
                    this.Hide();
                }               
            }
            catch 
            {
                MessageBox.Show("Error" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
