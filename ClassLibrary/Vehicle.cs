using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class  Vehicle
    {

        /// <summary>
        /// instance fields
        /// </summary>
        private string _liscenseplate;
        private DateTime _date;
        private double _actualPrice;
        private bool _brooBizz;
        private double _discountPrice;
       
        /// <summary>
        /// public constructor 
        /// </summary>
        /// <param name="LiscencePlate"> Lenght not more then 7 characters else exception</param>
        /// <param name="Date"></param>
        /// <param name ="BroBizz">type booleon</para>
        /// <param name="ActualPrice">type double</param>
        public Vehicle(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice)
        {
            _brooBizz = BroBizz;
            _date = Date;
            _liscenseplate = LiscencePlate;
            //if (LiscencePlate.Length > 7)
            //    throw new ArgumentException("Wrong format");
            _actualPrice = ActualPrice;

        }
        public Vehicle( double DiscountPrice)
        {
            _discountPrice = DiscountPrice;
        }
        /// <summary>
        /// Empty constructor for using it in unit test
        /// </summary>
        public Vehicle()
        {

        }

        /// <summary>
        /// properties
        /// </summary>
        public string LiscencePlate { get; set; }
        public string Date { get; set; }
        public double DiscountPrice
        {
            
            get { return _discountPrice; }
            set
            {
                if (BroBizz == true)
                    _discountPrice = ActualPrice - ActualPrice * 0.05;
                else _discountPrice = 0;
            }
        }

        public bool BroBizz { get; set; }
        public double ActualPrice { get; set; }

        /// <summary>
        /// Virtual method for Price 
        /// </summary>
        /// <returns> if brobizz = true DiscountPrice </returns>
        public virtual double Price()
        {
            return ActualPrice - DiscountPrice;
        }

        /// <summary>
        /// VehiculeType method
        /// </summary>
        public abstract string VehiculeType();

       
       
    }
}
