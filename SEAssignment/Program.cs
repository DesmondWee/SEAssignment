using System;

namespace SEAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vList = new List<Vehicle>();

            Console.WriteLine("PickUpNow Menu");
            Console.WriteLine("1. Register");

            Console.WriteLine("Enter option: ");
            string option1 = Console.ReadLine();

            if (option1 == "1")
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
        public static void RegisterDriver(List<Vehicle> vList)
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

            Vehicle newVehicle;
            if (model == "Car")
            {
                newVehicle = new Car();
                vList.Add(newVehicle);
            }
            else if(model == "Van")
            {
                newVehicle = new Van();
                vList.Add(newVehicle);
            }
            else if(model == "Bus")
            {
                newVehicle = new Bus();
                vList.Add(newVehicle);
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
        static void Driverride(Ride ride)
        {
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
                    Driver driver = new Driver();
                    Console.WriteLine("Receipt sent to Customer's email");
                    ride.makepayment(ride.rideid);
                }
            }
        }
    }
}
