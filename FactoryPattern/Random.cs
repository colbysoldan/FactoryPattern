using System;
namespace FactoryPattern
{
    public class Random : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("I've never built that type of vehicle before, but let's do it!\n");
        }
    }
}

