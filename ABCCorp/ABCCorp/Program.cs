using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
using HRApp;

namespace ABCCorp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region EmployeeObject
            //Employee employee = new Employee();
            //Console.WriteLine(employee);

            //Employee employee2 = new Employee("Jayesh Patil", "Airoli");
            //Console.WriteLine(employee2);
            #endregion

            #region ConfirmEmployee Object
            try
            {
                ConfirmEmployee confirmEmployee = new ConfirmEmployee("Sahil Radye" , "Thane" , 21000 , "ConfirmEmployee");
                Console.WriteLine(confirmEmployee);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                ConfirmEmployee confirmEmployee1 = new ConfirmEmployee("Omkar Shelke", "Santacruz", 30000, "ConfirmEmployee");
                Console.WriteLine(confirmEmployee1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Console.WriteLine(confirmEmployee1.Basic);
            //Console.WriteLine(confirmEmployee1.CalculateSalary());
            #endregion

            #region Trainee
            Trainee trainee = new Trainee("Jayesh Patil", "Airoli", 3, 1000);
            Console.WriteLine(trainee);

            Trainee trainee1 = new Trainee("Ricky Mahtre", "Vasai", 5, 1500);
            Console.WriteLine(trainee1);

            //Console.WriteLine(trainee1.CalculateSalary());

            #endregion

            Console.ReadLine();
        }
    }
}
