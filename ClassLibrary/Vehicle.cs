using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class  Vehicle
    {

        /// <summary>
        /// instance fields string _liscencePlate, DateTime _date
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
        public Vehicle(string LiscencePlate, DateTime Date, bool BroBizz, double ActualPrice)
        {
            _brooBizz = BroBizz;
            _date = Date;
            _liscenseplate = LiscencePlate;
            if (LiscencePlate.Length > 7)
                throw new ArgumentException("Wrong format");
            _actualPrice = ActualPrice;

        }
        public Vehicle( double DiscountPrice)
        {
            _discountPrice = DiscountPrice;
        }

        public Vehicle()
        {

        }



        /// <summary>
        /// public properties LiscencePlate, Date 
        /// </summary>
        public string LiscencePlate { get; set; }
       /// <summary>
       /// public property Date
       /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// public int  property Discount
        /// </summary>
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

        /// <summary>
        /// Public bool property BroBizz
        /// </summary>
        public bool BroBizz { get; set; }
        public double ActualPrice { get; set; }
        /// <summary>
        /// Virtual method double Price 
        /// </summary>
        /// <returns> if brobizz = true DiscountPrice </returns>
        public virtual double Price()
        {
            
                return ActualPrice - DiscountPrice;
         }  
        
       

        /// <summary>
        /// Abstract method string VehiculeType
        /// </summary>
        /// <returns></returns>
        public abstract string VehiculeType();

       
       
    }
}
