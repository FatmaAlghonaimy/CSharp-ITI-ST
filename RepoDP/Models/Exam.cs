using RepoDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDP.Entity
{
    class Exam : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }

        public Exam(int id,  string? title, string? description) : base(id)
        {
            Title = title;
            Description = description;
        }

    }
}
