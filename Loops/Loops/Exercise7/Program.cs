using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");
            int points = 0;
            do
            {
                int userDiceNr = RollDice();
                points += userDiceNr;
                if (userDiceNr == 1)
                {
                    points = 0;
                    break;
                }
                Console.WriteLine("Roll again?");
                string userAnswer = CaptureAnswer(Console.ReadLine());
                while (userAnswer == "ERROR")
                {
                    Console.WriteLine("Please answer Yes or No!");
                    userAnswer = CaptureAnswer(Console.ReadLine());
                }
                if (userAnswer == "NO")
                {
                    break;
                }
            }
            while (1 == 1);
            Console.WriteLine("You got " + points + " points.");
            Console.WriteLine("Press any key to quit!");
            Console.ReadKey();
        }
        static int RollDice()
        {
            int diceNumber = new Random().Next(1, 6);
            Console.WriteLine("You rolled a " + diceNumber + "!");
            return diceNumber;
        }
        static string CaptureAnswer(string answerInput)
        {
            string answerOut;
            if (answerInput == "Yes" || answerInput == "yes" || answerInput == "YES" || answerInput == "y" || answerInput == "Y")
            {
                answerOut = "YES";
            }
            else if (answerInput == "No" || answerInput == "no" || answerInput == "NO" || answerInput == "n" || answerInput == "N")
            {
                answerOut = "NO";
            }
            else
            {
                answerOut = "ERROR";
            }
            return answerOut;
        }
    }
}
