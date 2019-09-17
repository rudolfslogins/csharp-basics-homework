namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int rate;

        public NewspaperAd(int fee, int columnCm, int ratePerCm) : base(fee)
        {
            _column = columnCm;
            rate = ratePerCm;
        }

        public override int Cost()
        {
            var fee = base.Cost();
            return fee + rate * _column;
        }

        public override string ToString()
        {
            return base.ToString()
                   + " Newspaper ad: column_cm =" + _column
                   + " rate=" + rate;
        }
    }
}