using System;
using System.Collections.Generic;
using System.Text;

namespace SEAssignment
{
    class Car:Vehicle
    {
        public static List<Car> carlist = new List<Car>();
        public Car() { }

        public Car(string lplate, string br, string mod):base(lplate,br,mod)
        { }
    }
}
