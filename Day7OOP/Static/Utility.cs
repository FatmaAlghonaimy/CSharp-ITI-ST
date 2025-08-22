using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7OOP.Static
{
    //cant inherit from --> Extension method 
    static class Utility
    {
        //oject member
        //private const double pi = 3.14;
        private static readonly double pi; //const

        //readonly property
        public static double PI { //readonly
            get
            {
                return pi;
            }
        }

        static Utility()  //call  one time
        {
            Console.WriteLine("Static Ctor");
            pi = 15.5; //static readonly property
        }
        //public Utility()
        //{


        //  pi = 3.14;
        //    //PI = 1.5;
        //    // PI = Math.PI;
        //    //pi = 1.5;
        //}

        // class member
        public static double MeterToCM(double num)
        {
            return num * 100;
        }
        //public void Test()
        //{
        //    //pi = 3.14;
        //}

        // class member == static, const
        // static , const, static readonly
        public static double CalcCircleArea(double rad)
        {
            //return Math.PI * rad * rad;
            return rad * rad * pi;

        }

    }
}
