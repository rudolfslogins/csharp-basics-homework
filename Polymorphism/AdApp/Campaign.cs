using System;
using System.Collections.Generic;
using System.Linq;

namespace AdApp
{
    public class Campaign
    {
        private List<Advert> _campaign; 

        public Campaign()
        {
            _campaign = new List<Advert>();
        }

        public void AddAdvert(Advert a)
        {
            _campaign.Add(a);
        }

        public int GetCost()
        {
            return _campaign.Sum(item => item.Cost());
        }

        public override string ToString()
        {
            Console.Write($"\nAdvert Campaign:");
            _campaign.ForEach(c => Console.Write(c));

            return $"\nTotal Cost {GetCost()}";
        }
    }
}