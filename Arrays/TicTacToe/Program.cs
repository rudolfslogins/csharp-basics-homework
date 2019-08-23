using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            while (1 == 1)
            {
                RunGame('X');
                if (CheckEndOfGame())
                {
                    break;
                }
                RunGame('O');
                if (CheckEndOfGame())
                {
                    break;
                }
            }
            PrintFinalMessage();
            Console.ReadKey();
        }

        private static void RunGame(char player)
        {
            Console.WriteLine($"'{ player }', choose your location (row, column):");
            var input1 = ValidateInput();
            var input2 = ValidateInput();

            Console.Clear();
            UpdateBoard(input1, input2, player);
            DisplayBoard();
        }

        private static int ValidateInput()
        {
            var validInt = false;
            int input;
            do
                //first loop check digit compability 0 1 or 2
            {
                do
                    // second checks if input is digit
                {
                    ConsoleKeyInfo userInput = Console.ReadKey();
                    if (char.IsDigit(userInput.KeyChar))
                    {
                        input = int.Parse(userInput.KeyChar.ToString());
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease write valid int: 0, 1 or 2!");
                    }
                } while (1 == 1);
                if (input == 0 || input == 1 || input == 2)
                {
                    validInt = true;
                }
                else
                {
                    Console.WriteLine("\nPlease write valid int: 0, 1 or 2!");
                }
            } while (validInt == false);

            return input;
        }

        private static void PrintFinalMessage()
        {
            if (DetermineWinner('X'))
            {
                Console.WriteLine("Winner is 'X'! Congrats!");
            }else if (DetermineWinner('O'))
            {
                Console.WriteLine("Winner is 'O'! Congrats!");
            }
            else
            {
                Console.WriteLine("The game is a tie.");
            }
        }
        private static bool DetermineWinner(char player)
        {
            bool isWinner = false;
            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
            {
                isWinner = true;
            } else if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
            {
                isWinner = true;
            }
            else if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
            {
                isWinner = true;
            }
            else if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
            {
                isWinner = true;
            }
            else if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
            {
                isWinner = true;
            }
            else if (board[0, 2] == player && board[1, 2] == player && board[2, 2] == player)
            {
                isWinner = true;
            }
            else if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                isWinner = true;
            }
            else if (board[2, 0] == player && board[1, 1] == player && board[0, 2] == player)
            {
                isWinner = true;
            }

            return isWinner;
        }
        private static bool CheckEndOfGame()
        {
            var result = false;
            var blankCount = 0;
            for (var i = 0; i < board.GetLength(0); i++)
            {
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == ' ')
                    {
                        blankCount++;
                    }
                }
            }

            if (blankCount == 0)
            {
                result = true;
            }
            if (DetermineWinner('X'))
            {
                result = true;
            }else if (DetermineWinner('O'))
            {
                result = true;
            }

            return result;
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void UpdateBoard (int posOne, int posTwo, char player)
        {

                if (board[posOne, posTwo] == ' ')
                {
                    if (player == 'X')
                    {
                        board[posOne, posTwo] = 'X';
                    }
                    else
                    {
                        board[posOne, posTwo] = 'O';
                    }
                }
                else
                {
                    DisplayBoard();
                    Console.WriteLine("Please choose empty position!");
                    RunGame(player);
                    Console.Clear();
                }

        }

        private static void DisplayBoard()
        {
            Console.WriteLine("     0 1 2");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
        }
    }
}
