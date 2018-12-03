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

        private string zipCode; // 111 22

        public void SetZipCode(string inputZip)
        {
           string cleanInputZip = inputZip.Trim();
            int numbers;
            string nospacees = zipCode.Replace(" ", "");
            if (int.TryParse(nospacees, out numbers ))
            {
                zipCode = inputZip;
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong format try XX XXX! ");
                Console.ResetColor();
                zipCode = zipCode;

                if (zipCode.Equals("Exit"))
                {
                    zipCode = zipCode;
                }
                else
                {
                    Console.WriteLine("Gör igen!");
                }
            }  
        }
        
        public string GetZipCode()
        {
            return zipCode;
        }



        public string GetFullStreet()
        {
           return Street+ " " + StreetNumber;
        }
        
        public string FullStreet => Street + " " + StreetNumber;
     
    }
}
