using System;
using System.Collections.Generic;
using System.Text;

namespace Oresundbron
{
    public class OresundCar : ClassLibrary.Vehicle
    {
        public OresundCar(string licensePlate, DateTime dateTime, bool brobizz) : base(licensePlate, dateTime, brobizz )
        {
        }

        public override double Price()
        {
            return 410;
        }

        public override string VehiculeType()
        {
            return "Oresund Car";
        }

        public override double BrobizzDisc()
        {
            if (BroBizz == true)
            {
                return 161;
            }
            else
            {
                return Price();
            }
        }
    }
}
