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
            if (FindFriend(name, dateTime))
                return;

            friends.Add(new Friend(name, dateTime));
        }

        internal void DeleteLastFriend()
        {
            friends.RemoveAt(friends.Count -1);
        }

        internal bool FindFriend(string name, DateTime bd)
        {
            for (int i = 0; i < friends.Count; i++)
            {
                if (friends[i].GetName() == name && friends[i].GetBirthDate() == bd)
                    return true;
            }

            return false;
        }

        internal void DeleteFriend(string name, DateTime bd)
        {
            for (int i = 0; i < friends.Count; i++)
            {
                if (friends[i].GetName() == name && friends[i].GetBirthDate() == bd)
                {
                    friends.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
