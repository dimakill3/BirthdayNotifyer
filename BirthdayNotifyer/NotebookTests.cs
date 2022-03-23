using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayNotifyer
{
    class NotebookTests
    {
        [Test]
        public void AddFriendToListIncreaseCount([Values(0, 1, 2, 3, 10, 15, 20)] int friendsCount)
        {
            Notebook notebook = new Notebook();

            for (int i = 0; i < friendsCount; i++)
                notebook.AddFriend("ФИО", new DateTime());

            Assert.AreEqual(friendsCount, notebook.GetFriendsCount());
        }
    }
}
