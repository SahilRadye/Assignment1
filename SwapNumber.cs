using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class SwapNumber
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            Console.WriteLine($"Before Swapping :- Number 1 : {number1} , Number 2 : {number2}");
            Swapping(ref number1, ref number2);
            Console.WriteLine($"After Swapping :- Number 1 : {number1} , Number 2 : {number2}");


            Console.ReadLine();
        }

        static void Swapping(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
