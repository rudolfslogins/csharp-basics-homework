namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        //per day
        private int _numDays;

        public Hoarding(int fee, int rate, int numDays) : base(fee)
        {
            _rate = rate;
            _numDays = numDays;
        }

        public override int Cost()
        {
            return base.Cost() + _rate * _numDays;
        }

        public override string ToString()
        {
            return base.ToString() + " Hoarding: Days=" + _numDays + " Rate=" + _rate;
        }
    }
}