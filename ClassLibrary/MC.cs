using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC : Vehicle
    {

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        public MC(string LiscencePlate, DateTime Date, bool BroBizz) : base(LiscencePlate, Date, BroBizz)
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
