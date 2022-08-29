using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsLibrary;

namespace MathsTestProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calculator = new Calculator();
            calculator.Num1 = 40;
            calculator.Num2 = 20;


            Console.WriteLine("Addition of Number = " + calculator.Addition());
            Console.WriteLine("==============================================");

            Console.WriteLine("Subtraction of Number = " + calculator.Subtraction());
            Console.WriteLine("==============================================");

            Console.WriteLine("Multiply of Number = " + calculator.Multiply());
            Console.WriteLine("==============================================");

            Console.WriteLine("Division of Number = " + calculator.Division());
            Console.WriteLine("==============================================");

            Console.ReadLine();


        }
    }
}
