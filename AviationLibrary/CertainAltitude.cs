using System;
using System.Collections.Generic;
using System.Text;

namespace AviationLibrary
{
    public class CertainAltitude
    {
        public delegate void CertainAltitudeReachedEventHandler(object source, EventArgs args);

        public event CertainAltitudeReachedEventHandler AltitudeReached;
        public void AltitudeProcessor(FighterJet fighterJet)
        {
            if (fighterJet.Altitude <= 0)
            {
                Console.WriteLine("Zero level");
                OnAltitudeReached();
            }
            else
            {
                Console.WriteLine("Height Above Sea Level");
                OnAltitudeReached();
            }
        }

        public void AltitudeProcessor(TouristJet touristJet)
        {
            if (touristJet.Altitude <= 0)
            {
                Console.WriteLine("Zero level");
                OnAltitudeReached();
            }
            else
            {
                Console.WriteLine("Height Above Sea Level");
                OnAltitudeReached();
            }
        }
        protected virtual void OnAltitudeReached()
        {
            AltitudeReached?.Invoke(this, EventArgs.Empty);
        }
    }
}
