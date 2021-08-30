using System;
using System.Collections.Generic;
using System.Text;

namespace AviationLibrary
{
    public class AirspeedIndicator
    {
        public void OnSpeedReached(object source, EventArgs e)
        {
            Console.WriteLine("The plane begins the initial climb.");
        }
    }
}
