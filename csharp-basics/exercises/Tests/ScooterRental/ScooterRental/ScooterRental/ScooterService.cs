using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterRental
{
    internal class ScooterService : IScooterService
    {
        private readonly List<Scooter>  _scooters;

        public ScooterService()
        {
            _scooters = new List<Scooter>();
        }
        public void AddScooter(string id, decimal pricePerMinute)
        {
            var scooters = new Scooter(id, pricePerMinute);
            _scooters.Add(scooters);
        }

        public void RemoveScooter(string id)
        {
            throw new NotImplementedException();
        }

        public IList<Scooter> GetScooters()
        {
            throw new NotImplementedException();
        }

        public Scooter GetScooterById(string scooterId)
        {
            throw new NotImplementedException();
        }
    }
}
