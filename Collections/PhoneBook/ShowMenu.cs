using System;

namespace PhoneBook
{
    public class ShowMenu
    {
        public static int Menu()
        {
            Console.WriteLine("-==≡≡≡YOUR ULTIMATE PHONE BOOK≡≡≡==-\n");
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Add entry to phone book");
            Console.WriteLine("2. Add entries from file");
            Console.WriteLine("3. Display entry from phone book");
            Console.WriteLine("4. Display all entries from phone book");
            Console.WriteLine("5. Quit phone book");

            var keyboard = Console.ReadKey();

            int.TryParse(keyboard.KeyChar.ToString(), out var userChoice);

            while (userChoice < 1 || userChoice > 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter valid choice- 1, 2, 3, 4 or 5!");
                keyboard = Console.ReadKey();
                int.TryParse(keyboard.KeyChar.ToString(), out userChoice);
            }
            Console.WriteLine("");
            return userChoice;
        }
    }
}