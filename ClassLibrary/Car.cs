using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        public string Licenseplate
        {
            get;
            set;
        }

        public DateTime Date;

        public double Price()
        {
            return 240;
        }

        public string VehicleType()
        {
            return "Car";
        }

    }
}
