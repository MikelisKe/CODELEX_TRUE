using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Firm
{
    public class Commision :Hourly
    {
        private int _totalSales { get; set; }
        private double _commissionRate { get; set; }
        public Commision(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _totalSales = 0;
            _commissionRate = commissionRate;
        }

        public void AddTotalSales(int totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var payment = (payRate * _hoursWorked) + (_commissionRate*_totalSales);
            _hoursWorked = 0;
            return payment;
        }
        
    }
}