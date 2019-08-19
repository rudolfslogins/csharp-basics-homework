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
            int[] arr1 = new Int32 [10];
            int[] arr2 = new Int32 [10];
            Random rand = new Random();

            for (var i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(1, 100);
            }
            for (var i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            arr1[arr1.Length - 1] = -7;

            Console.WriteLine(string.Join(",", arr1));
            Console.WriteLine(string.Join(",", arr2));
            Console.ReadKey();
        }
    }
}
