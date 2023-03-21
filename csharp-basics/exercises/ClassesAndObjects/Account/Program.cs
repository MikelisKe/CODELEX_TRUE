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
            string FirstAccount()
            {
                Account first = new Account("first",100.0);
                first.Withdrawal(20);
                return first.ToString();
            }

            Console.WriteLine(FirstAccount());

            string MoneyTransfer()
            {
                Account matt = new Account("Matt's account", 1000);
                Account my = new Account("My account", 0);

                matt.Withdrawal(100);
                my.Deposit(100);
                return $"{matt.ToString()} \n{my.ToString()}";
            }

            Console.WriteLine(FirstAccount());
            Console.WriteLine(MoneyTransfer());
            Console.ReadKey();
        }
    }
}
