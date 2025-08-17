using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    // struct enum class interface record
    // public , internal
    // default internal
    public struct TypeB
    {
        /// private public internal 
        ///int a; //private by default
        /// <summary>
        /// private public internal 
        /// </summary>
        public TypeB()
        {
            TypeA typeA = new TypeA();
            //typeA.x = 1;// Invalid  // X is private [ assessable within its Scope Only ]
            typeA.y = 1; // Valid // Y is Internal [ assessable within its Scope and in Same Project Only] 
            typeA.z = 1; // Valid // Z is Public [ assessable within its Scope and in Same Project ]
        }

    }
}

