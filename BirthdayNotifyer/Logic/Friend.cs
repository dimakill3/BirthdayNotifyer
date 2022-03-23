using System;

namespace BirthdayNotifyer
{
    class Friend
    {
        private string name;
        private DateTime birthDate;

        public Friend() 
        {
            
        }

        public Friend(string name, DateTime dt)
        {
            this.name = name;
            this.birthDate = dt;
        }

        public string GetName()
        {
            return name;
        }

        public DateTime GetBirthDate()
        {
            return birthDate;
        }
    }
}
