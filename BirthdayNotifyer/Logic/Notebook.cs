using System;
using System.Collections.Generic;

namespace BirthdayNotifyer
{
    public class Notebook
    {
        private List<Friend> friends;
        
        public List<Friend> Friends
        {
            get 
            { 
                return friends;
            }

            private set { 
                friends = value;
            }
        }

        public Notebook()
        {
            friends = new List<Friend>();
        }

        internal int GetFriendsCount()
        {
            return friends.Count;
        }

        internal bool AddFriend(string name, DateTime dateTime)
        {
            if (FindFriend(name, dateTime))
                return false;

            friends.Add(new Friend(name, dateTime));
            return true;
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
