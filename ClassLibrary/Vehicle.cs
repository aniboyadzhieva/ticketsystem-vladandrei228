using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class  Vehicle
    {

        private string _liscenseplate;

        public DateTime Date { get; set; }

       public bool BroBizz { get; set; }
       
        /// <summary>
        /// public constructor 
        /// </summary>
        public Vehicle(string liscencePlate, DateTime date, bool broBizz)
        {
            LicensePlate = liscencePlate;
            BroBizz = broBizz;
            Date = date;

        }
        /// <summary>
        /// Empty constructor for using it in unit test
        /// </summary>
        public Vehicle()
        {
        }

        public string LicensePlate
        {
            get { return this._liscenseplate; }
            set
            {
                if (this._liscenseplate.Length > 7)
                {
                    throw new ArgumentException("License plate must contain less than 7 characters");
                    this._liscenseplate = value;
                }
            }
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
        public virtual double BrobizzDisc()
        {
            if (BroBizz == true)
            {
                return Price() * 0.95;
            }

            return Price();
        }

       
       
    }
}
