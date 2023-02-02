using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPlunder_V1.Design.Room_6
{
    public class Room6 : Room
    {
        public Room6() 
            : base( new Question("A lion's roar can be heard up to eight kilometres away", "True"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to room 6");
        }
    }
}
