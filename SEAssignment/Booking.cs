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
        public Vehicle vehicle { get; set; }
        public Ride ride { get; set; }
        


        //Implementation
        public void GenerateReceipt() { }

        public static void MakeBooking() 
        {
            //date
            Console.Write("Enter Ride date (DD/MM/YYYY): ");
            string datestr = Console.ReadLine();
            DateTime date = Convert.ToDateTime(datestr);
            //locations
            List<String> pickupdestList = EnterPickupLocation();
            //select vehicle goes here
            
        }
        public static List<string> EnterPickupLocation() 
        {
            List<string> locationList = new List<string>();
            Console.Write("Enter Pickup Location: ");
            string pickup = Console.ReadLine();
            locationList.Add(pickup);
            Console.Write("Enter Destination: ");
            string destination = Console.ReadLine();
            locationList.Add(destination);

            return (locationList);
        }

        public static string SelectVehicle() 
        {
            string vehicle ="";
            bool selectvalid = false;
            while (selectvalid == false) 
            {
                Console.WriteLine("Select A Vehicle from the list below by number: \n [1] Car \n [2] Bus \n [3] Van");
                string vehicletype = Console.ReadLine();
                if (vehicletype.CompareTo("1") == 0)
                {
                    vehicle = "Car";
                    selectvalid = true;
                    return (vehicle);
                }
                else if (vehicletype.CompareTo("2") == 0)
                {
                    vehicle = "Bus";
                    selectvalid = true;
                }
                else if (vehicletype.CompareTo("3") == 0)
                {
                    vehicle = "Van";
                    selectvalid = true;
                }
                else { Console.WriteLine("Not a valid input! Enter the corresponding number."); } 
            }

            
            int amount = 20;
            Console.WriteLine("Upfront deposit amount of ${0} is required for {1}", amount, vehicle);


            return (vehicle);

        }
    }
}
