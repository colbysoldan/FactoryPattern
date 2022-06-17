using System;
namespace FactoryPattern
{
    public class Dually : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("We're building a Dually... either you're doing some serious hauling or you think this makes you cool (?)\n");
        }
    }
}

