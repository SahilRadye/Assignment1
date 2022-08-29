using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingLib;

namespace TestShopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("parleG" ,2 ,10);
            Console.WriteLine(product1.ToString());

            Console.WriteLine("*******************************************");
            

            Product product2 = new Product("bourbon", 4, 20);
            Console.WriteLine(product2.ToString());

            Console.WriteLine("*******************************************");

            Product product3 = new Product("krackJack", 3, 15);
            Console.WriteLine(product3.ToString());

            Console.WriteLine("*******************************************");

            Console.ReadLine();

        }
    }
}
