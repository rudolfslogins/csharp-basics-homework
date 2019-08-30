using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);

            Console.WriteLine("Before swap:");
            Console.WriteLine("(" + p1.Point1 + ", " + p1.Point2 + ")");
            Console.WriteLine("(" + p2.Point1 + ", " + p2.Point2 + ")");

            SwapPoints(p1, p2);

            Console.WriteLine("\nAfter swap:");
            Console.WriteLine("(" + p1.Point1 + ", " + p1.Point2 + ")");
            Console.WriteLine("(" + p2.Point1 + ", " + p2.Point2 + ")");

            Console.ReadKey();
        }
        public static void SwapPoints(Point first, Point second)
        {
            int tempPointOne = first.Point1;
            int tempPointTwo = first.Point2;

            first.Point1 = second.Point1;
            first.Point2 = second.Point2;
            second.Point1 = tempPointOne;
            second.Point2 = tempPointTwo;

        }
    }

}
