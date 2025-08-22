using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7OOP.Sealed
{
    //internal, public
    class Parent
    {
        private int salary;

        public virtual int Salary { get { return salary; } set { salary = value; } }

        public virtual void MyFun()
        {
            Console.WriteLine("Im Parent");

        }
    }
    class Child : Parent
    {
        public sealed override int Salary { get { return base.Salary; } set { base.Salary = value; } }

        public sealed override void MyFun()
        {
            Console.WriteLine("Im Child");

        }
    }  
    sealed class GrandChild : Child
    {
        // new , property hiding
        public new int Salary { get { return base.Salary; } set { base.Salary = value; } }

        public new void MyFun()
        {
            Console.WriteLine("Im Child");

        }
    }
    //class GrandChild2 : GrandChild
    //{
    //    public new int Salary { get { return base.Salary; } set { base.Salary = value; } }

    //    public new void MyFun()
    //    {
    //        Console.WriteLine("Im Child");

    //    }
    //}
}
