using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Interfaces.Example02
{
    class Airplane : Vehicle, IMoveOnAir, IMoveOnGround
    {
        //implicity implememnted 
        //must be public
        public void Backward()
        {
            Console.WriteLine("Move Backward");
        }

        //void IMoveOnGround.Backward()
        //{
        //    throw new NotImplementedException();
        //}

        // by defualt private and cant be otherwise
        // Methods That Implemented Explicitly can not Be anything but private
        void IMoveOnAir.Forward()
        {
            Console.WriteLine("Move Forward on Air");
        }

        void IMoveOnGround.Forward()
        {
            Console.WriteLine("Move Forward on Ground");
        }

        void IMoveOnAir.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveOnGround.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveOnAir.Right()
        {
            throw new NotImplementedException();
        }

        void IMoveOnGround.Right()
        {
            throw new NotImplementedException();
        }
    }
}
