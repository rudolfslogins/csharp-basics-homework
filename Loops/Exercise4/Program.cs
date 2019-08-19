using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise4
{
    class Program
    {
        //TODO: print all vowels using for and foreach
        static void Main(string[] args)
        {
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};

            /*
            todo - use for*/
            for (var i = 0; i < vowels.Length; i++) {
                Console.WriteLine(vowels[i]);
            }

            Console.ReadKey();

            /*
            todo - use foreach*/
            foreach (var VARIABLE in vowels)
            {
                Console.WriteLine(VARIABLE);
            }
            Console.ReadKey();

        }
    }
}
