using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BirthdayNotifyer
{
    class NotebookTests
    {
        [Test]
        public void AddFriendIncreaseCount([Values(0, 1, 2, 3, 10, 15, 20)] int friendsCount)
        {
            Notebook notebook = new Notebook();

            for (int i = 0; i < friendsCount; i++)
                notebook.AddFriend("ФИО" + i.ToString(), new DateTime());

            Assert.AreEqual(friendsCount, notebook.GetFriendsCount());
        }

        [Test]
        public void AddSameFriendDoNotRepeat()
        {
            Notebook notebook = new Notebook();
            string name = "друг 1";
            DateTime dt = new DateTime(2000, 6, 13);

            notebook.AddFriend(name, dt);
            notebook.AddFriend(name, dt);

            Assert.AreEqual(1, notebook.GetFriendsCount());
        }

        [Test]
        public void AddSameFriendReturnFalse()
        {
            Notebook notebook = new Notebook();
            string name = "друг 1";
            DateTime dt = new DateTime(2000, 6, 13);
            bool isAdded;

            notebook.AddFriend(name, dt);
            isAdded = notebook.AddFriend(name, dt);

            Assert.AreEqual(false, isAdded);
        }

        [Test]
        public void FindFriendCorrect()
        {
            Notebook notebook = new Notebook();
            DateTime dt = new DateTime(2000, 6, 13);
            string name = "друг 1";

            notebook.AddFriend(name, dt);

            Assert.AreEqual(true, notebook.FindFriend(name, dt));
        }

        [Test]
        public void FindFriendIncorrectName()
        {
            Notebook notebook = new Notebook();
            DateTime dt = new DateTime(2000, 6, 13);
            string name = "друг 1";
            string name2 = "друг 2";

            notebook.AddFriend(name, dt);

            Assert.AreEqual(false, notebook.FindFriend(name2, dt));
        }

        [Test]
        public void FindFriendIncorrectBirthdate()
        {
            Notebook notebook = new Notebook();
            DateTime dt = new DateTime(2000, 6, 13);
            DateTime dt2 = new DateTime(2001, 6, 13);
            string name = "друг 1";

            notebook.AddFriend(name, dt);

            Assert.AreEqual(false, notebook.FindFriend(name, dt2));
        }

        [Test]
        public void DeleteLastFriendDecreaseCount([Values(5, 10)] int friendsCount, [Values(1, 2, 3, 5)] int deleteCount)
        {
            Notebook notebook = new Notebook();

            for (int i = 0; i < friendsCount; i++)
                notebook.AddFriend("ФИО" + i.ToString(), new DateTime());

            for (int i = 0; i < deleteCount; i++)
                notebook.DeleteLastFriend();

            Assert.AreEqual(friendsCount - deleteCount, notebook.GetFriendsCount());
        }

        [Test]
        public void DeleteFriendByNameAndBirthdateDecreaseCount()
        {
            Notebook notebook = new Notebook();
            DateTime dt1 = new DateTime(2000, 6, 13);
            DateTime dt2 = new DateTime(2001, 6, 13);
            string name1 = "друг 1";
            string name2 = "друг 2";

            notebook.AddFriend(name1, dt1);
            notebook.AddFriend(name2, dt2);

            notebook.DeleteFriend(name1, dt1);

            Assert.AreEqual(1, notebook.GetFriendsCount());
        }

        [Test]
        public void DeleteFriendByNameAndBirthdateRemoveCorrectFriend()
        {
            Notebook notebook = new Notebook();
            DateTime dt1 = new DateTime(2000, 6, 13);
            DateTime dt2 = new DateTime(2001, 6, 13);
            string name1 = "друг 1";
            string name2 = "друг 2";

            notebook.AddFriend(name1, dt1);
            notebook.AddFriend(name1, dt2);
            notebook.AddFriend(name2, dt1);
            notebook.AddFriend(name2, dt2);

            notebook.DeleteFriend(name1, dt2);

            Assert.AreEqual(false, notebook.FindFriend(name1, dt2));
        }
    }
}
