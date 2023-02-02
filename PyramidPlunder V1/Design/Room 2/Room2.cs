using System;

namespace PyramidPlunder_V1.Design.Room_2
{
    public class Room2 : Room
    {
        public Room2() 
            : base(new Question("What is the name of the fastest land animal?", "Cheetah"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("welcome to room 2");
        }
    }
}
