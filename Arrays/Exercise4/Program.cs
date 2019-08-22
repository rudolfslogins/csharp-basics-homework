using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        //TODO: Write a C# program to test if an array contains a specific value.
        private static void Main(string[] args)
        {
            int[] myArray = {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };
            Console.WriteLine("Please enter number you want to search for:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            bool contains = false;
            /*
            fixme - check if contains number 1245 */
            for (var i = 0; i < myArray.Length; i++) {
                if (userInput == myArray[i])
                {
                    contains = true;
                }
            }
            if (contains)
            {
                Console.WriteLine("Contains!");
            }
            else
            {
                Console.WriteLine("Not contains!");
            }

            Console.ReadKey();
        }
    }
}
