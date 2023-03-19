using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class VendingMachine: IVendingMachine
    //Es salabošu šo visu, bet ne šodien vairs. :(
    {
        private List<Money> _validCoins;

        public VendingMachine()
        {
            _validCoins = new List<Money>
            {
                new Money {Cents = 10},
                new Money {Cents = 20},
                new Money {Cents = 50},
                new Money {Euros = 1},
                new Money {Euros = 2}
            };
        }
        public string Manufacturer { get; }
        public bool HasProducts { get; }
        public Money Amount { get; }
        public Product[] Products { get; }

        private new Money Maks;
        public VendingMachine(string manufacturer, bool hasProducts, Money amount, Product product)
        {
            Manufacturer = manufacturer;
            HasProducts = hasProducts;
            Amount = amount;
        }
        public Money InsertCoin(Money amount)
        {
            var euros = 0;
            var cents = 0;
            if (_validCoins.Contains(amount))
            {
                cents += amount.Cents;
                euros += amount.Euros;
            }
            else
            {
                Console.WriteLine("insufficient funds");
            }

            Maks.Cents = cents;
            Maks.Euros = euros;

            return Maks;
        }

        public Money ReturnMoney()
        {
            var u = Maks.Cents - Amount.Cents;
            var t = Maks.Euros - Amount.Euros;
            var result = new Money();
            result.Cents = u;
            result.Euros = t;
            return result;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            
            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            return false;
        }

        public override string ToString()
        {
            return $"{Products},{Amount}";
        }
    }
}