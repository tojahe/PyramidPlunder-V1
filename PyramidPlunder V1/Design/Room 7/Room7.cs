using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidPlunder_V1.Design.Room_7
{
    public class Room7 : Room
    {
        public Room7() 
            : base(new Question("How many stars are on the national flag of USA?", "50"))
        {
        }

        public override void Welcome()
        {
            Console.WriteLine("Welcome to room 7 ");
        }
    }
}
