using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class MathsAssignment
    {
        //static void Main(string[] args)
        //{
        //    int choice;
        //    Console.WriteLine("Please enter your choice : \n1. Add \n2. Subtract \n3. Multiply \n4. Division");
        //    choice = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter a number 1 :");
        //    int num1 = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Please enter a number 2 :");
        //    int num2 = int.Parse(Console.ReadLine());

        //    switch (choice)
        //    {
        //        case 1:
        //            Console.WriteLine(Add(num1, num2));
        //            Console.ReadLine();
        //            break;

        //        case 2:
        //            Console.WriteLine(Subtract(num1, num2));
        //            Console.ReadLine();
        //            break;

        //        case 3:
        //            Console.WriteLine(Multiply(num1, num2));
        //            Console.ReadLine();
        //            break;

        //        case 4:
        //            Console.WriteLine(Division(num1, num2));
        //            Console.ReadLine();
        //            break;

        //        default:
        //            Console.WriteLine("Invalid Value");
        //            Console.ReadLine();
        //            break;
        //    }

        //}

        
        

        static int Add(int num1 , int num2)
        {
            return (num1 + num2);
        }

        static int Subtract(int num1, int num2)
        {
            return (num1 - num2);
        }
        static int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }
        static int Division(int num1, int num2)
        {
            return (num1 / num2);
        }

    }
}
