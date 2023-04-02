using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    public class invalidPricePerMinuteException:Exception
    {
        public invalidPricePerMinuteException(): base("Invalid price per minute")
        {
            
        }
    }
}
