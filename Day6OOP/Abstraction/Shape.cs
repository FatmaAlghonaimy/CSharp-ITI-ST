using Day6OOP.Interfaces;
using Day6OOP.Override;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Abstraction
{

    /// <summary>
    /// Abstract Class : Is a Container For Common Code For Other Classes (concrete + interface behaviour)
    /// Common Code => [Fully Implemented Members , Abstracted Members ]
    /// CANT HAVE ABSTRACT MEMBERS INSIDE NON ABSTRACT CLASS- ONLY ABSTRACT CLASS OR INTERFACE
    /// </summary>

    //can't have abstract fields inside non abstract class
    #region Abstract Classes
    abstract class Shape //: IType  // anstract class can implement interfaces
    {
        #region Properties
        public static int X { get; set; } //can have static members
        public int Dim01 { get; set; }
        public int Dim02 { get; set; }
        #endregion

        #region Constructors

        //signature , Default implemented, fields
        //protected by defualt 3shan m7dsh hywsalo gher inherited class only
        protected Shape(int dim01, int dim02) //public is valid but has no meaninng
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }
        #endregion

        #region abstract members
        public abstract int Perimeter { get; } //readonly //abstract is internally virtual
        abstract public decimal CalcArea();
        #endregion

        #region interface implementation
        //int IType.MyProperty => throw new NotImplementedException();
        //public void MyMethod()
        //{
        //    throw new NotImplementedException();
        //}
        #endregion

    }
    #region Layer For Calc Area
    abstract class Recbase: Shape
    {
        public Recbase(int dim1, int dim2): base(dim1, dim2)
        {

        }
        override public decimal CalcArea()
        {
            return Dim02*Dim01;
        }
    }
    #endregion

    #endregion

    #region Concrete Classes : Differnent Shapes
    class Square : Recbase , I2dDraw, I3dDraw
    {
        public Square(int dim):base(dim,dim )
        { }
        public override int Perimeter
        {
            get { return Dim01 * 4; }
            //set {  Dim01 *= 4;} //invalid -- only valid in interfaces
        }
        //explicit implementation for the 2 methods 
        void I2dDraw.Draw()
        {
            throw new NotImplementedException();
        }
        void I3dDraw.Draw()
        {
            throw new NotImplementedException();
        }
    }

    class Rectangle : Recbase   //this is called implementation inheritance relationship
    {
        public Rectangle(int dim1, int dim2) : base(dim1, dim2)
        { }
        public override int Perimeter
        {
            get { return (Dim01 + Dim02) * 2; }
        }
    }

    class Circle : Shape, I2dDraw
    {
        public Circle(int Radius): base(Radius, Radius)
        {
        }
        public override int Perimeter
        {
            get
            {
                return 2 * (int)Math.PI * Dim01; // 2 * PI * R
                //return (int)(2 * 3.14 * Dim01);
            }
        }
        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim01;
        }
        public void Draw()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region Interfaces
    interface I2dDraw {
        void Draw();
    }

    interface I3dDraw
    {
        void Draw();
    }
    #endregion

}
