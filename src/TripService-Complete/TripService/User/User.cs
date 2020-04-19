﻿using ContosoTrips.Trips;
using System;
using System.Collections.Generic;

namespace ContosoTrips.Users
{
    [Serializable]
    public class User
    {
        private List<Trip> trips = new List<Trip>();
        private List<User> friends = new List<User>();

        public IEnumerable<User> GetFriends()
        {
            return friends;
        } 

        public void AddFriend(User user)
        {
            friends.Add(user);
        }

        public void AddTrip(Trip trip)
        {
            trips.Add(trip);
        }

        public bool IsFriendOf(User user)
        {
            return friends.Contains(user);
        }

        public IEnumerable<Trip> Trips()
        {
            return trips;
        } 
    }
}
