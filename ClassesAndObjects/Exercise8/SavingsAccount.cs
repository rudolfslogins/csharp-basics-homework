namespace Exercise8
{
    public class SavingsAccount
    {
        private decimal _annualInterestRate;
        private decimal _balance;
        private decimal _interest;

        public SavingsAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        public decimal Interest
        {
            get { return _interest; }
        }
        public decimal Balance
        {
            get { return _balance; }
        }

        public decimal SetAnnualInterestRate
        {
            set { _annualInterestRate = value; }
        }

        public void Withdrawal(decimal amount)
        {
            _balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void AddMonthlyInterest()
        {
            decimal monthlyIntRate = _annualInterestRate / 12;
            _interest += _balance * monthlyIntRate;
            _balance += _balance * monthlyIntRate;
        }
    }
}