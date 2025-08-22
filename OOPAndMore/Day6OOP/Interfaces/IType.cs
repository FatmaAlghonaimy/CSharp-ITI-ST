using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Interfaces
{
    internal interface IType
    {
        // Interface : Is a Contract that defines a set of members that a class must implement.
        // interfaces can't have fields, constructors, or static members.
        //default Access modifier is Public
        //1 - 2 - can be internal but must be implemented as public , cant be private

        // 1- Properties Signatures
        internal int MyProperty { get;} //no backing field

        // 2- Method Signatures
        public void MyMethod();

        // 3- Default Method Implementations (C# 8.0 and later)
        //can be private
        public void MyMethod02(string name)
        {
            Console.WriteLine("Defualt implemented mehtod");
        }
    }
}
