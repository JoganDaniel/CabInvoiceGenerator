using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary <string,List<Ride>> userRides = new Dictionary <string,List<Ride>>();
        public void AddRides(string userId, Ride[] rides)
        { 
            List<Ride> list = new List<Ride>();
            if(userRides.ContainsKey(userId))
            {
                list = userRides[userId];
                list.AddRange(rides);
                userRides[userId] = list;
            }
            else
            {
                list.AddRange(rides);
                userRides.Add(userId, list);
            }
        }
        public Ride[] GetRides(string userId)
        {
            return userRides[userId].ToArray();
        }
    }
}
