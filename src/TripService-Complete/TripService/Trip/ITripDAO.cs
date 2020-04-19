using ContosoTrips.Users;
using System.Collections.Generic;

namespace ContosoTrips.Trips
{
    public interface ITripDAO
    {
        IEnumerable<Trip> GetTripsBy(User user);
    }
}