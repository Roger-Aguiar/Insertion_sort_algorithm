/*
Name:         Roger Silva Santos Aguiar
Function:     Test InsertionSort class
Initial date: June 14, 2020
Last update:  June 14, 2020
*/
using System;

namespace MyApp_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!"); */

            //It creates an object of the class RandomNumbers
            RandomNumbers generate = new RandomNumbers(10, 10, 100);

            //It displays the result
            Console.WriteLine(generate);
        }//End main method
    }//End class
}
