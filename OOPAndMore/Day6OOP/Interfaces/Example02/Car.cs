using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Interfaces.Example02
{
    class Car : Vehicle, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Move Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Move Forward");
        }

        public void Left()
        {
            Console.WriteLine("Move Left");
        }

        public void Right()
        {
            Console.WriteLine("Move Right");
        }
    }
}
