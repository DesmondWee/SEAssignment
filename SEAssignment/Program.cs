using System;
using System.Collections.Generic;

namespace SEAssignment
{
    class Program
    {

        static void Main(string[] args)
        {
            Customer tempCustomer = new Customer();
            Car tempCar = new Car("ABC", "brand", "model");
            List<Ride> ridelist = new List<Ride>();
            Car.carlist.Add(tempCar);
            bool exit = false;
            List<string> bookinglist = new List<string>();
            bookinglist.Add("");
            while (exit == false)
            {
                Console.WriteLine("PickUpNow Menu");
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. MakeBooking");
                Console.WriteLine("3. Start Ride");
                Console.WriteLine("4. Withdraw (Driver)");
                Console.WriteLine("5. Make payment (Customer)");


                Console.WriteLine("Enter option: ");
                string option1 = Console.ReadLine();
                if (option1 == "0")
                {
                    exit = true;
                    Console.WriteLine("Press Any Key To Exit.");
                    Console.ReadKey();

                }
                else if (option1 == "1")
                {
                    Console.WriteLine("Register");
                    Console.WriteLine("1. Register as Driver");
                    Console.WriteLine("2. Register as Csutomer");

                    Console.WriteLine("Enter option: ");
                    string option2 = Console.ReadLine();

                    if (option2 == "1")
                    {
                        RegisterDriver();
                        return;
                    }

                    else if (option2 == "2")
                    {
                        RegisterCustomer();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (option1 == "2")
                {
                    
                    Booking.MakeBooking(tempCustomer);
                    
                    bookinglist[0]=("Booked");
                    
                }
                else if (option1 == "3")
                {
                    Ride newride = Driverride(bookinglist);
                    ridelist.Add(newride);

                }
                else if (option1 == "4")
                {
                    WithdrawAmount();
                }
                else if (option1 == "5")
                {
                    CustomerPayment(ridelist);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

                
            }
        }

        // Customer Registration
        public static void RegisterCustomer()
        {
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Customer Contact Number: ");
            int contactNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer Email Address: ");
            string emailAddress = Console.ReadLine();
        }

        // Driver Registration
        public static void RegisterDriver()
        {
            Console.WriteLine("Enter Driver Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Driver Contact Number: ");
            int contactNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Driver Email Address: ");
            string emailAddress = Console.ReadLine();

            Console.WriteLine("Enter Bank Account: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Bank Name: ");
            string bankName = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Licence Plate Number: ");
            string licencePlateNumber = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Model: ");
            string model = Console.ReadLine();

            
            if (model == "Car")
            {
                Car newVehicle = new Car(licencePlateNumber, brand, model);
                Car.carlist.Add(newVehicle);
                Driver newDriver = new Driver(name, contactNumber, emailAddress, newVehicle);
            }
            else if(model == "Van")
            {
                Van newVehicle = new Van(licencePlateNumber, brand, model);
                Van.vanlist.Add(newVehicle);
                Driver newDriver = new Driver(name, contactNumber, emailAddress, newVehicle);
            }
            else if(model == "Bus")
            {
                Bus newVehicle = new Bus(licencePlateNumber, brand, model);
                Bus.buslist.Add(newVehicle);
                Driver newDriver = new Driver(name, contactNumber, emailAddress, newVehicle);
            }
            else
            {
                Console.WriteLine("Driver registration unsuccessful.");
            }
           
        }

        // Driver Wtihdraw Amount from PickUpNow
        public static void WithdrawAmount()
        {
            int Amount = 1000;

            Console.WriteLine("Enter Amount for Withdraw: ");
            string WithdrawAmount = Console.ReadLine();

            if (!int.TryParse(WithdrawAmount, out Amount))
            {
                Console.WriteLine("Invalid Amount!!!");
                return;
            }
            else
            {
                Console.WriteLine("Withdraw Succeccful.");
            }
        }

        static Ride Driverride(List<string> bookinglist)
        {
            if (bookinglist[0] == "")
            {
                Console.WriteLine("No booking made");
            }
            else if (bookinglist[0] == "Booked")
            {
                Ride ride = new Ride();
                Console.Write("Start ride [Y/N]: ");
                string choice = Console.ReadLine();

                if (choice == "Y")
                {
                    ride.startride(ride.rideid);
                    Console.Write("Finish ride [Y/N]: ");
                    string finchoice = Console.ReadLine();
                    if (finchoice == "Y")
                    {
                        ride.stopride(ride.rideid);
                        Console.WriteLine("");
                        return ride;
                    }
                }
                else
                {

                }

            }
            return null;
        }
        static void RateRide(Ride ride)
        {
            Console.Write("Do you want to give a rating? ");
            string choice = Console.ReadLine();
            if (choice == "Y")
            {
                Console.Write("Give ride a rating out of 5: ");
                string rating = Console.ReadLine();
                ride.rate(ride.rideid);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No rating will be given");
            }
        }
        static void CustomerPayment(List<Ride> ridelist)
        {
            Console.Write("Do you wish to make payment for ride? ");
            string input = Console.ReadLine();
            if(input == "Y")
            {
                Ride newride = ridelist[0];
                newride.makepayment(newride.rideid);
                Console.WriteLine("Payment made to driver");
                Console.WriteLine("Recepit sent to customer email");
                RateRide(newride);
            }
        }
    }
}
