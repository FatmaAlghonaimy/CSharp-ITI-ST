using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7OOP.Static
{
    //can't inherit from it --> Extension method 
    //static class must contain static members only, or const members
    static class Utility
    {
        #region Fields
        //private const double pi = 3.14; //must be initialized at declaration time and can't be changed anywhere else;
        private static readonly double pi;
        #endregion

        #region Properties
        //readonly property
        public static double PI { //readonly
            get
            {
                return pi;
            }
        }
        #endregion

        #region Constructors
        //static constructor
        static Utility()  //called one time before any other member or ctor
        {
            //Used to initialize static readonly fields or perform other setup tasks that only need to occur once.
            Console.WriteLine("Static Ctor");
            pi = 15.5; //static readonly property can only be initialized here
        }
        //public Utility()
        //{
        //  pi = 3.14;
        //  //pi = 1.5;
        //}
        #endregion

        #region Class member Methods
        ///static methods can access only static members, const, static readonly members
        public static double MeterToCM(double num)
        {
            return num * 100;
        }
        public static double CalcCircleArea(double rad)
        {
            //return Math.PI * rad * rad;
            return rad * rad * pi; //can't use PI here in case its not a static or const member
        }
        #endregion

        #region Object member Methods
        //can access static or non static members
        //public void Test()
        //{
        //    //pi = 3.14; 
        //}
        #endregion
    }
}
