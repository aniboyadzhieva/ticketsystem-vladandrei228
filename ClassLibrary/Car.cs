using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="LiscencePlate"></param>
        /// <param name="Date"></param>
        public Car(string LiscencePlate, DateTime Date, bool BroBizz) : base(LiscencePlate, Date, BroBizz)
        {

        }

        public Car() : base()
        {

        }

        /// <summary>
        /// public double  override method Price
        /// </summary>
        /// <returns>240</returns>
        public override double Price()
        {
            return 240;
        }
        /// <summary>
        /// public string  override method VehiculeType 
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehiculeType()
        {
            return "Car";
        }

    }
}
