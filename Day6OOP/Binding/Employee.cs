using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Binding
{
    class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Ctor
        public Employee(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
            
        }
        #endregion

        #region Methods
        public void GetEmployeeType()
        {
            Console.WriteLine("Im Employee");
        }
        public virtual void GetEmployeeData()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Age:{Age}");
        }
        #endregion
    }
}
