using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Point
    {
        /// What You Can Write Inside The Class Or Struct?
        /// 1. Fields (Attributes)
        /// 2. Methods 
        /// 3. Constructors
        /// 4. Properties
        /// 5. Events
        /// 6. Indexers
    
        public int X; 
        public int Y;

        /// clr will always Generate Paramaterless Constructor
        //public Point()
        //{
        //    X = Y = default;
        //}
        /// to initialize all attributes with default value based on it's daatatype
        /// You Can't Create User-Defined Parameterless Constructor Inside Struct (Except C# 10.0)

        public Point(int _x , int _y)
        {
            X = _x;
            Y = _y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }
}
