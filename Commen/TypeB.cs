using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commen
{
    internal class TypeB
    {
        TypeA a = new TypeA();
        TypeC c = new TypeC();
        public TypeB()
        {
            //a.x = 0; // invalid
            a.y = 1;
            a.z = 2;

            //c.x = 3; //invalid
            c.y = 3;
            c.z = 4;
        }
    }
}
