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
            var inputList = new HashSet<string>();
            var input = "";

            while (1 == 1)
            {
                Console.WriteLine("Enter name:");
                input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }

                inputList.Add(input);
            }
            Console.WriteLine($"Unique name list contains: {string.Join(" ", inputList)}");
            Console.ReadKey();

        }
    }
}
