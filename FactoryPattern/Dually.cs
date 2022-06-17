using System;
namespace FactoryPattern
{
    public class Dually : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("We're building a Dually!\n");
        }
    }
}

