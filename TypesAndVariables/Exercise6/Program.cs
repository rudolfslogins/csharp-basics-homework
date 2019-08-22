using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter digits below:");
            var input = Console.ReadLine();
            char[] charInput = input.ToCharArray();
            int arraySum = 0;
            for (var i = 0; i < charInput.Length; i++)
            {
                arraySum = arraySum + Convert.ToInt16(charInput[i]) - 48;
            }
            Console.WriteLine(arraySum);
            Console.ReadKey();
        }

    }
}
