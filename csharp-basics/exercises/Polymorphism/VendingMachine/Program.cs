using System;

namespace VendingMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine street = new VendingMachine();
            street.InsertCoin(new Money { Cents = 50 });
            street.InsertCoin(new Money { Euros = 1 });

            street.AddProduct("Snikers", new Money { Cents = 10, Euros = 1 }, 10);
            street.AddProduct("Beka", new Money { Cents = 80, Euros = 0 }, 10);

            street.UpdateProduct(0, null,null, 9);
            street.ReturnMoney();

            Console.WriteLine(street.ToString());

        }
    }
}
