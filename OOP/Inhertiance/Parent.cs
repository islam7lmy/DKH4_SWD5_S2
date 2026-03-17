using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    //[baseclass]
    internal class Parent
    {
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        //backing field
        public int X { get; set; }
        public int Y { get; set; }

        ///clr will create parameter less constructor 



        ///Compile-Time Polymorphism (Static)
        ///Method overloading
        ///same method name => number of parameters
        ///same method name => datatype of parameters
        public Parent()
        {

        }
        public Parent(int _x)
        {

        }
        public Parent(double _x)
        {

        }
        public Parent(int _x, int _y)
        {
            X = _x;
            Y = _y;
            Console.WriteLine("Constructor of Parent");
        }
        public Parent(int _x, int _y, int _z)
        {
        }

        public int product(int a, int b)
        {
            return a * b;
        }
        //public double Add(int a, int b) //not overloading
        //{
        //    return a * b;
        //}
        public int product(int a, int b, int c)
        {
            return a * b * c;
        }

        ///Runtime Polymorphism (Dynamic)
        public virtual int sum()
        {
            return X + Y;
        }
        public override string ToString()
        {
            return $"({X} , {Y})";
        }
    }
}
