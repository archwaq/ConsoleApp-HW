using System;
using System.Collections.Generic;
using System.Text;

namespace AviationLibrary
{
    public class AltimeterIndicator
    {
        public void OnAltitudeReached(object source, EventArgs e)
        {
            Console.WriteLine("Pressure reported by a particular station.");
        }
    }
}
