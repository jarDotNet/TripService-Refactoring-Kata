using ContosoTrips.Exceptions;
using ContosoTrips.Users;
using System.Collections.Generic;

namespace ContosoTrips.Trips
{
    public class TripDAO
    {
        public static List<Trip> FindTripsByUser(User user)
        {
            throw new DependendClassCallDuringUnitTestException(
                        "TripDAO should not be invoked on an unit test.");
        }
    }
}
