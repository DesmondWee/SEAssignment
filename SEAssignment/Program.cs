using System;

namespace SEAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test");
            Ride ride = new Ride();
            Booking booking = new Booking();
            Driverride(ride);
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
                if(finchoice == "Y")
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
