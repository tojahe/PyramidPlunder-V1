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
            Welcome.WelcomeToPyramidPlunder();

            Room room1 = new Room1();
            GoThroughRoom(room1);

            Room room2 = new Room2();
            GoThroughRoom(room2);
            

            Room3.WelcomeToRoom3();
            Room4.WelcomeToRoom4();
            Room5.WelcomeToRoom5();
            Room6.WelcomeToRoom6();
            Room7.WelcomeToRoom7();
            Room8.WelcomeToRoom8();
            Room9.WelcomeToRoom9();
            Room10.WelcomeToRoom10();



            Console.ReadLine();

        }

        private static void GoThroughRoom(Room room)
        {
            room.Welcome();
            room.AskQuestion();
            room.CheckAnswer();
        }
    }
}
