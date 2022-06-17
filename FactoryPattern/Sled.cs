using System;
namespace FactoryPattern
{
	public class Sled : IVehicle
	{
		public void Drive()
		{
			Console.WriteLine("This is a sled...");
		}
	}
}

