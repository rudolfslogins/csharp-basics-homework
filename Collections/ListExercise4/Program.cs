using System;
using System.Collections.Generic;

namespace ListExercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Create a list and add some colors to the list
            var colors = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            //string element = ;
            Console.WriteLine("First element: " + colors[0]);

            //fixme
            //element = ...;
            Console.WriteLine("Third element: " + colors[2]);

            Console.ReadKey();
        }
    }
}