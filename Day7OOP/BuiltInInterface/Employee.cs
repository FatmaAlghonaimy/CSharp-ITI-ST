using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7OOP.BuiltInInterface
{
    class Employee: ICloneable, IComparable<Employee>
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        #endregion

        #region Constructors
        //hide default ctor
        public Employee()
        {
            
        }
        //only one per class 
        //Copy Constructor
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary:c}";
        }
        #endregion

        #region Interfaces Implementation
        public object Clone()
        {
            //return new Employee
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary
            //};
            return new Employee(this);
        }
        public int CompareTo(Employee? other)
        {
            // +ve : fist > second this.Salary > other.Salary
            // -ve : fist > second
            // 0 : fist > second

            //if (this.Salary > other?.Salary)
            //{
            //    return 1;
            //}
            //else if (this.Salary < other?.Salary)
            //{
            //    return -1;
            //}
            //return 0;
            //return this.Salary.CompareTo(other?.Salary); //deciamal // asc
            return (other?.Salary.CompareTo(this.Salary)) ?? 0 ; //deciamal // c
        }
        #endregion
    }
}
