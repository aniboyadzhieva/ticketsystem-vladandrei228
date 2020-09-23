using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace Oresundbron
{
    public class OresundMC : Vehicle
    {
        public OresundMC(string licensePlate, DateTime dateTime, bool brobizz) : base(licensePlate, dateTime, brobizz)
        {
        }

        public override double Price()
        {
            return 210;
        }

        public override string VehiculeType()
        {
            return "Oresund MC";
        }

        public override double BrobizzDisc()
        {
            if (BroBizz == true)
            {
                return 73;
            }
            else
            {
                return Price();
            }
        }
    }
}
