using System;

namespace ContosoTrips.Exceptions
{
    [Serializable]
    public class DependendClassCallDuringUnitTestException : Exception
    {
        public DependendClassCallDuringUnitTestException() : base() { }

        public DependendClassCallDuringUnitTestException(string message) : base(message) { }
    }
}
