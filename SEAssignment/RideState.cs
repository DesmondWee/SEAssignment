using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    public interface RideState
    {
        void startride(int? rideid);
        void stopride(int? rideid);
        void makepayment(int? rideid);
        void rate(int? rideid);
    }
}
