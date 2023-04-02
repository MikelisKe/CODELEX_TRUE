using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money maks = new Money();
            maks.Cents = 10;
            maks.Euros = 1;
            Money price = new Money();
            price.Cents = 20;
            price.Euros = 0;



            VendingMachine street = new VendingMachine();
            street.AddProduct("Snikels", price: price, 15);
            street.InsertCoin(maks);


        }
    }
}
