﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibraryExtended
{
    public class Car : Motor
    {
        public Car()
        {

        }

        public override void Drive(double kilometers)
        {
            Console.WriteLine($"{kilometers} km/h");
        }

        public override void GetYears(int vehicleManufactureYear)
        {
            DateTime dateTime = DateTime.Now;

            var result = dateTime.AddYears(-vehicleManufactureYear);

            Console.WriteLine(result.ToShortDateString());
        }

        public sealed override void StartTurbo()
        {
            Console.WriteLine("Turbo mode On.");
        }
    }
}
