using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product("Logitech mouse", (decimal) 70.00, 14);
            Product phone = new Product("iPhone 5s", (decimal) 999.99, 3);
            Product printer = new Product("Epson EB-U05", (decimal) 440.46, 1);
            mouse.PrintProduct();
            phone.PrintProduct();
            printer.PrintProduct();
            mouse.AddAmount(5);
            mouse.ChangePrice((decimal) 29.99);
            mouse.PrintProduct();
            Console.ReadKey();
        }
    }
}
