using System;
using System.Collections.Generic;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            //TODO: Write a C# program to create a new list, add some elements (string) and print out the collection.
            var colors = new List<string>();

            //TODO: Add 5 colors to list
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Black");
            colors.Add("Yellow");
            colors.Add("Purple");
            colors.Add("White");

            Console.WriteLine(string.Join(",", colors));

            Console.ReadKey();
        }
    }
}