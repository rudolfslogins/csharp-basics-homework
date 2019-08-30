using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDir = new PhoneDirectory();
            int choice;
            
            do
            {
                choice = ShowMenu.Menu();
                if (choice == 1)
                {
                    AddEntry.AddEntryToPb(phoneDir);
                    Console.Clear();
                }
                else if (choice == 2)
                {
                    AddEntries.AddEntriesFromFile(phoneDir);
                    Console.Clear();
                }
                else if (choice == 3)
                {
                    GetContact.GetContactFromPb(phoneDir);
                    Console.Clear();
                }
                else if (choice == 4)
                {
                    GetAllContacts.GetAllContactsFromPb(phoneDir);
                    Console.Clear();
                }
            } while (choice != 5);

            Console.Clear();
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(new string(' ', 10) + "Thank you for using Phone Book" + new string(' ', 10));
            System.Threading.Thread.Sleep(1500);

        }
    }
}
