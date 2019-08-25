using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal withdrawAmount = 0;
            decimal depositAmount = 0;
            decimal interestAmount = 0;
            int period;


            Console.WriteLine("How much money is in the account?");
            SavingsAccount firstAccount = new SavingsAccount(Convert.ToDecimal(Console.ReadLine()));

            Console.WriteLine("Enter the annual interest rate:");
            firstAccount.SetAnnualInterestRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("How long has the account been opened?");
            period = Convert.ToInt16(Console.ReadLine());

            for (var i = 1; i <= period; i++)
            {
                decimal amount = 0;
                Console.WriteLine($"Enter amount deposited for month {i}:");
                amount = Convert.ToDecimal(Console.ReadLine());
                depositAmount += amount;
                firstAccount.Deposit(amount);

                Console.WriteLine($"Enter amount withdrawn for month {i}:");
                amount = Convert.ToDecimal(Console.ReadLine());
                withdrawAmount += amount;
                firstAccount.Withdrawal(amount);

                firstAccount.AddMonthlyInterest();
            }
            Console.WriteLine($"Total deposited: {depositAmount.ToString("C2", new CultureInfo("en-US"))}");
            Console.WriteLine($"Total withdrawn: {withdrawAmount.ToString("C2", new CultureInfo("en-US"))}");
            Console.WriteLine($"Interest earned: {firstAccount.Interest.ToString("C2", new CultureInfo("en-US"))}");
            Console.WriteLine($"Ending balance: {firstAccount.Balance.ToString("C2", new CultureInfo("en-US"))}");
            
            Console.ReadKey();
        }
    }
}
