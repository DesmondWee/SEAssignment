using System;

namespace SEAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
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
                }

                else if (option2 == "2")
                {
                    RegisterCustomer();
                }
                else
                {
                    return;
                }
            }
        }

        public static void RegisterCustomer()
        {
            Console.WriteLine("Enter Customer Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Customer Contact Number: ");
            string contactNumber = Console.ReadLine();

            Console.WriteLine("Enter Customer Email Address: ");
            string EmailAddress = Console.ReadLine();
        }

        public static void RegisterDriver()
        {
            Console.WriteLine("Enter Driver Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Driver Contact Number: ");
            string contactNumber = Console.ReadLine();

            Console.WriteLine("Enter Driver Email Address: ");
            string EmailAddress = Console.ReadLine();

            Console.WriteLine("Enter Bank Account: ");
            string bankAccount = Console.ReadLine();

            Console.WriteLine("Enter Bank Name: ");
            string bankName = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Licence Plate Number: ");
            string LicencePlateNumber = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Brand: ");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter Vehicle Model: ");
            string model = Console.ReadLine();
        }

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
