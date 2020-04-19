namespace TripServiceTests.Utils
{
    /// <summary>
    /// Factory design pattern
    /// </summary>
    public static class Builder
    {
        public static UserBuilder User => new UserBuilder();
    }
}
