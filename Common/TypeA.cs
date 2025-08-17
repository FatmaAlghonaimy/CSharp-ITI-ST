using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public struct TypeA
    {
        private int x; 
        internal int y;
        public int z;

        public TypeA()
        {
            x = 1; // X is private [ assessable within its Scope ]
            y = 2; // Y is Internal [ assessable within its Scope ] 
            z = 3; // Z is Public [ assessable within its Scope ]
        }
    }
}
