using Interfaces_Day_06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Day_06.Classes
{
    class Student : Human, IDrive, ISpeak
    {
        public void Study()
        {
            Console.WriteLine("Learning all the learnings");
        }

        string IDrive.DriversLicence { get; set; }
        string IDrive.InsuranceInformation { get; set; }

        public override void Speak()
        {
            Console.WriteLine("I want to be free of all this study");
        }

        public void Drive(IDrivable vehicle)
        {
            Console.WriteLine("Take it easy. I'm just learnig to drive");
            vehicle.Start();
            vehicle.ChangeOrientation(45);
            vehicle.ChangeOrientation(-45);
            vehicle.Stop();
        }
    }
}
