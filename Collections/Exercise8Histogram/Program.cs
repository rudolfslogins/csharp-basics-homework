using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercise8Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            ScoreList[] lists =
            {
                new ScoreList(0, 9),
                new ScoreList(10, 19),
                new ScoreList(20, 29),
                new ScoreList(30, 39),
                new ScoreList(40, 49),
                new ScoreList(50, 59),
                new ScoreList(60, 69),
                new ScoreList(70, 79),
                new ScoreList(80, 89),
                new ScoreList(90, 99),
                new ScoreList(100, 100)
            };
            var readText = File.ReadAllLines(Path);
            foreach (var s in readText)
            {
                Console.WriteLine(s);

            }
            string sclist = readText[0];
            string[] examScores = sclist.Split(' ');

            for (var i = 0; i < examScores.Length; i++)
            {
                for (var j = 0; j < lists.Length; j++)
                {
                    if (Convert.ToInt16(examScores[i]) >= lists[j].MinValue && Convert.ToInt16(examScores[i]) <= lists[j].MaxValue)
                    {
                        lists[j].AddScoreToList();
                    }
                }
            }

            for (var i = 0; i < lists.Length; i++)
            {
                if (lists[i].MinValue == 0)
                {
                    Console.WriteLine($"0{lists[i].MinValue}-0{lists[i].MaxValue}: {lists[i].GetTotalScoreList}");
                }else if (lists[i].MinValue == 100)
                {
                    Console.WriteLine($"  {lists[i].MaxValue}: {lists[i].GetTotalScoreList}");
                }
                else
                {
                    Console.WriteLine($"{lists[i].MinValue}-{lists[i].MaxValue}: {lists[i].GetTotalScoreList}");
                }
                
            }
            Console.ReadKey();
        }
    }
}