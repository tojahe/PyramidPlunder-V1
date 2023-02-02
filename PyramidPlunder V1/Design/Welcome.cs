using System;


namespace PyramidPlunder_V1.Design
{
    public class Welcome
    {
        
        public static void WelcomeToPyramidPlunder()
        {
            string userName;
            Console.WriteLine("Welcome to....");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(@"           ______                          _     _  ______ _                 _           ");
            Console.WriteLine(@"           | ___ \                        (_)   | | | ___ \ |               | |          ");
            Console.WriteLine(@"           | |_/ /   _ _ __ __ _ _ __ ___  _  __| | | |_/ / |_   _ _ __   __| | ___ _ __ ");
            Console.WriteLine(@"           |  __/ | | | '__/ _` | '_ ` _ \| |/ _` | |  __/| | | | | '_ \ / _` |/ _ \ '__|");
            Console.WriteLine(@"           | |  | |_| | | | (_| | | | | | | | (_| | | |   | | |_| | | | | (_| |  __/ |   ");
            Console.WriteLine(@"           \_|   \__, |_|  \__,_|_| |_| |_|_|\__,_| \_|   |_|\__,_|_| |_|\__,_|\___|_|   ");
            Console.WriteLine(@"                  __/ |                                                                  ");
            Console.WriteLine(@"                 |___/                                                                   ");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine("How the game works:");
            Console.WriteLine(" ");
            Console.WriteLine("You will be asked a series of questions ranging in difficulties, the answers for these will");
            Console.WriteLine("one word only e.g. \"True\" or \"False\".  ");
            Console.WriteLine("If you answer one question wrong you will trigger a booby trap and fall to your death.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("You wake up in a daze in the middle of the desert with a bump on your head.. ");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("In the distance you see a giant towering pyramid and start walking towards it..");
            Console.WriteLine(@"          ,/`. ");
            Console.WriteLine(@"        ,'/ __`.");
            Console.WriteLine(@"      ,'_/_  _ _`.");
            Console.WriteLine(@"    ,'__/_ ___ _  `.");
            Console.WriteLine(@"  ,'_  /___ __ _ __ `.");
            Console.WriteLine(@" '-.._/___.-||| -.-.__`.");
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.WriteLine("You walk up to the pyramid and the huge stone door opens automatically");
            Console.WriteLine("a figure emerges from the dark inner hall, you quickly realise the figure that stands in front of you is Anubis");
            Console.WriteLine("He hands you a scroll, you unravel it and begin to read....");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("here lays my pyramid, if you can manage to get through all 10 rooms you will make it to the great chamber that holds all of my treasures. ");
            Console.WriteLine("");
            Console.WriteLine("The pyramid has only 1 path, any wrong answers will trigger the booby trap and lead you to your death.If you would like to attempt this challenge please sign your life away here:");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Please sign this scroll below if you wish to continue..");
            Console.WriteLine("");
            userName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Welcome {userName}. Good luck.");
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }

    }
}
