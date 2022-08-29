using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class IfEvenOddMethod
    {
        //static void Main(string[] args)
        //{
        //    int num;
        //    num = int.Parse(Console.ReadLine());
        //    string result = EvenOdd(num);
        //    Console.WriteLine(result);
        //    Console.ReadLine();

        //}

        static string EvenOdd(int num)
        {
            if (num % 2 == 0)
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
