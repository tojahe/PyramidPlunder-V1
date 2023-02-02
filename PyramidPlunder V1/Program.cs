using System;
using PyramidPlunder_V1.Design;
using PyramidPlunder_V1.Design.Room_1;
using PyramidPlunder_V1.Design.Room_2;
using PyramidPlunder_V1.Design.Room_3;
using PyramidPlunder_V1.Design.Room_4;
using PyramidPlunder_V1.Design.Room_5;
using PyramidPlunder_V1.Design.Room_6;
using PyramidPlunder_V1.Design.Room_7;
using PyramidPlunder_V1.Design.Room_8;
using PyramidPlunder_V1.Design.Room_9;
using PyramidPlunder_V1.Design.Room_Final;

namespace PyramidPlunder_V1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {

            
            Console.SetWindowSize(150, 50);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Welcome.WelcomeToPyramidPlunder();

            Room room1 = new Room1();
            GoThroughRoom(room1);

            Room room2 = new Room2();
            GoThroughRoom(room2);

            Room room3 = new Room3();
            GoThroughRoom(room3);

            Room room4 = new Room4();
            GoThroughRoom(room4);

            Room room5 = new Room5();
            GoThroughRoom(room5);

            Room room6 = new Room6();
            GoThroughRoom(room6);

            Room room7 = new Room7();
            GoThroughRoom(room7);

            Room room8 = new Room8();
            GoThroughRoom(room8);

            Room room9 = new Room9();
            GoThroughRoom(room9);


            Room10.WelcomeToRoom10();



            Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            }

        private static void GoThroughRoom(Room room)
        {
            room.Welcome();
            room.AskQuestion();
            room.CheckAnswer();

        }
    }
}
