using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalInfoLib;

namespace TestPersonDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****************************");
            Person person = new Person("Sahil", "Radye", "sahilradye11@gmail.com", Convert.ToDateTime("10-11-2000"));
            Console.WriteLine(person.ToString());

            Console.WriteLine("*****************************");
            Console.WriteLine(" Is the person is Adult :" + person.IsAdult());

            Console.WriteLine("*****************************");
            Console.WriteLine(" Today is a Birthday :" + person.Bday());

            Console.WriteLine("*****************************");
            Console.WriteLine(" Person Sun Sign :" + person.SunSign());

            Console.ReadLine();


        }
    }
}
