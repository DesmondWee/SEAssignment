using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Van:Vehicle
    {
        public static List<Van> vanlist = new List<Van>();

        public  float DepositAmount { get; set; } = 25;
        public float BookingFee { get; set; } = 15;
        public Van() { }

        public Van(string lplate, string br, string mod) : base(lplate, br, mod) { }
    }
}
