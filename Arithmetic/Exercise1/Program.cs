using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 1;
            int two = 13;
            int margin = 15;
            Console.WriteLine(CheckNumber(one, two, margin));
            Console.ReadKey();

            }
            static bool CheckNumber(int o, int t, int m)
            {
                if (0 == m || t == m || o + t == m || o - t == m)
                {
                    return true;
                }

                return false;
            }
    }
}
