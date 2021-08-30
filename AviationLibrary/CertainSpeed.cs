using System;
using System.Collections.Generic;
using System.Text;

namespace AviationLibrary
{
    public class CertainSpeed
    {
        public delegate void CertainSpeedReachedEventHandler(object source, EventArgs args);

        public event CertainSpeedReachedEventHandler SpeedReached;

        public void SpeedProcessor(FighterJet fighterJet)
        {
            if (fighterJet.Speed > 1000)
            {
                OnSpeedReached();
            }
            else
            {
                Console.WriteLine("Accelerate!");
            }
        }

        public void SpeedProcessor(TouristJet touristJet)
        {
            if (touristJet.Speed > 3000)
            {
                OnSpeedReached();
            }
            else
            {
                Console.WriteLine("Accelerate!");
            }
        }
        protected virtual void OnSpeedReached()
        {
            SpeedReached?.Invoke(this, EventArgs.Empty);
        }
    }
}
