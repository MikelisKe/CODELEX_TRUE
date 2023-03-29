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

        [SetUp]
        public void Setup()
        {
            _zebra = new Zebra("Ne Zirgs", 95.5, 0, "mezhparks");
            _vegetable = new Vegetable(3);
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

    }
}
