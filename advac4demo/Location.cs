using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advac4demo
{
    internal struct Location
    {
        public int X ;
        public int Y;
        public int Z;

        public override string ToString()
        {
            return $"({X} . {Y}. {Z})";
             
        }
    }
}
