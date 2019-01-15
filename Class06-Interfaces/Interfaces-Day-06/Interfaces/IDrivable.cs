using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Day_06.Interfaces
{
    public interface IDrivable
    {
        void Start();

        void Stop();

        void ChangeOrientation(float angle);
    }
}
