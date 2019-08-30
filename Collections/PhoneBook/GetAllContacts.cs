using System;
namespace PhoneBook
{
    public class GetAllContacts
    {
        public static void GetAllContactsFromPb(PhoneDirectory input)
        {
            if (input.GetLength() == 0)
            {
                Console.WriteLine("Sorry, no entries in Phone Book!");
            }
            else
            {
                for (int i = 0; i < input.GetLength(); i++)
                {
                    Console.WriteLine($"Name: {input.GetName(i)}, Number: {input.GetNumber(input.GetName(i))}");
                }
            }
            Console.ReadKey();
        }
    }
}