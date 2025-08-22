using Day6OOP.Abstraction;
using Day6OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP
{
    /// <summary>
    /// Test Class : Is a Concrete Class that implements the Shape abstract class and IType interface.
    /// what to access from it? -- chack main
    /// </summary>
    class Test : Shape,IType
    {
        public Test() : base(0, 0)
        {

        }
        public override int Perimeter { get; }
        public override decimal CalcArea()
        {
            return 0;
        }
        public int MyProperty { get; } 

        public void MyMethod()
        {
            Console.WriteLine("Hello From MyMethod in the test class");
        }

        public void TestMethod()
        {
            Console.WriteLine("Hello From Test");
        }

    }
}
