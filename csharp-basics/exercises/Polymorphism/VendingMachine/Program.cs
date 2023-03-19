using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money maks = new Money();

            void input()
            {

            }
            VendingMachine street = new VendingMachine();
            street.AddProduct("Snikels",price:maks, 15);
            street.InsertCoin(maks);


        }
    }
}