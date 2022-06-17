using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool buildAnother = true;

            while (buildAnother == true)
            {
                Console.WriteLine("How many wheels does your vehicle have?");
                string vehicleType = Console.ReadLine();

                IVehicle vehicle = VehicleFactory.GetVehicle(vehicleType);
                vehicle.Drive();

                Console.Write("Would you like to build another vehicle? ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "yes" || answer == "y")
                {
                    buildAnother = true;
                        Console.WriteLine();
                }
                else
                {
                    buildAnother = false;
                }

            }
            Console.WriteLine("Thanks for building vehicles!");
            Console.ReadLine();
        }
    }
}

