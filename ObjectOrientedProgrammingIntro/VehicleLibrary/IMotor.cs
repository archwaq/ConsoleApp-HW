using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibrary
{
    /// <summary>
    /// Интерфейсите в C# са подобни на абстрактните класове, но за разлика от тях​
    /// не съдържат имплементация на методите си
    /// членовете им нямат модификатори на видимостта и се подразбира видимост public
    /// не могат да имат полета, дори да са константи (не е като в Java), но могат да имат свойства и събития (properties and events)​
    /// </summary>
    interface IMotor
    {
        public string Name { get; set; }
        public int ManufactureYear { get; set; }
        public string PlateNumber { get; set; }
        public bool IsDiesel { get; set; }

        public void Drive(double kilometers);

        public void GetYears(int years);
    }
}
