using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Override
{
    class ClassB : ClassA
    {
        public int B { get; set; }

        public ClassB(int a, int b) : base(a)
        {
            B = b;
        }
        // Using Keyword New To Hide Inherited Member TypeA.MyFun01 [Masking - Shadowing - New Version]	
        public new void MyFun01()  // new one 
        {
            Console.WriteLine("This is MyFun01 from (ClassB)");
        }
        public override void MyFun02() //old one ++
        {
            base.MyFun02();  //can use base. as long as i inherited no matter what type of polymorohism
            Console.Write($" B:{B}");
        }
    }
}
