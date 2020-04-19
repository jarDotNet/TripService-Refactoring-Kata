using ContosoTrips.Users;
using FluentAssertions;
using TripServiceTests.Utils;
using Xunit;

namespace ContosoTrips.Tests
{
    public class user_should
    {
        private User BOB = new User();
        private User ALICE = new User();

        [Fact]
        public void inform_when_user_is_not_friend()
        {
            var user = Builder.User
                .WithFriends(BOB)
                .Build();

            user.IsFriendOf(ALICE).Should().BeFalse();
        }

        [Fact]
        public void inform_when_user_is_friend()
        {
            var user = Builder.User
                .WithFriends(BOB, ALICE)
                .Build();

            user.IsFriendOf(ALICE).Should().BeTrue();
        }
    }
}
