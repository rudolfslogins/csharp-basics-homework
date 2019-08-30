using System;
namespace PhoneBook
{
    public class GetContact
    {
        public static void GetContactFromPb(PhoneDirectory input)
        {
            Console.WriteLine("Please enter contact name:");
            var name = Console.ReadLine();
            if (input.GetNumber(name) == null)
            {
                Console.WriteLine($"Sorry, no contact {name} in Phone Book!");
            }
            else
            {
                Console.WriteLine($"Name: {name}, Number: {input.GetNumber(name)}");
            }
            Console.ReadKey();
        }
    }
}