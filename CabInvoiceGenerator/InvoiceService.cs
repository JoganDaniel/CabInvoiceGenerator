namespace CabInvoiceGenerator
{
    public class InvoiceService
    {
        private const int COST_PER_KM = 10;
        private const int MIN_FARE = 5;
        private  const int COST_PER_MIN = 1;
        public int totalNumberOfRides = 0;
        public double totalFare = 0;
        public double averageFare = 0;

        public int TotalNumberOfRides()
        {
            return totalNumberOfRides;
        }
        public double TotalFare()
        {
            return totalFare;
        }
        public double AverageFare()
        {
            return averageFare;
        }
        public int NumberOfRides
        {
            get
            {
                return this.NumberOfRides;
            }
        }
        public double CalculateFare(double distance, double time)
        {
            double TotalAmount = distance * COST_PER_KM + time * COST_PER_MIN;
            if (TotalAmount > MIN_FARE)
            {
                return TotalAmount;
            }
            return MIN_FARE;
        }
        public double CalculateFare(Ride[] rides)
        {
            foreach (Ride ride in rides)
            {
                totalFare += ride.distance * COST_PER_KM + ride.time * COST_PER_MIN;
            }
            totalNumberOfRides = rides.Length;
            averageFare = totalFare/ totalNumberOfRides;
            return averageFare;
        }
    }
}