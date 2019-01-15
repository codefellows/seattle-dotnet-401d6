using Interfaces_Day_06.Classes;
using Interfaces_Day_06.Interfaces;
using System;

namespace Interfaces_Day_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Robot r2d2 = new Robot();
            Student amanda = new Student();

            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            Student student = new Student();
            IDrive driver = student;
            IDrive driver2 = new Student();

            amanda.Drive(bicycle);

            //// Casting
            //ISpeak iSpeak = r2d2;

            //iSpeak.Speak(); //human.Speak();

            ISpeak[] arrayOfSpeakers = { human, r2d2, amanda};
            Speech(arrayOfSpeakers);
        }

        // ...
         static void Speech(ISpeak[] speakers)
        {
            foreach(ISpeak speaker in speakers)
            {
                speaker.Speak();
            }
        }
    }
}
