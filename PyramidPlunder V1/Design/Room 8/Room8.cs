using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPlunder_V1.Design.Room_8
{
    public class Room8 : Room
    {
        public Room8()
            : base(new Question("A man is climbing up a mountain which is inclined. He has to travel 100 km to reach the top of the mountain. Every day He climbs up 2 km forward in the day time. Exhausted, he then takes rest there at night time. At night, while he is asleep, he slips down 1 km backwards because the mountain is inclined. Then how many days does it take him to reach the mountain top? ", "99"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to room 8");
        }
    }
}
