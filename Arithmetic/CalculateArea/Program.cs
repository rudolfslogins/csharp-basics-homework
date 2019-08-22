using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice; // The user's menu choice

            do
            {
                // Get the user's menu choice.
                choice = GetMenu();

                if (choice == 1)
                {
                    Console.WriteLine("\nYou chose 1");
                    CalculateCircleArea();
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nYou chose 2");
                    CalculateRectangleArea();
                    Console.ReadKey();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("\nYou chose 3");
                    CalculateTriangleArea();
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("\nThanks for calculating!");
                    Console.ReadKey();
                }

            } while (choice != 4);
        }

        public static int GetMenu()
        {

            int userChoice;
            
            // keyboard input

            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();
            // get input from user
            int.TryParse(keyboard.KeyChar.ToString(), out userChoice);

            // validate input
            while (userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("\nPlease enter a valid range: 1, 2, 3, or 4: ");
                keyboard = Console.ReadKey();
                int.TryParse(keyboard.KeyChar.ToString(), out userChoice);
                //userChoice = keyboard.KeyChar;
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            // Get input from user
            Console.WriteLine("What is the circle's radius? ");
            var keyboard = Console.ReadLine();
            double.TryParse(keyboard, out var radius);

            // Display output
            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            // Get length
            Console.WriteLine("Enter length? ");
            var keyboard = Console.ReadLine();
            double.TryParse(keyboard, out var length);

            // Get width
            Console.WriteLine("Enter width? ");
            keyboard = Console.ReadLine();
            double.TryParse(keyboard, out var width);

            // Display output
            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfRectangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            // Get the base
            Console.WriteLine("Enter length of the triangle's base? ");
            var keyboard = Console.ReadLine();
            double.TryParse(keyboard, out var ground);

            // Get the height
            Console.WriteLine("Enter triangle's height? ");
            keyboard = Console.ReadLine();
            double.TryParse(keyboard, out var height);

            // Display the triangle's area.
            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfTriangle(ground, height));
        }
    }
}
