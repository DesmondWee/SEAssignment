using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Booking
    {
        public int referenceNumber { get; set; }
        public Customer customer { get; set; }
        public Driver driver { get; set; }
        public float fare { get; set; }
        public int pickUpPoint { get; set; }
        public int dropOffPoint { get; set; }
        public string distance { get; set; }
        public DateTime date { get; set; }
        public Ride ride { get; set; }


        //Implementation
        public void generateReceipt() { }
    }
}
