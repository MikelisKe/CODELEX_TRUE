using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.test
{
    public class TigerTests
    {
        private Tiger _tiger;
        private  Food _food;
        private Vegetable _vegetable;

        [SetUp]
        public void Setup()
        {
            _tiger = new Tiger("Tigrrr", 45.8, 0, "Zepcix", "Zepa iela");
            _food = new Meat(3);
            _vegetable = new Vegetable(1);
        }
        [Test]
        public void MakeSound_DoesMakeSoundInString()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            _tiger.MakeSound();

            string expectedOutput = "Rawr\r\n";
            sw.ToString().Should().Be(expectedOutput);
        }

        [Test]
        public void Eat_FoodIsAddedToFoodEaten()
        {
            _tiger.Eat(_food, 3);

            _tiger._foodEaten.Should().Be(3);
        }

        [Test]
        public void Eat_FoodIsMeatParemeter()
        {
            Action act = () =>
            {
                _tiger.Eat(_vegetable, 1);
            };
            act.Should().Throw<ArgumentException>();
        }



        [Test]
        public void ToString_ValidOutputAsResult()
        {
            var result = _tiger.ToString();

            _tiger.ToString().Should().Be(result);
        }

    }
}
