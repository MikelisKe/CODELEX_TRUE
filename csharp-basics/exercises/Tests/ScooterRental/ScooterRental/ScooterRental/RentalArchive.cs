using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRental.Interfaces;

namespace ScooterRental
{
    internal class RentalArchive:IRentalArchive
    {
        private List<RentedScooter> _rentedScooterList;

        public RentalArchive(List<RentedScooter> rentedScooterList)
        {
            _rentedScooterList = rentedScooterList;
        }
        public void AddRent(string id, decimal pricePerMinute, DateTime rentStart)
        {
            _rentedScooterList.Add(new RentedScooter(id,rentStart,pricePerMinute));
        }
    }
}
