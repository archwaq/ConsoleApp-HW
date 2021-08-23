using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleLibraryExtended
{
    /// <summary>
    /// Абстрактните класове реализират само някои от методите си и задължават наследниците си да реализират останалите​.
    /// Abstract classes може също да дефинират abstract methods. Абстрактните методи нямат имплементация.​
    /// Абстрактните методи всъщност представляват виртуални методи без конкретна имплементация.
    /// Абстрактните класове не могат да се инстанциират директно.
    /// С ключовата дума abstract може да се създават класове и членове на класа, които са незавършени и трябва да бъдат имплементирани в техния клас наследник.​
    /// </summary>
    public abstract class Motor
    {
        public string Name { get; set; }
        public int ManufactureYear { get; set; }
        public string PlateNumber { get; set; }
        public bool IsDiesel { get; set; }
        public int TyresNumber { get; set; }

        public abstract void Drive(double kilometers);

        public abstract void GetYears(int years);

        public abstract void StartTurbo();

    }
}
