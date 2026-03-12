using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    public struct TypeC
    {
        /// Allowed Access Modifiers Inside The Struct
        /// 1. private [default]
        /// 2. internal
        /// 3. public

        int x; //private
        internal int y;  // in same assembly
        public int z; // all
    }
}
