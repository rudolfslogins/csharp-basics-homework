using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var personnel = new Staff();
                personnel.Payday();
                //Console.WriteLine(personnel);
                Console.ReadKey();
            }
        }
    }
}
