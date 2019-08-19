using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Enter column count below:");
                int usrInput = Convert.ToInt32(Console.ReadLine());

                var columnCount = usrInput;
                var asterixCount = 0;
                for (int i = 0; i < columnCount; i++)
                {

                    Console.Write(new string('/', 4 * (columnCount - asterixCount - 1)) +
                                  new string('*', 4 * asterixCount * 2) +
                                  new string('\\', 4 * (columnCount - asterixCount - 1)));
                    asterixCount++;
                    Console.WriteLine("");
                }
                Console.WriteLine("Repat? y / n");
                ConsoleKeyInfo userInput = Console.ReadKey();
                var continueAnswer = char.Parse(userInput.KeyChar.ToString());
                if (continueAnswer == 'n')
                {
                    repeat = false;
                }
                else
                {
                    repeat = true;
                }
                Console.Clear();
            } while (repeat == true);

            Console.ReadKey();
        }
    }
}
