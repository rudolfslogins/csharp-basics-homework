using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            var firstWord = Console.ReadLine();

            Console.WriteLine("Enter second word:");
            var secondWord = Console.ReadLine();

            int dotLength = 30 - firstWord.Length - secondWord.Length;

            Console.WriteLine(firstWord + new String('.', dotLength) + secondWord);
            Console.ReadKey();
        }
    }
}
