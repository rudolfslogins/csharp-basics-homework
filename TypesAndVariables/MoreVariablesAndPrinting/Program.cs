using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {

            var name = "Zed A. Shaw";
            var age = 35;
            var height = 74;  // inches
            var weight = 180; // lbs
            var eyes = "Blue";
            var teeth = "White";
            var hair = "Brown";

            Console.WriteLine($"Let's talk about { name }.");
            Console.WriteLine($"He's { getHeightInMetric(height).ToString("0.##") } cm tall.");
            Console.WriteLine($"He's { getHWeightInMetric(weight).ToString("0.##") } kg heavy.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"He's got { eyes } eyes and { hair } hair.");
            Console.WriteLine($"His teeth are usually { teeth } depending on the coffee.");
            Console.WriteLine($"If I add { age }, { height }, and { weight } I get { (age + getHeightInMetric(height) + getHWeightInMetric(weight)).ToString("0.##") }.");
            Console.ReadKey();
        }
        static double getHeightInMetric (double height )
        {
            return height * 2.54;
        }
        static double getHWeightInMetric(double weight)
        {
            return weight * 0.453592;
        }
    }
}