using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibraryExtended
{
    public class Scouter : Motor
    {
        public Scouter()
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

        public override void StartTurbo()
        {
            Console.WriteLine("Turbo mode Not included in this brand.");
        }
    }
}
