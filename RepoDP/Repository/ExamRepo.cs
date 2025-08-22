using RepoDP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDP.Repository
{
    class ExamRepo:GenericRepo<Exam>
    {
        // var is not not a datatype
        // cant have fields or properties with var
        // var x = 10; // invalid
        // public var MyProperty { get; set; } //invalid
    }
}
