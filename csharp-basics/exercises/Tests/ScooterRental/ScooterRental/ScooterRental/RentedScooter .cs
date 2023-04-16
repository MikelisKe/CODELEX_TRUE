using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    internal class RentedScooter
    {
        public string Id { get; }
        public DateTime StartRent { get; }
        public DateTime? EndRent { get; set; }
        public decimal RentPrice { get; }

        public RentedScooter(string id, DateTime startRent, decimal rentPrice)
        {
            Id = id;
            StartRent = startRent;
            RentPrice  = rentPrice;
        }

    }
}
