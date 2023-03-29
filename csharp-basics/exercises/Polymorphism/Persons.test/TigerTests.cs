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

        [SetUp]
        public void Setup()
        {
            _tiger = new Tiger("Tigrrr", 45.8, 0, "Zepcix", "Zepa iela");
            _food = new Meat(3);
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

    }
}
