using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main()
        {
            //create reference variable for List class & create object of List class
            List<int> myListInt = new List<int>(10) { 10, 20, 30 };

            //read elements using foreach loop
            Console.WriteLine("Using foreach loop:");
            foreach (int item in myListInt)
            {
                Console.WriteLine(item); //Output: 10 20 30
            }
            Console.WriteLine("End list");

            //read elements using for loop
            Console.WriteLine("\nUsing for loop:");
            for (int i = 0; i < myListInt.Count; i++)
            {
                Console.WriteLine(myListInt[i]); //Output: 10 20 30
            }
            Console.WriteLine("End list");

            List<char> myListChar = new List<char>(10) { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            //read elements using foreach loop
            Console.WriteLine("\nUsing foreach loop:");
            foreach (char item in myListChar)
            {
                Console.WriteLine(item); //Output: 10 20 30
            }
            Console.WriteLine("End list");

            Console.WriteLine("\nUsing for loop:");
            for (int i = 0; i < myListChar.Count; i++)
            {
                Console.WriteLine(myListChar[i]); //Output: 10 20 30
            }
            Console.WriteLine("End list");

            Console.ReadKey();
        }
    }
}
