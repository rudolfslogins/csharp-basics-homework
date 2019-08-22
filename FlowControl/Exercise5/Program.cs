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
            var input = Console.ReadLine().ToLower();
            char[] charInput = input.ToCharArray();

            foreach (var item in charInput)
            {
                switch (item)
                {
                    case 'a': case 'b': case 'c':
                        Console.WriteLine(2);
                        break;
                    case 'd': case 'e': case 'f':
                        Console.WriteLine(3);
                        break;
                    case 'g': case 'h': case 'i':
                        Console.WriteLine(4);
                        break;
                    case 'j': case 'k': case 'l':
                        Console.WriteLine(5);
                        break;
                    case 'm': case 'n': case 'o':
                        Console.WriteLine(6);
                        break;
                    case 'p': case 'q': case 'r': case 's':
                        Console.WriteLine(7);
                        break;
                    case 't': case 'u': case 'v':
                        Console.WriteLine(8);
                        break;
                    case 'w': case 'x': case 'y': case 'z':
                        Console.WriteLine(9);
                        break;
                }
            }

            Console.ReadKey();

        }
    }
}
