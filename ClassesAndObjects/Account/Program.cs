using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", 100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            
            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: "+bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: "+bartosSwissAccount.Balance());

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);
            Console.WriteLine();

            var matsAccount = new Account("Matt's account", 1000);
            var myAccount = new Account("My Account", 0);

            var money = matsAccount.Withdrawal(100);

            myAccount.Deposit(money);

            Console.WriteLine(myAccount);

            var aAccount = new Account("A Account", 100);
            var bAccount = new Account("B Account", 0);
            var cAccount = new Account("C Account", 0);

            Console.WriteLine("A account balance is: " + aAccount.Balance());
            Console.WriteLine("B account balance is: " + bAccount.Balance());
            Console.WriteLine("C account balance is: " + cAccount.Balance());

            Transfer(aAccount,bAccount,50);
            Transfer(bAccount,cAccount,25);

            Console.WriteLine("A account balance is now: " + aAccount.Balance());
            Console.WriteLine("B account balance is now: " + bAccount.Balance());
            Console.WriteLine("C account balance is now: " + cAccount.Balance());


            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            to.Deposit(from.Withdrawal(howMuch));
        }
    }
}
