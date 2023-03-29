using System;
using System.Collections.Generic;
using System.Text;
using Persons;
using FluentAssertions;


namespace Persons
{
    public class CatTests
    {
        private Cat _cat;
        private Food _food;

        [SetUp]
        public void Setup()
        {
            _cat = new Cat("name", 1.4, 0, "purchix", "Staltais");
            _food = new Food(3);
        }

        [Test]
        public void Eat_FoodIsAddedToFoodEaten()
        {
            _cat.Eat(_food, 3);

            _cat._foodEaten.Should().Be(3);
        }

        [Test]
        public void Eat_FoodIsValidParameter()
        {
            Action act = () =>
            {
                _cat.Eat(null , 3);
            };
            act.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void MakeSound_DoesMakeSoundInString()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            _cat.MakeSound();

            string expectedOutput = "Meaw..\r\n" ;
            sw.ToString().Should().Be(expectedOutput);
            //Assert.AreEqual(expectedOutput, sw.ToString());
        }
    }
}
