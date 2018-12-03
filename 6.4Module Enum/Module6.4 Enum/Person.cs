using System;
using System.Collections.Generic;
using System.Text;

namespace Module6._4_Enum
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthday { get; set; }
        public PersonSport Sport { get; set; }
        public PersonGender Gender { get; set; }

        public enum PersonGender
        {
            Female, Male, Other
        }
        public enum PersonSport
        {
            Tennis, Rugby, Soccer, Hurling, Squash
        }



    }
}
