using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string S = Console.ReadLine();
        char[] input = S.ToCharArray();
        char[] result = new char[input.Length];
        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");
        for (var i = 0; i < input.Length; i++)
        {
            if (Char.IsUpper(input[i]))
            {
                result[i] = Char.ToLower(input[i]);
            }
            else
            {
                result[i] = Char.ToUpper(input[i]);
            }
        }

        Console.WriteLine(result);
        Console.ReadKey();
    }
}