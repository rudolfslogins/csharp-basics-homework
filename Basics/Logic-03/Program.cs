using System;

namespace Logic_03
{
    class Program
    {
        //todo: fix the code
        static void Main(string[] args)
        {
            Console.WriteLine(Trims(" Codelex")); //Expected "Codelex"
            Console.ReadKey();
        }

        static string Trims(string codelex)
        {
            return codelex.Trim();
        }
    }
}
