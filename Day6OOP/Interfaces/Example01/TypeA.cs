using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6OOP.Interfaces.Example01
{
    class TypeA:ISeries
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current+=2;
        }

    }
}
