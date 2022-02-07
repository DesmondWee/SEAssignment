using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Vehicle
    {
        private string licensePlate;
        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = LicensePlate; }
        }
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = Brand; }
        }
        private string model;
        public string Model
        {
            get { return model; }
            set { model = Model; }
        }

        public Vehicle() { }
    }
}
