using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessExample
{
    internal class Airplane
    {
        private int _airSpeed=0;
        private int _throttlePosition = 0;
        private int _altitude = 0;

        public int AirSpeed
        {
            get
            {
                return _airSpeed;
            }
        }

        public int GetAltitude()
        {
            return _altitude;
        }

        public int GetAirspeed()
        {
            return _airSpeed;
        }

        public void ThrottleUp()
        {
            if (_throttlePosition < 8)
            {
                _throttlePosition++;

                _airSpeed = 100 * _throttlePosition;
            }
        }

        public void ThrottleDown()
        {
           

            if (_throttlePosition >= 0)
            {
                _throttlePosition--;

                _airSpeed = 100 * _throttlePosition;
            }
        }

        public void LiftUp()
        {
            if (_altitude < 50000)
            {
                _altitude = _altitude + 1000;
            }
        }

        public void LiftDown()
        {
            if (_altitude >= 0)
            {
                _altitude = _altitude - 1000;
            }
        }
    }
}
