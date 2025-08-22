using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Binding
{
    class FullTimeEmployee:Employee
    {
        public decimal Salary { get; set; }

        public FullTimeEmployee(int id, string? name, int age, decimal salary): base(id, name, age)
        {
            Salary = salary;
 
        }
        #region Methods
        public new void GetEmployeeType()
        {
            Console.WriteLine("Im FullTime Employee");
        }
        public override void GetEmployeeData() 
        {
            base.GetEmployeeData();
            Console.WriteLine($"salary:{Salary}");
        }
        #endregion

    }
}
