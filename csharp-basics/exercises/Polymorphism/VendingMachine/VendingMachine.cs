﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private List<Money> _validCoins;
       
        public string Manufacturer { get; }
        public bool HasProducts { get => _products.Any(); }
        public Money Amount { get; }
        public Product[] Products { get; set; }
        private Money _kase = new Money();

        public VendingMachine(string manufacturer, bool hasProducts, Money amount, Product[] products)
        {
            Manufacturer = manufacturer;
            Amount = amount;
            Products = products;
            _validCoins = new List<Money>
            {
                new Money {Cents = 10},
                new Money {Cents = 20},
                new Money {Cents = 50},
                new Money {Euros = 1},
                new Money {Euros = 2}
            };
        }

        private Product[] _products = new Product[2];
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
                return false;
            }
            

            var product = new Product { Name = name, Price = price, Available = count };
            _products[indexOfNumber] = product;
            indexOfNumber++;

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 || productNumber > 3)
            {
                return false;
            }

            var product = _products[productNumber];
            if (name == null && !price.HasValue )
            {
                var nauda = (product.Price.Euros * 100 + product.Price.Cents);
                _intKase -= nauda;

                _kase.Euros = (int)(_intKase/100);
                _kase.Cents = (int)(_intKase % 100);
                return true; 
            }
           

            if (string.IsNullOrEmpty(name))
            {
                return false;
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
                return false;
            }

            return true;

        }

        public override string ToString()
        {
            return $"Izdotā nauda ir {_kase.Euros},{_kase.Cents} eiro! {Manufacturer}, {HasProducts}, {Amount} ";
        }
    }
}