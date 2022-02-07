using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public class Ride
    {
        private RideState ridestarted;
        private RideState ridedone;
        private RideState driverarrived;
        private RideState paymentdone;
        private RideState rated;
        private RideState state;

        
        public Ride()
        {
            ridestarted = new RideStarted(this);
            ridedone = new RideDone(this);
            driverarrived = new DriverArrived(this);
            paymentdone = new PaymentDone(this);
            rated = new Rated(this);

            state = driverarrived;
        }

        public void setState(RideState state)
        {
            this.state = state;
        }
        public int rideid { get; set; }

        public DateTime starttime { get; set; }

        public DateTime endtime { get; set; }

        public RideState rideState { get; set; }

        public Driver driver { get; set; }

        public Customer customer { get; set; }

        public void startride(int? rideid)
        {
            if (rideid == null)
            {
                Console.WriteLine("No ride available");
            }
            else
            {
                if (state == driverarrived)
                {
                    state = ridestarted;
                    Console.WriteLine("Ride started");
                }
                else
                {
                    Console.WriteLine("Driver hasn't arrived");
                }
            }
        }
        public void stopride(int? rideid)
        {
            if(rideid == null)
            {
                Console.WriteLine("No ride available");
            }
            else
            {
                if (state == ridestarted)
                {
                    state = ridedone;
                    Console.WriteLine("Ride ended");
                }
                else
                {
                    Console.WriteLine("Ride not started yet");
                }
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
                if (state == ridedone)
                {
                    state = paymentdone;
                    Console.WriteLine("Payment made");
                }
                else
                {
                    Console.WriteLine("Ride not finished.");
                }
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
                if (state == paymentdone)
                {
                    state = rated;
                    Console.WriteLine("Received rating");
                }
                else
                {
                    Console.WriteLine("Payment not yet made.");
                }
            }
        }
    }
}
