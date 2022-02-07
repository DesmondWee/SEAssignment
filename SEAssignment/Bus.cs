using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Bus:Vehicle
    {
        public static List<Bus> buslist = new List<Bus>();
        public float DepositAmount { get; set; } = 25;
        public Bus() { }

        public Bus(string lplate,string br,string mod):base(lplate,br,mod) { }

        
    }
}
