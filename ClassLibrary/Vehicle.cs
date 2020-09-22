using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class  Vehicle
    {
        /// <summary>
        /// Properties
        /// </summary>
        public DateTime Date { get; set; }
        public bool BroBizz { get; set; }
       public string LicensePlate { get; set; }

       /// <summary>
       /// LicensePlate lenght check.
       /// </summary>
       /// <param name="LP"></param>
       /// <returns></returns>
       public virtual string LPCheck( string LP)
       {
           var lp = LP;
           if (lp.Length > 7)
           {
               throw new ArgumentException("I am sorry, but your LP must contain maximum 7 characters");
           }

           return lp;
       }
       
       
        /// <summary>
        /// Empty constructor for using it in unit test
        /// </summary>
        public Vehicle()
        {
        }

       
        /// <summary>
        /// Virtual method for Price 
        /// </summary>
        /// <returns> if brobizz = true DiscountPrice </returns>
        public virtual double Price()
        {
            return default;
        }

        /// <summary>
        /// VehiculeType method
        /// </summary>
        public abstract string VehiculeType();

        /// <summary>
        /// Brobizz parking discount
        /// </summary>
        public virtual double BrobizzDisc(bool bro)
        {
            bool brodisc = bro;
            if (brodisc == true)
            {
                return Price() * 0.95;
            } return Price();
        }

       
       
    }
}
