using System;

namespace PyramidPlunder_V1.Design.Room_1
{
    public class Room1 : Room
    {
        public override void Welcome()
        {
            Console.WriteLine("");
            Console.WriteLine("As soon as you sign your name on the scroll the stone door slams closed behind you.");
            Console.WriteLine("All of the torches that lit up the room are suddenly extinguished ");
            Console.WriteLine(
                "a pre-lit candle and a hieroglyph translation book appears in front, you pick them up..");
            Graphic.CandleAndBook();
            Console.WriteLine(
                "You walk along the corridor and enter the first room and approach the hieroglyphics on the closed door..");
            Console.WriteLine("");
            Console.WriteLine("Using the translation book you manage to de-cypher the hieroglyphics... they read: ");
        }

        public Room1() 
            : base(new Question("What are the first 3 digits of Pi?", "3.14")) { }
    }
}

