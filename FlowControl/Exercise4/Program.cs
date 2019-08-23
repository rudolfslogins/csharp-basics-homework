using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = 0;
            bool validDay = false;
            int[] inputDays = { 0, 1, 2, 3, 4, 5, 6};
            Console.WriteLine("Input week day number 0 to 6, where 0 is Sunday and 6 is Saturday.");
            
            do
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (char.IsDigit(userInput.KeyChar))
                {
                    input = int.Parse(userInput.KeyChar.ToString());
                    for (var i = 0; i < inputDays.Length; i++)
                    {
                        if (input == inputDays[i])
                        {
                            validDay = true;
                            break;
                        }
                    }

                    if (validDay == true)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nNot a valid day"); //&& validInput1
                    }

                }
                else
                {
                    Console.WriteLine("\nPlease input number, instead of char!");
                }

            } while (1 == 1 );

            Console.Write("\n");

            switch (input)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;

            }

            Console.ReadKey();
        }
    }
}
