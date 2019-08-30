using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int input = Convert.ToInt16(Console.ReadLine());
            var inputList = new List<int>();
            var result = 0;
            int startInput = input;
            int maxCount = 20;
            int count = 0;

            while (1 == 1)
            {
                foreach (var item in input.ToString())
                {
                    inputList.Add(item - 48);
                }

                for (var i = 0; i < inputList.Count; i++)
                {
                    result += Square(inputList[i]);
                    if (i < inputList.Count - 1)
                    {
                        Console.Write($"{inputList[i]}^2 + ");
                    }
                    else
                    {
                        Console.Write($"{inputList[i]}^2 = ");
                    }
                }
                Console.Write($"{result}\n");
                if (result == 1)
                {
                    Console.WriteLine($"{startInput} is a 'Happy' int!");
                    break;
                }
                else if(result == startInput || count == maxCount)
                {
                    Console.WriteLine($"{startInput} is NOT a 'Happy' int!");
                    break;
                }
                inputList.Clear();
                input = result;
                result = 0;
                count++;
            }


            Console.ReadKey();
        }

        public static int Square(int input)
        {
            return input * input;
        }
    }
}
