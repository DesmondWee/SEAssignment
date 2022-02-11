using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class Customer : User
    {
        public int points { get; set; }

        public interface RedeemPoints
        {
            void Redeem(int points);
        }
        public Customer() { }

        public Customer(string _name, int _contactNumber, string _emailAddress) : base(_name, _contactNumber, _emailAddress)
        {

        }
    }
}
