﻿using System;

namespace Output_09
{
    class Program
    {
        //todo: using function return hello world and display it.
        static void Main(string[] args)
        {
            Console.WriteLine(Concatet("Hello ", "World!"));
            Console.ReadKey();
        }

        static string Concatet(string w1, string w2)
        {
            return string.Concat(w1, w2);
        }
    }
}
