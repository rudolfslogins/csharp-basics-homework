using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var soundsList = new List<ISound>
            {
                new Parrot(),
                new Firework(),
                new Radio(),
                new Parrot(),
                new Firework(),
                new Radio()
            };
            for (int i = 0; i < soundsList.Count; i++)
            {
                soundsList[i].PlaySound();
            }

            Console.ReadKey();
        }
    }
}
