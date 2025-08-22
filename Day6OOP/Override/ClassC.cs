using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Override
{
    class ClassC: ClassB
    {
        public int C  { get; set; }
        public ClassC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }
        //Static Polymorphism
        public new void MyFun01() 
        {
            Console.WriteLine("This is MyFun01 from (ClassC)");
        }
        public new virtual void MyFun02() //old one ++  // new method
        {
            base.MyFun02();
            Console.Write($" C:{C}");
        } // new level of virtuality 
    }
}
