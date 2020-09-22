using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car
    {
        public virtual string Licenseplate
        {
            get;
            set;
        }

        public virtual DateTime Date { get; set; }

        public virtual double Price()
        {
            return 240;
        }

        public virtual string VehicleType()
        {
            return "Car";
        }

    }
}
