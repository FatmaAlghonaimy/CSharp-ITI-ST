using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Override
{
    class ClassA
    {
        public int A { get; set; }

        public ClassA(int a) { 
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine("This is MyFun01 and Im Base (ClassA)");
        }
        public virtual void MyFun02() //abstract aw override aw virtual
        {
            Console.WriteLine($"This is MyFun02 and A :{A}");
        }

    }
}
