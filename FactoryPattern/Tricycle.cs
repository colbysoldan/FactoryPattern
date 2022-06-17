using System;
namespace FactoryPattern
{
    public class Tricycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("We're building a tricycle!\n");
        }
    }
}

