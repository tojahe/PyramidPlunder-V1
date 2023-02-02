using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPlunder_V1.Design.Room_9
{
    public class Room9 : Room
    {
        public Room9()
            : base(new Question("What is it that no one wants, but no one wants to lose?", "lawsuit"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to room 9");
        }
    }
}
