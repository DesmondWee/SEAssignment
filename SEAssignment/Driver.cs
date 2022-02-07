using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Driver : User
    {
        public int amount { get; set; }
        public Bank bank { get; set; }
        public Vehicle vehicle { get; set; }

        //Implementation
        public void TransferToBank(int amount) { }

        public Driver(string name, int contactNumber, string emailAddress, int identificationNumber) : base(name, contactNumber, emailAddress, identificationNumber)
        {

        }
    }
}
