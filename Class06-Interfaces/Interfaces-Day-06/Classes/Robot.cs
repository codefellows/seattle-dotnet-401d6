using Interfaces_Day_06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Day_06.Classes
{
    class Robot : IDrive, ISpeak
    {
        string IDrive.DriversLicence { get; set; }
        string IDrive.InsuranceInformation { get; set; }

        void IDrive.Drive(IDrivable vehicle)
        {
            Console.WriteLine("console.log(I can drive better than any human)");
            vehicle.Start();
            vehicle.Stop();
        }

        void ISpeak.Speak()
        {
            Console.WriteLine("10101010101001010101010101010");
        }
    }
}
