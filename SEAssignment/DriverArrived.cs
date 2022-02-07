using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class DriverArrived:RideState
    {
        private Ride ride;
        public DriverArrived(Ride ride)
        {
            this.ride = ride;
        }
        public void startride(int? rideid)
        {
            if (rideid == null)
            {
                Console.WriteLine("No ride available");
            }
            else
            {
                ride.setState(new RideStarted(ride));
            }
        }
        public void stopride(int? rideid)
        {
            if (rideid == null)
            {
                Console.WriteLine("No ride available");
            }
            else
            {
                Console.WriteLine("Ride not started yet");
            }
        }
        public void makepayment(int? rideid)
        {
            if (rideid == null)
            {
                Console.WriteLine("No ride available");
            }
            else
            {
                Console.WriteLine("Ride not finished.");
            }
        }
        public void rate(int? rideid)
        {
            if (rideid == null)
            {
                Console.WriteLine("No ride available");
            }
            else
            {
                Console.WriteLine("Payment not yet made.");
            }
        }
    }
}
