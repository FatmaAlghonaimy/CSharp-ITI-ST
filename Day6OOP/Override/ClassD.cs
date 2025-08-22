using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Override
{
    class ClassD : ClassC
    {
        public int D { get; set; }
        public ClassD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }
        public new void MyFun01()
        {
            Console.WriteLine("This is MyFun01 and Im Child (ClassD)");
        }
        public override void MyFun02() //try new
        {
            base.MyFun02();
            Console.WriteLine($"D:{D}");
        }
    }
}
