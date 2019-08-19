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
            int res = 1;
            for (var i = 1; i <= 10; i++)
            {
                res = res * i;
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
