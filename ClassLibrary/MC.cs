using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MC
    {
        public string Licenseplate { get; set; }
        public DateTime date { get; set; }

        public double Price()
        {
            return 125;
        }

        public string Vehicle()
        {
            return "MC";
        }
    }
}
