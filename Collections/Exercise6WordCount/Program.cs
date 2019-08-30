using System;
using System.IO;

namespace Exercise6WordCount
{
    class Program
    {
        private const string Path = "../../lear.txt";

        private static void Main(string[] args)
        {
            var lineCount = 0;
            var wordCount = 0;
            var charCount = 0;
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);
                lineCount++;
                for (var w = 0; w < s.Length; w++)
                {
                    if ((s[w] == ' ' || s[w] == ',' || s[w] == '!' || s[w] == '?' || s[w] == '\'' || w == s.Length -1) 
                        && 
                        !(s[w -1] == ' ' || s[w - 1] == ',' || s[w - 1] == '!' || s[w - 1] == '?' || s[w - 1] == '\''))
                    {
                        wordCount++;
                    }

                    charCount++;
                }
            }
            Console.WriteLine($"\nLines: {lineCount}");
            Console.WriteLine($"Words: {wordCount}");
            Console.WriteLine($"Chars: {charCount}");
            Console.ReadKey();
        }
    }
}