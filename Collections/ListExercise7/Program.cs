using System;
using System.Collections.Generic;

namespace ListExercise7
{
    class Program
    {
        private static void Main(string[] args)
        {
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };
            Console.WriteLine(string.Join(", ", colors));
            Console.WriteLine("\nEnter element to search:");
            string searchElement = Console.ReadLine();
          //TODO: Check if list contains "White" element
            if (colors.Contains(searchElement)) {
                Console.WriteLine("Found the element");
           } else {
                Console.WriteLine("There is no such element");
            }
            Console.ReadKey();
        }
    }
}