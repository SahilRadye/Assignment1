using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using MySql.Data.MySqlClient;
using DataAccessLibrary;
using System.Collections.ObjectModel;

namespace WPFDemoApp
{
    /// <summary>
    /// Interaction logic for EmployeeDataForm.xaml
    /// </summary>
    /// 
    
    public partial class EmployeeDataForm : Window
    {
        EmployeeDataStore datastore;
        ObservableCollection<Employee> empList;
        public EmployeeDataForm()
        {
            InitializeComponent();

            datastore = new EmployeeDataStore(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Employee> employees = datastore.GetAllEmployees();
            empList = new ObservableCollection<Employee>(employees);
            EmpDataGrid.DataContext = empList;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    EmpNo = Convert.ToInt32(txtEmpNo.Text),
                    EName = txtEName.Text,
                    HireDate = Convert.ToDateTime(txtHireDate.Text),
                    Sal = Convert.ToDecimal(txtSalary.Text)

                };

                int count = datastore.InsertEmployee(employee);
                if (count == 1)
                {
                    MessageBox.Show("Record Inserted");

                    EmpDataGrid.DataContext = datastore.GetAllEmployees();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Execption : \n" + ex.Message);
            }
        }

        private void btnClearData(object sender, RoutedEventArgs e)
        {
            ClearTextBoxes();
        }

        void ClearTextBoxes()
        {
            txtEName.Clear();
            txtEmpNo.Clear();
            txtHireDate.Clear();
            txtSalary.Clear();
        }

        private void btnRemoveData(object sender, RoutedEventArgs e)
        {
            try
            {
                int empno = Convert.ToInt32(txtEmpNo.Text);
                int count = datastore.DeleteEmployee(empno);
                if (count == 1)
                {
                    MessageBox.Show("Record Deleted");

                    EmpDataGrid.DataContext = datastore.GetAllEmployees();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Delete Process Fail");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Execption : \n" + ex.Message);
            }
        }

        private void btnSearchData(object sender, RoutedEventArgs e)
        {
            try
            {

                int empno = Convert.ToInt32(txtEmpNo.Text);
                Employee employee = datastore.GetEmployeeByNumber(empno);

                if (employee == null)
                {
                    MessageBox.Show("No Employee found for no " + empno.ToString());
                    ClearTextBoxes();
                }
                else
                {
                    txtEName.Text = employee.EName;
                    txtHireDate.Text = employee.HireDate.ToString();
                    txtSalary.Text = employee.Sal.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Execption : \n" + ex.Message);
            }
        }

        private void btnEditData(object sender, RoutedEventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    EmpNo = Convert.ToInt32(txtEmpNo.Text),
                    EName = txtEName.Text,
                    HireDate = Convert.ToDateTime(txtHireDate.Text),
                    Sal = Convert.ToDecimal(txtSalary.Text)
                };

                int count = datastore.UpdateEmployee(employee);
                if (count == 1)
                {
                    MessageBox.Show("Record Updated");

                    EmpDataGrid.DataContext = datastore.GetAllEmployees();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Update Fail");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Execption : \n" + ex.Message);
            }
        }
    }
}
