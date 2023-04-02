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
            Console.WriteLine(FirstAccount());
            Console.WriteLine(MoneyTransfer());
            Console.ReadKey();
        }

        public static void Transfer(Account from, Account to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
        
        public static string MoneyTransfer()
        {
            Account matt = new Account("Matt's account", 1000);
            Account my = new Account("My account", 0);

            Transfer(matt, my, 100);

            return $"{matt.ToString()} \n{my.ToString()}";
        }

        public static string FirstAccount()
        {
            Account first = new Account("first", 100.0);
            first.Withdrawal(20);
            return first.ToString();
        }
    }
}
