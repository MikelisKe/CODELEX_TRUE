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
        private Food _food;

        [SetUp]
        public void Setup()
        {
            _mouse = new Mouse("Pelis", 1.0, 0, "Malta");
            _food = new Food(3);
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
    }
}
        
