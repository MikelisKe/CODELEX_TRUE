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
            /*Account bartosAccount = new Account("Barto's account", 100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);
            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);
            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance());
            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);*/

            string FirstAccount()
            {
                Account first = new Account("first",100.0);
                first.Withdrawal(20);
                return first.ToString();
            }

            string MoneyTransfer()
            {
                Account matt = new Account("Matt's account", 1000);
                Account my = new Account("My account", 0);
                var deal = 100;
                matt.Withdrawal(deal);
                my.Deposit(deal);
                return $"{matt.ToString()} \n{my.ToString()}";
            }


            Console.WriteLine(FirstAccount());
            Console.WriteLine(MoneyTransfer());
            Console.ReadKey();
        }
    }
}
