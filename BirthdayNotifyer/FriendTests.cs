using NUnit.Framework;
using System;

namespace BirthdayNotifyer
{
    class FriendTests
    {
        [Test]
        public void CreateFriendNameEqual()
        {
            string name = "друг 1";
            DateTime dt = new DateTime();
            Friend friend = new Friend(name, dt);

            Assert.AreEqual(name, friend.GetName());
        }

        [Test]
        public void CreateFriendDateEqual()
        {
            string name = "друг 1";
            DateTime dt = new DateTime(2000, 6, 13);
            Friend friend = new Friend(name, dt);

            Assert.AreEqual(dt, friend.GetBirthDate());
        }
    }
}
