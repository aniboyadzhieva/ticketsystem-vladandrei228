using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Car
    {
        public override double Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
