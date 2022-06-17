using System;
namespace FactoryPattern
{
    public class Tricycle : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("We're building a tricycle! Kind of like a unicycle with training wheels.\n");
        }
    }
}

