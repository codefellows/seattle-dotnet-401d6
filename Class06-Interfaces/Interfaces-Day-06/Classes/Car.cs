using Interfaces_Day_06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Day_06.Classes
{
    public class Car : IDrivable
    {
        // ---------------------------------------------------------
        // CAR SPECIFIC
        // ---------------------------------------------------------
        public string Engine { get; set; }
        public string SteeringWheel { get; set; }

        public string[] Wheels()
        {
            string[] wheels = { "Wheel", "Wheel", "Wheel", "Wheel"};
            return wheels;
        }
        // ---------------------------------------------------------
        // IDRIVABLE
        // ---------------------------------------------------------

        void IDrivable.ChangeOrientation(float angle)
        {
            Console.WriteLine($"CAR - Changing the orientation by {angle} degrees");
        }

        void IDrivable.Start()
        {
            Console.WriteLine("CAR - Starting");
        }

        void IDrivable.Stop()
        {
            Console.WriteLine("CAR - Stopping");
        }
        // ---------------------------------------------------------
    }
}
