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


    }
}
