using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{

    public class Vehicle
    {
        
        public string LicensePlate { get; set; }
        
       
        public string Brand { get; set; }
       
      
        public string Model { get; set; }
       

        
        private List<DateTime> bookedDateList = new List<DateTime>();
        public List<DateTime> BookedDateList
        {
            get { return bookedDateList; }
            set { bookedDateList = BookedDateList; }
        }
        public Vehicle() { }
        public Vehicle(string lplate, string br, string mod) 
        {
            LicensePlate = lplate;
            Brand = br;
            Model = mod;
        }


    

    }
}
