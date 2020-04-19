using System;

namespace ContosoTrips.Exceptions
{
    [Serializable]
    public class UserNotLoggedInException : Exception
    {
        public UserNotLoggedInException(string message) : base(message)
        {

        }
    }
}
