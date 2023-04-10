using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public List<Money> _validCoins;
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
        public bool HasProducts { get => _products.Any(); }
        public Money Amount { get; }
        public Product[] Products { get; set; }

        public VendingMachine(string manufacturer, bool hasProducts, Money amount, Product[] products)
        {
            Manufacturer = manufacturer;
            Amount = amount;
            Products = products;
        }

        private Product[] _products = new Product[2];

        public Money _kase = new Money();
        private int _intKase = 0;

        public Money InsertCoin(Money amount)
        {
            if (_validCoins.Contains(amount))
            {
                _kase.Cents += amount.Cents;
                _kase.Euros += amount.Euros;
                _intKase += amount.Cents + (amount.Euros * 100);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
                return _kase;
            }

            return _kase;
        }



        public Money ReturnMoney()
        {
            return _kase;
        }

        int indexOfNumber = 0;
        public bool AddProduct(string name, Money price, int count)
        {

            if (String.IsNullOrWhiteSpace(name) || count < 0)
            {
                throw new ArgumentOutOfRangeException();
                return false;
            }
            

            var product = new Product { Name = name, Price = price, Available = count };
            _products[indexOfNumber] = product;
            indexOfNumber++;

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 && productNumber > 4)
            {
                throw new ArgumentOutOfRangeException();
                return false;
            }

            var product = _products[productNumber];
            if (name == null && !price.HasValue )   //notiek pirkšana
            {
                var nauda = (product.Price.Euros * 100 + product.Price.Cents);
                _intKase -= nauda; //  1.5



                _kase.Euros = (int)(_intKase/100);
                _kase.Cents = (int)(_intKase % 100);
                return true;
            }
           

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }
            else
            {
                product.Name = name;
            }

            if (price.HasValue)
            {
                product.Price = price.Value;
            }

            if (amount >= 0)
            {
                product.Available = amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

            
            
            

            return true;

        }

        public override string ToString()
        {
            return $"Izdotā nauda ir {_kase.Euros},{_kase.Cents} eiro";
        }
    }
}