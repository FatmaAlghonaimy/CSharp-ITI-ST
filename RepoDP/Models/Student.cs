using RepoDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDP.Entity
{
    class Student:BaseEntity
    {
        public string? Name { get; set; }
        public int? DeptId { get; set; }

        public Student(int id, string? name, int? deptID): base(id)
        {
            Name = name;
            DeptId = deptID;
       
        }
        public Student(Student std) : this(std.Id, std.Name, std.DeptId)
        { }
        public override string ToString()
        {
            return $"Student: {{ID:{Id}, Name:{Name}, DeptId:{DeptId}}}";
        }
    }
}
