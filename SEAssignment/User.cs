﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class User
    {
        public string name { get; set; }
        public int contactNumber { get; set; }
        public string emailAddress { get; set; }
        public int identificationNumber { get; set; }

        public User(string _name, int _contactNumber, string _emailAddress, int _identificationNumber)
        {
            name = _name;
            contactNumber = _contactNumber;
            emailAddress = _emailAddress;
            identificationNumber = _identificationNumber;
        }
    }


}
