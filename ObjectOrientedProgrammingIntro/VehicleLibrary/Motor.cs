using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    public class Motor : IMotor
    {
        public Motor()
        {

        }

        public string Name { get ; set ; }
        public int ManufactureYear { get ; set ; }
        public string PlateNumber { get ; set ; }
        public bool IsDiesel { get ; set ; }

        public void Drive(double kilometers)
        {
            Console.WriteLine($"{kilometers} km/h");
        }

        public void GetYears(int vehicleManufactureYear)
        {
            DateTime dateTime = DateTime.Now;

            var result = dateTime.AddYears(-vehicleManufactureYear);

            Console.WriteLine(result.ToShortDateString());
        }
    }
}
