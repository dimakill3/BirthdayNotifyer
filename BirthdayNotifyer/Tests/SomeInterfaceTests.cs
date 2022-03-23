using NUnit.Framework;

namespace BirthdayNotifyer
{
    public class SomeInterfaceTests
    {
        [Test]
        public void LastDigitIsOneExept_11_InDayTextChange([Values(1, 21, 31)] int inputNum)
        {
            string dayText = NotifyerForm.ChangeDayText(inputNum);

            Assert.AreEqual("день", dayText);
        }

        [Test]
        public void LastDigitsFromTwoToFourExept_12_13_14_InDayTextChange([Values(2, 3, 4, 22, 23, 24)] int inputNum)
        {
            string dayText = NotifyerForm.ChangeDayText(inputNum);

            Assert.AreEqual("дня", dayText);
        }

        [Test]
        public void AnotherNumbersInDayTextChange([Values(5, 6, 7, 8, 9, 10, 11, 12, 13, 14)] int inputNum)
        {
            string dayText = NotifyerForm.ChangeDayText(inputNum);

            Assert.AreEqual("дней", dayText);
        }
    }
}
