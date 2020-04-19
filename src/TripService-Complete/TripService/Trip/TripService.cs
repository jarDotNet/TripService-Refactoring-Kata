using System;
using System.Collections.Generic;
using ContosoTrips.Exceptions;
using ContosoTrips.Users;
using ContosoTrips.Utils;

namespace ContosoTrips.Trips
{
    public class TripService
    {
        private readonly IUserSession userSession;
        private readonly ITripDAO tripDAO;

        public TripService() : 
            this(UserSession.GetInstance(), new TripDAO())
        {

        }

        public TripService(
            IUserSession userSession,
            ITripDAO tripDAO)
        {
            this.userSession = userSession ?? throw new ArgumentNullException(nameof(userSession));
            this.tripDAO = tripDAO ?? throw new ArgumentNullException(nameof(tripDAO));
        }

        public IEnumerable<Trip> GetTripsByUser(User user)
        {
            var loggedUser = userSession.GetLoggedUser();

            Ensure.NotNull<UserNotLoggedInException>(loggedUser, "User is not logged in");

            return user.IsFriendOf(loggedUser) 
                ? tripDAO.GetTripsBy(user)
                : NoTrips();
        }

        private IEnumerable<Trip> NoTrips()
        {
            return new List<Trip>();
        }

        protected virtual IEnumerable<Trip> GetTripsBy(User user)
        {
            return tripDAO.GetTripsBy(user);
        }

        protected virtual User GetLoggedInUser()
        {
            return userSession.GetLoggedUser();
        }
    }
}
