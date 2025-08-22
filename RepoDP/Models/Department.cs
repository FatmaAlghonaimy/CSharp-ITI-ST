using RepoDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDP.Entity
{
    class Department:BaseEntity
    {
        public string? Name { get; set; }
        public Department(int id, string? name):base(id)
        {
            Name = name;
        }
        public Department(Department dept) : this(dept.Id, dept.Name)
        { }
        public override string ToString()
        {
            return $"Dept: {{ID:{Id}, Name:{Name}}}";
        }
    }
}
