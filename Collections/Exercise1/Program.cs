using System;
using System.Collections.Generic;

namespace CollectionExercise1
{
    class Program
    {
        /**
           * Origination:
           * Audi -> Germany
           * BMW -> Germany
           * Honda -> Japan
           * Mercedes -> Germany
           * VolksWagen -> Germany
           * Tesla -> USA
           */

        private static void Main(string[] args)
        {
            string[] array = { "Audi -> Germany", "BMW -> Germany", "Honda -> Japan", "Mercedes -> Germany", "VolksWagen -> Germany", "Mercedes -> Germany", "Tesla -> USA" };
            var list = new List<string>();
            var hash = new HashSet<string>();
            var dictionary = new Dictionary<string, string>();
            for (var i = 0; i < array.Length; i++)
            {
                list.Add(array[i].Substring(0, array[i].IndexOf("->")));
                hash.Add(array[i].Substring(0, array[i].IndexOf("->")));
                if (!dictionary.ContainsKey(array[i].Substring(0, array[i].IndexOf("->"))))
                {
                    dictionary.Add(array[i].Substring(0, array[i].IndexOf("->")), array[i].Substring(array[i].IndexOf("->")));
                }
            }
            Console.WriteLine("List: ");
            for (var j = 0; j < list.Count; j++)
            {
                Console.WriteLine(list[j]);
            }
            Console.WriteLine("Hash: ");
            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dictionary: ");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key + item.Value);
            }
            Console.ReadKey();
            //todo - replace array with an List and print out the results

            //todo - replace array with a HashSet and print out the results

            //todo - replace array with a Dictionary (use brand as key and origination as value) and print out the results
        }


    }
}