using FluentAssertions;
using VendingMachine;
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

        [Test]
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
        }

        [Test]
        public void InsertCoin_GiveValidCent_ReturnValid()
        {
            var test = new Money { Cents = 50, Euros = 1};

            var result = _bot.InsertCoin(test);

            result.Cents.Should().Be(50);
            result.Euros.Should().Be(1);
            
        }


        /*[Test]
        public void InsertCoin_ifResultIsValid_Return()
        {
            var money = new Money();
            money.Cents = 10;
            money.Euros = 1;

            var result = _bot.InsertCoin(money);

            result.Should().Be(money);*/

    }
}
