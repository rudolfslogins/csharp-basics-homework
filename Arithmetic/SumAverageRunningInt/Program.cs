using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lower bound below:");
            int lowerBoundInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter upper bound below:");
            int upperBoundInput = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = lowerBoundInput; i <= upperBoundInput; i++)
            {
                result = result + i;
            }
            Console.WriteLine($"The sum of { lowerBoundInput } to { upperBoundInput } is { result }");
            Console.WriteLine($"The average is {(Convert.ToDouble(lowerBoundInput) + Convert.ToDouble(upperBoundInput)) / 2}");
            Console.ReadKey();
        }
    }
}
