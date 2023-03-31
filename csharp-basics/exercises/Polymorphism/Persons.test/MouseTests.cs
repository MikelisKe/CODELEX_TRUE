using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.test
{
    public class MouseTests
    {
        private Mouse _mouse;
        private Vegetable _vegetable;
        private Meat _meat;

        [SetUp]
        public void Setup()
        {
            _mouse = new Mouse("Pelis", 1.0, 0, "Malta");
            _vegetable = new Vegetable(3);
            _meat = new Meat(3);
        }

        [Test]
        public void MakeSound_DoesMakeSoundInString()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            _mouse.MakeSound();

            string expectedOutput = "Piik.. Piik.\r\n";
            sw.ToString().Should().Be(expectedOutput);
        }
        [Test]
        public void Eat_FoodIsAddedToFoodEaten()
        {
            _mouse.Eat(_vegetable, 3);

            _mouse._foodEaten.Should().Be(3);
        }
        [Test]
        public void Eat_FoodIsValidParameter()
        {
            Action act = () =>
            {
                _mouse.Eat(null, 3);
            };
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Eat_FoodIsMeatParemeter()
        {
            Action act = () =>
            {
                _mouse.Eat(_meat, 3);
            };
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void Eat_CountIsNullOrEmpty()
        {
            Action act = () =>
            {
                _mouse.Eat(_vegetable, -14);
            };
            act.Should().Throw<ArgumentOutOfRangeException>();
        }

        [Test]
        public void ToString_ValidOutputAsResult()
        {
            var result = _mouse.ToString();

            _mouse.ToString().Should().Be(result);
        }
    }
}
        
