using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    internal class ArrayDemo
    {
        //static void Main(string[] args)
        //{
        //    //Array is a collection of similar data type
        //    //size of array is fixed
        //    //access each element of an array via index
        //    //start index value is 0

        //    //declare array
        //    // datatype[] name = new datatype[size];

        //    //array of 5 integers
        //    int[] numArray = new int[5];
        //    //initialize
        //    //numArray[0] = 100;
        //    //numArray[1] = 44;
        //    //numArray[2] = 55;
        //    //numArray[3] = 22;
        //    //numArray[4] = 454;

        //    //for (int i = 0; i < numArray.Length; i++)
        //    //{
        //    //    Console.WriteLine("Enter a Interger");
        //    //    numArray[i] = Convert.ToInt32(Console.ReadLine());
        //    //}

        //    //Console.WriteLine("--------print-------");

        //    //for(int i = 0; i < numArray.Length; i++)
        //    //{
        //    //    Console.Write(numArray[i] + "\t");
        //    //}

        //    Console.WriteLine("\n===================");

        //    //declare and initialize array on same line
        //    int[] newArrray1 = new int[5] { 122, 455, 8, 6, 44 };

        //    for (int i = 0; i < numArray.Length; i++)
        //    {
        //        Console.WriteLine(newArrray1[i]);
        //    }

        //    Console.WriteLine("\n===================");

        //    //declare and initialize array on same line
        //    int[] newArray2 = { 122, 455, 8, 6, 44 };

        //    newArray2[1] = 45;

        //    for (int i = 0; i < numArray.Length; i++)
        //    {
        //        Console.Write(newArray2[i] + "\t");
        //    }

        //    //Call Method to take Array
        //    NumArray(newArray2);

        //    //To find Length of Array
        //    Console.WriteLine(newArray2.Length);

        //    Console.ReadLine();

        //    //declaration of different types of array

        //    // Create an array of four elements, and add values later
        //    //string[] cars = new string[4];

        //    // Create an array of four elements and add values right away 
        //    //string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

        //    // Create an array of four elements without specifying the size 
        //    //string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        //    // Create an array of four elements, omitting the new keyword, and without specifying the size
        //    //string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };



        //}

        static void NumArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
