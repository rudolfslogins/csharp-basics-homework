using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount benben = new BankAccount("Benson", (decimal)17.25);
            Console.WriteLine(benben.ShowUserNameAndBalance());

            BankAccount penpen = new BankAccount("Peter", (decimal)15000.5);
            Console.WriteLine(penpen.ShowUserNameAndBalance());

            BankAccount zenzen = new BankAccount("Zinedin", (decimal)-11.9);
            Console.WriteLine(zenzen.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}
