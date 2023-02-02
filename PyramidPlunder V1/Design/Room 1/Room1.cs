using System;

namespace PyramidPlunder_V1.Design.Room_1
{
    public class Room1
    {

        public static void WelcomeToRoom1()
        {
            Console.WriteLine("");
            Console.WriteLine("As soon as you sign your name on the scroll the stone door slams closed behind you.");
            Console.WriteLine("All of the torches that lit up the room are suddenly extinguished ");
            Console.WriteLine(
                "a pre-lit candle and a hieroglyph translation book appears in front, you pick them up..");
            Console.WriteLine("");
            Console.WriteLine(@"         /\");
            Console.WriteLine(@"        /  \");
            Console.WriteLine(@"        \/\/");
            Console.WriteLine(@"         |");
            Console.WriteLine(@"       !~~-!");
            Console.WriteLine(@"       |` ,!");
            Console.WriteLine(@"       |'` |                  ______ ______");
            Console.WriteLine(@"       |   |                _/      Y      \_");
            Console.WriteLine(@"       |   |               // ~~ ~~ | ~~ ~  \\ ");
            Console.WriteLine(@"       |   |              // ~ ~ ~~ | ~~~ ~~ \\ ");
            Console.WriteLine(@"       |   |             //________.|.________\\ ");
            Console.WriteLine(@"       |   |             `----------`-'----------'");
            Console.WriteLine(@"_______|___|_______");
            Console.WriteLine(@"\                 /");
            Console.WriteLine(@" \_______________/");
            Console.WriteLine("");
            Console.WriteLine(
                "You walk along the corridor and enter the first room and approach the hieroglyphics on the closed door..");
            Console.WriteLine("");
            Console.WriteLine("Using the translation book you manage to de-cypher the hieroglyphics... they read: ");
            
            Console.WriteLine(Math1.Math1Question);
            Math1.Math1UserAnswer = Console.ReadLine();
            string answer = Console.ReadLine();
            Math1.Math1UserAnswer = answer;

            if (Math1.Math1UserAnswer == Math1.Math1Answer)
                Console.WriteLine("You answered correctly. The stone door opens..");

            if (Math1.Math1UserAnswer != Math1.Math1Answer)
                Console.WriteLine("Wrong answer! You triggered a booby trap and fall to your death.");
            
                
            


            
        }



    }
}

