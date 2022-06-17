﻿using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{
		}

        public void Drive()
        {
            Console.WriteLine("We're building a motorcycle! Or a bicycle... or maybe a hoverboard.\n");
        }
    }
}

