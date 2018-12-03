using System;

namespace Accessor
{
    class Program
    {
        static void Main(string[] args)
        {
            Address firstAdress = new Address
            {

                ZipCode = 12345,
            };
            Console.WriteLine($"ZipCode: \t \t {firstAdress.ZipCode}");
        }
    }
}
