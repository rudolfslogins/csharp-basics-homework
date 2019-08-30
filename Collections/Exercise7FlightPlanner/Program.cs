using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise7FlightPlanner
{
    class Program
    {
        private const string Path = "../../flights.txt";
        private static List<string> flightList = new List<string>();
        private static List<string> flightJourney = new List<string>();
        private static HashSet<string> departureCity = new HashSet<string>();
        private static HashSet<string> destinationCities = new HashSet<string>();
        private static string startCity = "";

        private static void Main(string[] args)
        {
            CreateLists();
            do
            {
                Console.WriteLine("What would you like to do:");
                Console.WriteLine("To display list of the cities press 1");
                Console.WriteLine("To exit program press #");
                ConsoleKeyInfo userInput = Console.ReadKey();
                var input1 = char.Parse(userInput.KeyChar.ToString());
                if (input1 == '#')
                {
                    Environment.Exit(0);
                }

                if (input1 == '1')
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Choose valid option!");
            } while (1 == 1);
            Console.Clear();
            Console.WriteLine("Choose departure city from following:");
            Console.WriteLine(string.Join("\n", departureCity) + "\n");
            startCity = ValidateInput();
            flightJourney.Add(startCity);

            while (1 == 1)
            {
                destinationCities.Clear();
                Console.WriteLine("Choose destination city from following:");
                for (int i = 0; i < flightList.Count; i++)
                {
                    if (flightList[i].StartsWith(startCity))
                    {
                        Console.WriteLine(flightList[i].Substring(flightList[i].IndexOf(">") + 2));
                        destinationCities.Add((flightList[i].Substring(flightList[i].IndexOf(">") + 2)));
                    }
                }
                Console.WriteLine("");
                startCity = ValidateInput();
                do
                {
                    if (!destinationCities.Contains(startCity))
                    {
                        Console.WriteLine("Please enter valid destination!");
                        startCity = ValidateInput();

                    }
                } while (ValidateDestination(startCity) == false);
                
                if (flightJourney[0].Equals(startCity))
                {
                    Console.Clear();
                    Console.WriteLine("Thank You! Your Journey has been planned!");
                    flightJourney.Add(startCity);
                    break;
                }
                Console.Clear();
                flightJourney.Add(startCity);
            }
            Console.WriteLine(string.Join("->", flightJourney));
            Console.ReadKey();

        }

        private static void CreateLists()
        {
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                //Console.WriteLine(s);
                if (!s.Equals(" "))
                {
                    flightList.Add(s);
                    departureCity.Add(s.Substring(0, s.IndexOf("->")));
                }
            }
        }

        private static bool ValidateDestination(string destination)
        {
            return destinationCities.Contains(destination);
        }

        private static string ValidateInput()
        {
            var tempInput = Console.ReadLine();
            var end = false;
            while (end == false)
            {
                for (var i = 0; i < flightList.Count; i++)
                {
                    if (flightList[i].StartsWith(tempInput))
                    {
                        end = true;
                        break;
                    }
                }

                if (end == true)
                {
                    break;
                }
                Console.WriteLine("Please enter valid city!");
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }

    }
}