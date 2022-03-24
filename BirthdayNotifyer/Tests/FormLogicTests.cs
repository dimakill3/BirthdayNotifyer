using NUnit.Framework;

namespace BirthdayNotifyer.Tests
{
    class FormLogicTests
    {
        [Test]
        public void GenerateNFriend([Values(5, 20, 100, 500, 1000)] int friendCount)
        {
            NotifyerForm testForm = new NotifyerForm();
            
            testForm.GenerateFriends(friendCount);

            Assert.AreEqual(friendCount, testForm.MyNotebook.GetFriendsCount());
        }
    }
}
