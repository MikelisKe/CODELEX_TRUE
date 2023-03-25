using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private string _accountName;
        private double _balance { get; set; }

        public BankAccount(string accountName, double balance)
        {
            _balance = balance;
            _accountName = accountName; 
        }

        public string ShowUserNameAndBalance()
        {
            if (_balance > 0)
            {
                return $"{_accountName}, ${_balance:F2} ";
            }
            else
            {
                return $"{_accountName}, -${-_balance:F2} ";
            }
            
        }
        static void Main(string[] args)
        {
            BankAccount test = new BankAccount("Andris", -12.43);
            BankAccount test1 = new BankAccount("Boby", 123.4);
            
            Console.WriteLine(test.ShowUserNameAndBalance());
            Console.WriteLine(test1.ShowUserNameAndBalance());
            Console.ReadKey();
        }
    }
}
