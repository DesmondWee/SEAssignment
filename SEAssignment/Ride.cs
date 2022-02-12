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
        public RideState getstartride() { return ridestarted; }
        public RideState getridedone() { return ridedone; }
        public RideState getdriverarrived() { return driverarrived; }
        public RideState getpaymentdone() { return paymentdone; }
        public RideState getrated() { return rated; }
        public void setState(RideState rs) { state = rs; }
        public int rideid { get; set; }

        public DateTime starttime { get; set; }

        public DateTime endtime { get; set; }

        public RideState rideState { get; set; }

        public Driver Driver { get; set; }

        public Customer Customer { get; set; }

        public void startride(int? rideid)
        {
            state.startride(rideid);
        }
        public void stopride(int? rideid)
        { state.stopride(rideid); }
        public void makepayment(int? rideid)
        { state.makepayment(rideid); }
        public void rate(int? rideid)
        { state.rate(rideid); }
    }
}
