using System;

namespace Accessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Address firstAdress = new Address
            {
                Street = "Första Gatan",
                StreetNumber = 12,
                City = "Göteborg",
                ZipCode = 1234,
            };
            Console.WriteLine($"Street: \t \t {firstAdress.Street} \n" +
                $"StreetNumber: \t \t {firstAdress.StreetNumber} \n" +
                $"City: \t \t \t {firstAdress.City} \n" +
                $"ZipCode: \t \t {firstAdress.ZipCode} \n" +
                $"FullStreet: \t \t {firstAdress.FullStreet}");
        }
    }
}
