using System;

namespace VeryFirstNamespace
{
    public class Person
    {
        private DateTime _birthdate;
        
        public void SetBirthdate(DateTime birthdate)
        {
            // LOGIC
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

    }
}