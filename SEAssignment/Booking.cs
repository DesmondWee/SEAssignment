using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Booking
    {
        public int ReferenceNumber { get; set; }
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }
        public float Fare { get; set; }
        public int PickUpPoint { get; set; }
        public int DropOffPoint { get; set; }
        public string Distance { get; set; }
        public DateTime Date { get; set; }
        public Vehicle Vehicle { get; set; }
        public Ride Ride { get; set; }

        public static int NextRefNo { get; set; } = 1;

        public Booking( ) { }
        public Booking(Customer cust, DateTime date, int pickuppoint , int dropoffpoint, Vehicle vehicle ) 
        {
            Customer = cust;
            Date = date;
            PickUpPoint = pickuppoint;
            DropOffPoint = dropoffpoint;
            Vehicle = vehicle;
            ReferenceNumber = NextRefNo;

            NextRefNo = NextRefNo + 1;
        }
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
            Vehicle vehicle= SelectVehicle(date);
            
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

        public static Vehicle SelectVehicle( DateTime date) 
        {
            Vehicle vehicletyper = new Vehicle();
           
            bool selectvalid = false;
            bool selectvalidVehicle = false;
            while (selectvalid == false) 
            {
                Console.WriteLine("Select A Vehicle from the list below by number: \n [1] Car \n [2] Bus \n [3] Van");
                string vehicletype = Console.ReadLine();
                if (vehicletype.CompareTo("1") == 0)
                {
                    List<Car> availableCarsList = new List<Car>();
                   
                    selectvalid = true;
                    foreach (Car x in Car.carlist)
                    {
                        bool isBooked = false;
                        foreach (DateTime y in x.BookedDateList)
                        {
                            if (y == date)
                            {
                                isBooked = true;

                            }
                        }
                        if (isBooked == false)
                        {
                            availableCarsList.Add(x);
                        }

                    }
                    while (selectvalidVehicle == false)
                    {
                        Console.WriteLine("Displaying available cars.");
                        int i = 1;
                        foreach (Car c in availableCarsList)
                        {

                            Console.WriteLine("[{0}] Car Model: {1} Car Brand {2}", i, c.Model, c.Brand);
                            i = i + 1;
                        }
                        Console.Write("Enter the number of the car you would like to select: ");
                        string selectvehiclenumber= Console.ReadLine();
                        int selected = Convert.ToInt32(selectvehiclenumber) - 1;
                        if (availableCarsList[selected] != null) 
                        {
                            
                            selectvalidVehicle = true;
                            return (availableCarsList[selected]);
                        } 
                    }
                    
                }
                else if (vehicletype.CompareTo("2") == 0)
                {
                    List<Bus> availablebusList = new List<Bus>();
                    
                    selectvalid = true;

                    foreach (Bus x in Bus.buslist)
                    {
                        bool isBooked = false;
                        foreach (DateTime y in x.BookedDateList)
                        {
                            if (y == date)
                            {
                                isBooked = true;

                            }
                        }
                        if (isBooked == false)
                        {
                            availablebusList.Add(x);
                        }

                    }
                    while (selectvalidVehicle == false)
                    {
                        Console.WriteLine("Displaying available buses.");
                        int i = 1;
                        foreach (Bus c in availablebusList)
                        {

                            Console.WriteLine("[{0}] Bus Model: {1} Bus Brand {2}", i, c.Model, c.Brand);
                            i = i + 1;
                        }
                        Console.Write("Enter the number of the bus you would like to select: ");
                        string selectvehiclenumber = Console.ReadLine();
                        int selected = Convert.ToInt32(selectvehiclenumber) - 1;
                        if (availablebusList[selected] != null)
                        {

                            selectvalidVehicle = true;

                            //do payment 
                            Console.WriteLine("Deposit of ${0} has to be made. Enter anykey to make payment.", availablebusList[selected].DepositAmount);
                            Console.ReadKey();

                            return (availablebusList[selected]);
                        }
                    }

                }
                else if (vehicletype.CompareTo("3") == 0)
                {
                    List<Van> availablevanlist = new List<Van>();
                    
                    selectvalid = true;

                    foreach (Van x in Van.vanlist)
                    {
                        bool isBooked = false;
                        foreach (DateTime y in x.BookedDateList)
                        {
                            if (y == date)
                            {
                                isBooked = true;

                            }
                        }
                        if (isBooked == false)
                        {
                            availablevanlist.Add(x);
                        }

                    }
                    while (selectvalidVehicle == false)
                    {
                        Console.WriteLine("Displaying available vans.");
                        int i = 1;
                        foreach (Van c in availablevanlist)
                        {

                            Console.WriteLine("[{0}] Van Model: {1} Van Brand {2}", i, c.Model, c.Brand);
                            i = i + 1;
                        }
                        Console.Write("Enter the number of the van you would like to select: ");
                        string selectvehiclenumber = Console.ReadLine();
                        int selected = Convert.ToInt32(selectvehiclenumber) - 1;
                        if (availablevanlist[selected] != null)
                        {

                            selectvalidVehicle = true;

                            //do payment 
                            Console.WriteLine("Deposit of ${0}, and booking fee of ${1} has to be made. Enter anykey to make payment.", availablevanlist[selected].DepositAmount, availablevanlist[selected].BookingFee);
                            Console.ReadKey();

                            return (availablevanlist[selected]);
                        }
                    }
                }
                else { Console.WriteLine("Not a valid input! Enter the corresponding number."); } 
            }


            return(vehicletyper);

        }
        public void CancleBooking() { }
    }
}
