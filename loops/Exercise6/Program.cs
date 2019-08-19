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
            Console.WriteLine("Enter 'FizzBuzz' number below:");
            int max = Convert.ToInt32(Console.ReadLine());

            for (var i = 2; i <= max; i++)
            {
                bool flag = true;
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    flag = false;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    flag = false;
                }
                if (flag)
                {
                    Console.Write(i);
                }

                Console.Write(" ");

                if (i % 20 == 0)
                {
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        
    }
    }
}
