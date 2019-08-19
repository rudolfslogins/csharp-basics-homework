using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            var a = i = 2;
            Console.WriteLine("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            /*
            todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            */
            for (var j = n; j > 1; j--)
            {
                a = a * i;
            }
            Console.WriteLine(a);
            Console.ReadKey();
            Math.Pow();
        }
    }
}
