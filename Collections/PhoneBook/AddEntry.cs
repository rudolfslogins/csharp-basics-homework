using System;

namespace PhoneBook
{
    public class AddEntry
    {
        public static void AddEntryToPb(PhoneDirectory input)
        {
            Console.WriteLine("Please enter contact name:");
            var name = Console.ReadLine();
            Console.WriteLine("Please enter contact number:");
            var number = Console.ReadLine();
            input.PutNumber(name, number);
            Console.WriteLine("Contact added!");
            Console.ReadKey();
        }
    }
}