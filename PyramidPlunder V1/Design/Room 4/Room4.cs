using System;

namespace PyramidPlunder_V1.Design.Room_4
{
    public class Room4 : Room
    {
        public Room4()
            : base(new Question("I’m the rare case when today comes before yesterday. What am I?", "dictionary"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to room 4");
        }
    }
}
