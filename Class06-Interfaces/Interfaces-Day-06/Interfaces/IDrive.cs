using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Day_06.Interfaces
{
    public interface IDrive
    {
        string DriversLicence { get; set; }

        string InsuranceInformation { get; set; }

        void Drive(IDrivable vehicle);
    }
}
