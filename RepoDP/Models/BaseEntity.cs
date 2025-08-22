using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoDP.Models
{
    abstract class BaseEntity
    {
        public int Id;
        protected BaseEntity(int id)
        {
            Id = id;
        }
        protected BaseEntity(BaseEntity entity) : this(entity.Id) { }
    }
}
