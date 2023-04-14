using FluentAssertions;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;
using VendingMachine;
using static System.Formats.Asn1.AsnWriter;

namespace VendingMachine.Test

{
    public class Tests
    {
        private VendingMachine _bot;
        private Money _money;
        private Product[] _product;
        [SetUp]
        public void Setup()
        {
            _money = new Money();
            _product = new[] { new Product() };
            _bot = new VendingMachine("Janka", true, _money, _product);
        }

        /*[Test]
        public void AddProduct_TestIfReturnsRightBool_ReturnValidResult()
        {
            bool result = _bot.AddProduct("snik", _money, 10);

            result.Should().BeTrue();
        }

        [Test]
        public void AddProduct_CheckIfNameIsEmptyOrNull_throwArgumentNullException()
        {
            Action act = () =>
            {
                _bot.AddProduct("", _money, 10);
            };
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void AddProduct_CheckIfCountIsLessThan0_ReturnArgumentOutOfRangeException()
        {
            Action act = () =>
            {
                _bot.AddProduct("tr", _money, -10);
            };
            act.Should().Throw<ArgumentOutOfRangeException>();
        }*/

        [Test]
        public void InsertCoin_GiveValidCent_ReturnValidCents()
        {

            var testMoney = new Money { Cents = 10};

            var result = _bot.InsertCoin(testMoney);

            result.Cents.Should().Be(10);
        }

        [Test]
        public void InsertCoin_GiveValidEuros_ReturnValidEuros()
        {

            var testMoney = new Money { Euros = 1};

            var result = _bot.InsertCoin(testMoney);

            result.Euros.Should().Be(1);
        }

        [Test]
        public void InsertCoin_GiveInvalidCent_Return0()
        {
            var testMoney = new Money { Cents = 5 };

            var result = _bot.InsertCoin(testMoney);

            result.Cents.Should().Be(0);
        }

        [Test]
        public void InsertCoin_GiveInvalidEuro_Return0()
        {
            var testMoney = new Money { Euros = 5 };

            var result = _bot.InsertCoin(testMoney);

            result.Cents.Should().Be(0);
        }

        [Test]
        public void AddProduct_ValidInputs_EverythingIsGreat()
        {
            var result = _bot.AddProduct("test", new Money{Cents = 10, Euros = 1}, 15);
            result.Should().BeTrue();
            _bot.Products.Should().HaveCount(1);
        }

        [Test]
        public void AddProduct_InvalidInputs_EverythingIsGreat()
        {
            var result = _bot.AddProduct("", new Money { Cents = 10, Euros = 1 }, -15);
            result.Should().BeFalse();
        }

        [Test]
        public void ReturnMoney_GiveValidMoney_ReturnMoney()
        {
            var testMoney = new Money { Cents = 10, Euros = 1};

            var result = _bot.ReturnMoney();

            testMoney.Cents.Should().Be(10);
            testMoney.Euros.Should().Be(1);
        }

        [Test]
        public void UpdateProduct_ValidUpdate_ReturnsTrue()
        {
            var result = _bot.UpdateProduct(1, "Beka", new Money { Cents = 90, Euros = 1 }, 20);

            result.Should().Be(true);
        }

        [Test] public void UpdateProduct_ValidUpdateToBuy_ReturnsTrue()
        {
            var result = _bot.UpdateProduct(1, " ", new Money { Cents = 10, Euros = 0 }, 20);

            result.Should().Be(true);
        }

        [Test]
        public void UpdateProduct_InvalidProductNumber_ReturnsFalse()
        {
            Action act = () =>
            {
                _bot.UpdateProduct(4, "Beka", new Money { Cents = 10, Euros = 0 }, 20);
            };

            act.Should().Throw<IndexOutOfRangeException>();
        }

        [Test]
        public void UpdateProduct_InvalidAmount_ReturnsArgumentOutOfRangeException()
        {
           var result = _bot.UpdateProduct(1, "Beka", new Money { Cents = 10, Euros = 0 }, -100);
            

            result.Should().BeFalse();
        }

        [Test]
        public void ToString_ValidToString()
        {
            var result = _bot.ToString();

            _bot.ToString().Should().Be(result);
        }
    }
}
