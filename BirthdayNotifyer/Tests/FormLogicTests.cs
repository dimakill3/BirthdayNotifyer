using NUnit.Framework;
using System;

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

        [Test]
        public void DateToPast([Values(5, 10, 15, 22, 33)] int yearsAgo)
        {
            DateTime birthDate = FriendsGenerator.GetRandomBirthdate(100);
            DateTime todayDate = birthDate.AddYears(yearsAgo);

            DateTime todayDateInPast = NotifyerForm.DateToPast(birthDate, todayDate);

            Assert.AreEqual(todayDateInPast, birthDate);
        }

        [Test]
        public void DateCompare([Values(5, 10, 15, 22, 33)] int daysForBirthday)
        {
            DateTime birthDate = FriendsGenerator.GetRandomBirthdate(100);
            DateTime todayDate = birthDate.AddDays(-daysForBirthday);

            Assert.AreEqual(daysForBirthday, NotifyerForm.CompareDates(birthDate, todayDate));
        }
    }
}
