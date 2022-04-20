using System;

namespace AccessExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            Airplane boeing = new Airplane();
            Airplane airbus = new Airplane();

            boeing.ThrottleUp();
            boeing.ThrottleUp();
            boeing.ThrottleUp();
            boeing.ThrottleUp();

            boeing.LiftUp();

            Console.WriteLine("Boeing Speed is: " + boeing.AirSpeed);
            Console.WriteLine("Boeing Altitude is: " + boeing.GetAltitude());

            Console.WriteLine("Airbus Speed is: " + airbus.GetAirspeed());
            Console.WriteLine("Airbus Altitude is: " + airbus.GetAirspeed());


            // boeing._airspeed = 10000;
        }
    }
}
