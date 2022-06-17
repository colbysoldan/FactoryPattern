using System;
namespace FactoryPattern
{
	public class Unicycle : IVehicle
	{
		
        public void Drive()
        {
            Console.WriteLine("A unicycle! I'll get you a red nose and some juggling balls, too.");
        }
    }
}

