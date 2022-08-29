using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class EvenOddUsingLoop
    {
        //static void Main(string[] args)
        //{

        //    string word1;

        //    do
        //    {
                
        //        Console.WriteLine("Enter a number");
        //        int number = int.Parse(Console.ReadLine());
        //        Console.WriteLine(EvenOdd(number));
        //        Console.WriteLine("If you want to continue press 'y' or 'n'");
        //        word1 = Console.ReadLine();


        //    }while(word1 == "y");
        //}

        static string EvenOdd(int number1)
        {
            if (number1 % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
    }
}
