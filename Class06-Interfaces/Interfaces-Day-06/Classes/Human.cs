using Interfaces_Day_06.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Day_06.Classes
{
    public class Human : ISpeak
    {
        public void Live()
        {
            Console.WriteLine("I am living my life :)");
        }

        public virtual void Speak()
        {
            Console.WriteLine("I am eager to live my life to the fullest");
        }

    }
}
