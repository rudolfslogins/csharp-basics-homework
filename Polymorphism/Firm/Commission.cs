namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,
            double commRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales = totalSales;
        }

        public override double Pay()
        {
            var finalPay = base.Pay() + (_totalSales * _commissionRate);
            _totalSales = 0;
            return finalPay;
        }
        public override string ToString()
        {
            var res = base.ToString();
            res += $"\nTotal sales: {_totalSales}\nCommision Rate: {_commissionRate}";
            return res;
        }
    }
}