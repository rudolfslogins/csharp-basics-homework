namespace AdApp
{
    public class TVAd : Advert
    {
        private int _sec;
        private int _rate;
        private bool _peak;

        public TVAd(int fee, int sec, int rate, bool peak) : base(fee)
        {
            this._sec = sec;
            this._rate = rate;
            this._peak = peak;
        }

        public override int Cost()
        {
            return base.Cost() + _sec * (_peak ? _rate * 2 : _rate);
        }

        public override string ToString()
        {
            return base.ToString() + " TV ad: length= " + _sec + " secs."
                   + " Rate=" + (_peak ? _rate * 2 : _rate);
        }
    }
}