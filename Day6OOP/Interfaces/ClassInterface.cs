using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Interfaces
{
    class ClassInterface : IType
    {
        // must be public even if its originaly internal
        public int MyProperty { get;  set; } // generates backing field  // authomatic property

        public void MyMethod()
        {
            Console.WriteLine("Hello from ClassInterface");
        }
        public void MyMethod03()
        {
            Console.WriteLine("Defualt implemented mehtod");
        }

    }
}
