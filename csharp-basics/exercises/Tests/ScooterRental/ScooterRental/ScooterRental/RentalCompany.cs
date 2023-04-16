using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterRental.Interfaces;

namespace ScooterRental
{
    public class RentalCompany: IRentalCompany
    {
        public string Name { get; }
        IScooterService ScooterService { get; set; }
        

        public RentalCompany(string name, IScooterService scooter)
        {
            Name = name;
            ScooterService = scooter;
        }
        public void StartRent(string id)
        {
            //select scooter by id 
            //create list?? where scooters ar in use
            //create dateTime starttpoint??
            ScooterService.GetScooterById(id).IsRented = true;

        }

        public decimal EndRent(string id)
        {
            ScooterService.GetScooterById(id).IsRented = false;
            return 0;
        }

        public decimal CalculateIncome(int? year, bool includeNotCompletedRentals)
        {
            throw new NotImplementedException();
        }
    }
}
