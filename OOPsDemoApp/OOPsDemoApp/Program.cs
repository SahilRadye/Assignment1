using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object
            Rectangle rectangle = new Rectangle();

            Console.WriteLine(rectangle); //To invoke ToString() Method
            rectangle.Length = 30;
            rectangle.Width = 10;

            int area = rectangle.GetArea();

            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("Area of rectangle = " + area);

            

            Rectangle rectangle1 = new Rectangle(5,2);

            Console.WriteLine(rectangle1);
            area = rectangle1.GetArea();
            Console.WriteLine(area);


            Console.WriteLine("=======================");
            Console.WriteLine("Total count of Class : " + Rectangle.Counter);


            Console.ReadLine();

        }
    }
}
