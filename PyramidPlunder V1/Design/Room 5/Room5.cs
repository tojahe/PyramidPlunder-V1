using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPlunder_V1.Design.Room_5
{
    public class Room5 : Room
    {
        public Room5() 
            : base(new Question("In a guess game , five friends had to guess the exact numbers of balls in a box.\r\nFriends guessed as 31 , 35, 39 , 49 , 37, but none of guess was right. The guesses were off by 1, 9, 5, 3, and 9 (in a random order).\r\nCan you determine the number of balls in a box ?\r\n", "40"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to room 5");
        }
    }
}
