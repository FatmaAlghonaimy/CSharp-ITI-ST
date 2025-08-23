using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7OOP.Partial
{
    //must have the same namespace and class name and access modifier
    public partial class Employee
    {
       public partial void print()
       {
           Console.WriteLine("Hello From Second Partial Class");
       }
    
    }
}
