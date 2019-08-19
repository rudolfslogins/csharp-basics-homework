using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] upperList =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V',
                'Z', 'X', 'Y', 'W', 'Q'
            };
            int uppercaseCount = 0;
            Console.WriteLine("Please enter a string below:");
            String input = Console.ReadLine();
            char[] inputToCharArray = input.ToCharArray();
            for (var i = 0; i < inputToCharArray.Length; i++)
            {
                for (var n = 0; n < upperList.Length; n++)
                {
                    if (inputToCharArray[i] == upperList[n])
                    {
                        uppercaseCount++;
                    }
                }
            }
            Console.WriteLine("Uppercase letter count: " + uppercaseCount);
            Console.ReadKey();
        }
    }
}
