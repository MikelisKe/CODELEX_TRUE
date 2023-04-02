using FluentAssertions;
using VendingMachine;
namespace VendingMachine.Test

{
    public class Tests
    {
        private VendingMachine _bot;
        private Money _money;
        private Product _product;
        [SetUp]
        public void Setup()
        {
            _bot = new VendingMachine("Janka",true, _money, _product );
            _money = new Money();
            _product = new Product();
        }

        [Test]
        public void AddProduct_TestIfReturnsRightBool()
        {
            bool result = _bot.AddProduct("snik", _money, 10);

            result.Should().BeTrue();
        }

        [Test]
        public void InsertCoin_ifResultIsValid()
        {
            _money.Cents = 10;
            _money.Euros = 1;
            var result = _bot.InsertCoin(_money);
            //result.Should().NotBeNull();
            result.Euros.Should().Be(1);
            result.Cents.Should().Be(10);
        }
    }
}