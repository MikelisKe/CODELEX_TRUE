using System;
using System.Collections.Generic;
using System.Text;

namespace Persons
{
    public class CatTests
    {
        private Cat _cat;

        public void Setup()
        {
            _cat = new Cat("name", 1.4, 0, "purchix", "Staltais");
        }

        [Test]
        public void Test()
        {

        }


    }
}
