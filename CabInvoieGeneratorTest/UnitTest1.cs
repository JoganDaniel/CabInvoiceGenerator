using CabInvoiceGenerator;

namespace CabInvoieGeneratorTest
{
    public class Tests
    {
        InvoiceService invoiceservice = new InvoiceService();
        [Test]
        public void GivenDistanceAndTimeWhenCheckedReturnFareValue()
        {
            
            double actual = invoiceservice.CalculateFare(10, 5);
            double expected = 105;
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void GivenRides_WhenChecked_ReturnFare()
        {
            Ride[] ride = { new Ride()
            {
                distance = 10,time = 5
            }
            };
            double actual = invoiceservice.CalculateFare(ride);
            double expected = 105;
            Assert.AreEqual(actual, expected);

        }
        [Test]
        public void GivenRides_WhenChecked_ReturnTotalRides()
        {
            Ride[] ride = { new Ride()
            {
                distance = 10,time = 5
            }
            };
            invoiceservice.CalculateFare(ride);
            double actual = invoiceservice.totalNumberOfRides;
            double expected = ride.Length;
            Assert.AreEqual(actual, expected);

        }
    }
}