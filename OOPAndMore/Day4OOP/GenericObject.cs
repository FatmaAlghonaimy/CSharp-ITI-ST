using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4OOP
{
    class GenericObject
    {
        //public void Print<T>(T item)
        //{
        //    Console.WriteLine(item);
        //}
        public void Print(object item) //boxing 
        {
            Console.WriteLine(item);
        }
        public void TestPrint()
        {
            Print(10); // T is int
            //Print<string>("Hello"); // T is string
            Print(3.14); // T is double
        }
    }

}
