using System;
using System.Collections.Generic;
using System.Text;

namespace Accessor
{
    class Address
    {
        public String Street { get; set; }
        public int StreetNumber { get; set; }
        public String City { get; set; }
        public int ZipCode { get; set; }


        public string GetFullStreet()
        {
            return Street + " " + StreetNumber;
        }

        public string FullStreet => Street + " " + StreetNumber;

        private int zipcode = "111 22";
        public int ZipCode
        {
            get
            {
                return zipcode;
            }
            set
            {
                if ((value > 0) && (value < 6))
                    zipcode = value;
            }
        }

    }
}
