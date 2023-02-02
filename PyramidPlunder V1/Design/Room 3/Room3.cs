using System;

namespace PyramidPlunder_V1.Design.Room_3
{
    public class Room3 : Room
    {
        public Room3() 
            : base(new Question("True or False: Carrots help you see in the dark", "False"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to room 3");
        }
    }
}
