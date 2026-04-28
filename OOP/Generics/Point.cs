using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Generics
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string test { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public override bool Equals(object? obj)
        {
            //this keyword => object that call method
            Point other = (Point)obj; //explicit casting [unsafe caste]
            if (this.X == other.X)
                return this.Y == other.Y;
            else return false;
        }

        public override int GetHashCode()
        {
            ///Generics.Point p1 = new Generics.Point(1, 0); // old way => 1
            ///Generics.Point p2 = new Generics.Point(0, 1); // old way => 1
            ///if two things are equal (Equals(..) == true) then they must return the same value of GetHashCode()
            ///if the GetHashCode is equal, it is not necessary for them to be the same; 
            ///this collision, and equals will be called to see if it is a real equality or not.

            //return X.GetHashCode() + Y.GetHashCode();

            ///c# 8.0
            return HashCode.Combine(X, Y);
        }

    }
}
