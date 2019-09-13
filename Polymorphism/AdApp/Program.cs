using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Campaign();
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TVAd(50000, 1000, 30, true));
            Console.WriteLine(c);
            c.AddAdvert(new Poster(100, 20, 30, 100, 1));
            c.AddAdvert(new Poster(0,50,60,100, 2));
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
