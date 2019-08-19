using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter min value:");
            int min = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Please enter max value:");
            int max = Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Min: {min}\nMax: {max}\n");

            for (var i = 0; i < max; i++)
            {
                //Console.WriteLine(min + i);
                for (var j = 0; j < max; j++)
                {
                    if ((min + j + i) <= max)
                    {
                        Console.Write(min + j + i);
                    }
                    else
                    {
                        Console.Write(min + j + i - max);
                    }
                    
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
