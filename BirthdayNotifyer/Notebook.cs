using System;
using System.Collections.Generic;

namespace BirthdayNotifyer
{
    class Notebook
    {
        private List<Friend> friends;

        public Notebook()
        {
            friends = new List<Friend>();
        }

        internal object GetFriendsCount()
        {
            return friends.Count;
        }

        internal void AddFriend(string name, DateTime dateTime)
        {
            friends.Add(new Friend());
        }
    }
}
