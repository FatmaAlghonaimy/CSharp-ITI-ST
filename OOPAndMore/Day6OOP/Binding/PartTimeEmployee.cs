using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Binding
{
    class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }

        public PartTimeEmployee(int id, string? name, int age, int Count, decimal hourRate) : base(id, name, age)
        {
            CountOfHours = Count;
            HourRate = hourRate;

        }
        #region Methods
        public new void GetEmployeeType()
        {
            Console.WriteLine("I'm PartTime Employee");
        }
        public override void GetEmployeeData()
        {
            base.GetEmployeeData();
            Console.WriteLine($"HourRate:{HourRate}, Count :{CountOfHours}");
        }
        #endregion
    }
}
