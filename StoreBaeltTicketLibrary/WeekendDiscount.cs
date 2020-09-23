using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace StoreBaeltTicketLibrary
{
    public class WeekendDiscount : ClassLibrary.Vehicle
    {
        public WeekendDiscount(string licensePlate, DateTime dateTime, bool brobizz) : base(licensePlate, dateTime,
            brobizz)
        {
        }

        public override double Price()
        {
            if (Date.DayOfWeek== DayOfWeek.Saturday || Date.DayOfWeek==DayOfWeek.Sunday)
            {
                return base.Price() * 0.80;
            }

            return base.Price();
        }

        public override string VehiculeType()
        {
            throw new NotImplementedException();
        }
    }
}
