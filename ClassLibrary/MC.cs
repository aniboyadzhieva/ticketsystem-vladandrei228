using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {
        public MC(string licensePlate, DateTime dateTime, bool brobizz) : base(licensePlate, dateTime, brobizz)
        {
        }

        public MC() : base()
        {

        }

        /// <summary>
        /// public ovveride double method Price 
        /// </summary>
        /// <returns>125- discount</returns>
        public override double Price()
        {
            return 125;
        }
        /// <summary>
        /// public override string method VehiculeType  
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehiculeType()
        {
            return "MC";
        }
    }
}
