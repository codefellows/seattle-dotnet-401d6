using Interfaces_Day_06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Day_06.Classes
{
    class Bicycle : IDrivable
    {
        void IDrivable.ChangeOrientation(float angle)
        {
            Console.WriteLine($"BIKE - Changing the orientation by {angle} degrees");
        }

        void IDrivable.Start()
        {
            Console.WriteLine("BIKE - Starting");
        }

        void IDrivable.Stop()
        {
            Console.WriteLine("BIKE - Stopping");
        }
    }
}
