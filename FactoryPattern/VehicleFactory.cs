using System;
namespace FactoryPattern
{
	public static class VehicleFactory
	{
		public static IVehicle GetVehicle(string vehicleType)
        {
			switch(vehicleType.ToLower())
            {

				case "0":
					return new Sled();
				case "2":
					return new Motorcycle();
				case "3":
					return new Tricycle();
				case "4":
					return new Car();
				case "6":
					return new Dually();
				default:
					return new Random();
            }
        }
	}
}

