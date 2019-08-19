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
            Console.WriteLine("Enter 'CozaLozaWoza' number below:");
            int result = Convert.ToInt32(Console.ReadLine());

            for (var i = 1; i <= result; i++)
            {
                bool flag = true;
                if (i % 3 == 0)
                {
                    Console.Write("Coza");
                    flag = false;
                } 
                if (i % 5 == 0)
                {
                    Console.Write("Loza");
                    flag = false;
                }
                if (i % 7 == 0)
                {
                    Console.Write("Woza");
                    flag = false;
                }
                if (flag)
                {
                    Console.Write(i);
                }

                Console.Write(" ");

                if (i % 11 == 0)
                {
                    Console.WriteLine("");
                }
            }
            Console.ReadKey();
        }
    }
}
