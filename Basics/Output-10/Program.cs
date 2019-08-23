using System;

namespace Output_10
{
    class Program
    {
        //todo: change the function so it concatinates 3 words together
        //in Main method display the result.
        static void Main(string[] args)
        {
            var result = Concatet("hello", "from", "Codelex");

            Console.ReadKey();
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static string Concatet(string w1, string w2, string w3)
        {
            return string.Concat(w1, w2, w3);
        }
    }
}
