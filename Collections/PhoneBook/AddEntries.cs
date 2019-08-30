using System;
using System.IO;
namespace PhoneBook
{
    public class AddEntries
    {
        public static void AddEntriesFromFile(PhoneDirectory input)
        {
            const string path = "../../contacts.txt";
            var readText = File.ReadAllLines(path);
            var updated = 0;
            var created = 0;
            foreach (var s in readText)
            {
                if (!s.Equals(" "))
                {
                    string[] line = s.Split(new string[] { ", " }, StringSplitOptions.None);
                    if (input.PutNumber(line[0], line[1]) == "updated")
                    {
                        updated++;
                    }
                    else
                    {
                        created++;
                    }
                }
            }
            Console.WriteLine($"{readText.Length} contacts processed!");
            Console.WriteLine($"{updated} contact(s) updated, {created} contact(s) created.");
            Console.ReadKey();
        }
    }
}