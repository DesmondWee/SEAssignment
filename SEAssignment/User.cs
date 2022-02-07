using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class User
    {
        public string name { get; set; }
        public int contactNumber { get; set; }
        public string emailAddress { get; set; }
        public int identificationNumber { get; set; }

        public static int NextIdentificationNumber = 1;

        public User() { }
        public User(string _name, int _contactNumber, string _emailAddress)
        {
            name = _name;
            contactNumber = _contactNumber;
            emailAddress = _emailAddress;
            identificationNumber = NextIdentificationNumber;
            NextIdentificationNumber = NextIdentificationNumber + 1;
        }
    }


}
