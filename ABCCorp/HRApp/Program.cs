using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;


namespace HRApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Generic

            string choice;
            int num;


            List<Employee> employee = new List<Employee>();
            employee.Add(new ConfirmEmployee {  Name = "Sahil Radye", Address = "Thane", TypeEmployee = "ConfirmEmployee" });
            employee.Add(new ConfirmEmployee {  Name = "Pratik Shet", Address = "Mumbai", TypeEmployee = "ConfirmEmployee" });
            employee.Add(new Trainee { Name = "Jayesh Patil", Address = "Airoli", TypeEmployee = "TraineeEmployee" });
            employee.Add(new Trainee { Name = "Omkar Shelke", Address = "Santacruz", TypeEmployee = "TraineeEmployee" });

            do
            {

                int num2 = 0;
                Console.WriteLine("1. Display All Employees");
                Console.WriteLine("2. Display Employee which you want");
                Console.WriteLine();
                Console.WriteLine("Enter a number from above choice");
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    foreach (Employee emp in employee)
                    {
                        Console.WriteLine(emp);
                    }                   
                }

                else if (result == 2)
                {
                    Console.WriteLine("Enter a Employee Number which you want : ");
                    num = int.Parse(Console.ReadLine());

                    foreach (Employee emp in employee)
                    {
                        if (emp.EmpNo == num)
                        {
                            Console.WriteLine(emp);
                            num2++;
                            break;
                        }
                    }

                    if (num2 == 0)
                    {
                        Console.WriteLine("Employe Not Found");
                    }
                }



                Console.WriteLine();
                Console.WriteLine("Do you Want to Continue Press 'y' or 'n' :");
                choice = Console.ReadLine();

            } while (choice == "y");
            #endregion

            Console.ReadLine();
        }
    }
}
