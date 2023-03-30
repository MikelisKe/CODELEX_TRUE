using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.test
{
    internal class ZebraTests
    {
        private Zebra _zebra;
        private Vegetable _vegetable;
        private Meat _meat;

        [SetUp]
        public void Setup()
        {
            _zebra = new Zebra("Ne Zirgs", 95.5, 0, "mezhparks");
            _vegetable = new Vegetable(3);
            _meat = new Meat(1);
        }
        [Test]
        public void MakeSound_DoesMakeSoundInString()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            _zebra.MakeSound();

            string expectedOutput = "Es neesmu zirgs!\r\n";
            sw.ToString().Should().Be(expectedOutput);
        }

        [Test]
        public void Eat_FoodIsAddedToFoodEaten()
        {
            _zebra.Eat(_vegetable, 3);

            _zebra._foodEaten.Should().Be(3);
        }
        [Test]
        public void Eat_FoodIsValidParameter()
        {
            Action act = () =>
            {
                _zebra.Eat(null, 3);
            };
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Eat_FoodIsMeatParemeter()
        {
            Action act = () =>
            {
                _zebra.Eat(_meat, 1);
            };
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Eat_CountIsNullOrEmpty()
        {
            Action act = () =>
            {
                _zebra.Eat(_vegetable, -14);
            };
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void ToString_ValidOutputAsResult()
        {
            var result = _zebra.ToString();

            _zebra.ToString().Should().Be(result);
        }

    }
}
