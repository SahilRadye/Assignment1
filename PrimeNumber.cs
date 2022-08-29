//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DemoApp
//{
//    internal class PrimeNumber
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("************ Prime Number Between 1 to 100 ***************");
//            Console.WriteLine();

//            int prime;
//            for (int i = 2; i < 101; i++)
//            {
//                prime = 0;

//                for (int j = 2; j < i; j++)
//                {
//                    if (i % j == 0)
//                    {
//                        prime = 1;
//                        break;
//                    }
//                }

//                if (i == 2)
//                {
//                    Console.Write(i);
//                }
//                else if (prime == 0)
//                {
//                    Console.Write(" , " + i);
//                }
//            }
//            Console.ReadLine();

//        }


//    }
//}
