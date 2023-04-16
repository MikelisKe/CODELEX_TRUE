using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental.Exceptions
{
    public class ScooterNotFoundException : Exception
    {
        public ScooterNotFoundException() : base("Scooter was not found")
        {

        }
    }
}
