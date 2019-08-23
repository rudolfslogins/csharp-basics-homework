using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        private static string[] wordList= {"apple", "banana", "mustard", "raspberry", "watermelon" };
        private static char[] hiddenWord = { };
        private static char[] displayWord = { };
        private static char guessChar;
        private static char[] misses = { };
        private static int maxMisses = 7;
        private static int tryCounter;
        private static char var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, var12, var13;
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                var1 = ' ';
                var2 = ' ';
                var3 = ' ';
                var4 = ' ';
                var5 = ' ';
                var6 = ' ';
                var7 = ' ';
                var8 = '|';
                var9 = '|';
                var10 = '|';
                var11 = '|';
                var12 = 'Z';
                var13 = 'Z';
                tryCounter = 0;
                guessChar = ' ';
                ChooseWord();
                DisplayBoard();
                RunGame();
            } while (ShouldRetry());

        }

        private static void RunGame()
        {
            do
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                guessChar = char.Parse(userInput.KeyChar.ToString());
                UpdateBoard(guessChar);
                Console.Clear();
                DisplayBoard();
            } while (CheckEndOfGame() == "");

            if (CheckEndOfGame() == "WIN")
            {
                Console.WriteLine("\nYOU GOT IT!");
            }
            else
            {
                Console.WriteLine("\nYOU LOST IT!");
            }
        }

        private static void UpdateBoard(char input)
        {
            bool miss = true;
            for (var i = 0; i < hiddenWord.Length; i++)
            {

                if (input == hiddenWord[i])
                {
                    displayWord[i] = input;
                    miss = false;
                }
            }
            if (miss)
            {
                for (var i = 0; i < misses.Length; i++)
                {
                    if (misses[i].Equals(' '))
                    {
                        ++tryCounter;
                        misses[i] = input;
                        if (i == (misses.Length - 7))
                        {
                            var1 = 'O';
                        }else if (i == (misses.Length - 6))
                        {
                            var2 = '/';
                        }
                        else if (i == (misses.Length - 5))
                        {
                            var3 = '|';
                        }
                        else if (i == (misses.Length - 4))
                        {
                            var4 = '\\';
                        }
                        else if (i == (misses.Length - 3))
                        {
                            var5 = '/';
                        }
                        else if (i == (misses.Length - 2))
                        {
                            var6 = '\\';
                        }
                        else if (i == (misses.Length - 1))
                        {
                            var7 = '|';
                            var8 = ' ';
                            var9 = ' ';
                            var10 = ' ';
                            var11 = ' ';
                            var12 = ' ';
                            var13 = ' ';
                        }
                        break;
                    }
                }

            }
        }

        private static void ChooseWord()
        {
            Random rand = new Random();
            hiddenWord = wordList[rand.Next(1, wordList.Length)].ToCharArray();
            displayWord = new char [hiddenWord.Length];
            misses = new char[maxMisses];

            for (var i = 0; i < displayWord.Length; i++)
            {
                displayWord[i] = '_';
            }

            for (var i = 0; i < misses.Length; i++)
            {
                misses[i] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.Write("Misses counter: " + tryCounter + "/" + maxMisses + "\n");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.Write("Word: ");
            PrintArray(displayWord, " ");
            Console.Write("\nMisses: ");
            PrintArray(misses, "");
            Console.Write("\nGuess: " + guessChar);
            Console.WriteLine("\n  _____");
            Console.WriteLine($"  |/   {var7}");
            Console.WriteLine($"  |    {var1}");
            Console.WriteLine($"  |   {var2}{var3}{var4}");
            Console.WriteLine($"  |   {var5} {var6}");
            Console.WriteLine($" /|\\  {var8}{var12}{var9}");
            Console.WriteLine($"/ | \\ {var10}{var13}{var11}");
        }

        private static void PrintArray(char[] input, string separator)
        {
            for (var i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + separator);
            }
        }
        private static string CheckEndOfGame()
        {
            string result = "";
            int blankLetters = 0;
            for (var i = 0; i < displayWord.Length; i++)
            {
                if (displayWord[i] == '_')
                {
                    blankLetters++;
                }
            }
            if (tryCounter == maxMisses)
            {
                result = "LOST";
            }else if (blankLetters == 0)
            {
                result = "WIN";
            }
            return result;
        }

        private static bool ShouldRetry()
        {
            Console.WriteLine("Play again or quit? Y/N");
            bool result = false;
            char answer;
            bool flag;
            do
            {
                ConsoleKeyInfo userInput1 = Console.ReadKey();
                answer = char.Parse(userInput1.KeyChar.ToString().ToLower());
                if (answer == 'y')
                {
                    result = true;
                    flag = true;
                }
                else if ( answer == 'n')
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("\nWrong input! Press 'y' or 'n'!");
                    flag = false;
                }
            } while (flag == false);

            return result;

        }
    }
}
