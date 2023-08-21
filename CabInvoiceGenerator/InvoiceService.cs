﻿namespace CabInvoiceGenerator
{
    public class InvoiceService
    {
        private readonly int costPerKilometerNormal = 10;
        private readonly int minimumFareNormal = 5;
        private readonly int costPerMinuteNormal = 1;

        public int NumberOfRides
        {
            get
            {
                return this.NumberOfRides;
            }
        }
        public double CalculateFare(double distance, double time)
        {
            double TotalAmount = distance * costPerKilometerNormal + time * costPerMinuteNormal;
            if (TotalAmount > minimumFareNormal)
            {
                return TotalAmount;
            }
            return minimumFareNormal;
        }
        public double CalculateFareForRide(Ride ride)
        {
            double TotalAmount = ride.distance * costPerKilometerNormal + ride.time * costPerMinuteNormal;
            if (TotalAmount > minimumFareNormal)
            {
                return TotalAmount;
            }
            return minimumFareNormal;
        }
    }
}