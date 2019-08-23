﻿using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            //var input = Convert.ToInt64(Console.ReadLine());
            var input = Convert.ToDouble(Console.ReadLine());
            //int.TryParse()
            //int.TryParse(input, out int parsed);

            //todo - check if Long
            if (input < Int64.MaxValue) {
                //todo - check if n is less than zero
                if (input < 0) {
                    input *= -1;
                }
                //fixme
                if (input >= 10000000000 ) {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                } else {
                    int digits = 1;
                    if (input <= 10) {
                        digits = 2;
                    } else if (input <= 100) {
                        digits = 3;
                    } else if (input <= 1000) {
                        digits = 4;
                    } else if (input <= 10000) {
                        digits = 5;
                    } else if (input <= 100000) {
                        digits = 6;
                    } else if (input <= 1000000) {
                        digits = 7;
                    } else if (input <= 10000000) {
                        digits = 8;
                    } else if (input <= 100000000) {
                        digits = 9;
                    } else if (input <= 1000000000) {
                        digits = 10;
                    }
                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            } else {
                Console.WriteLine("The number is not a long");
            }

            Console.ReadKey();

        }
    }
}
