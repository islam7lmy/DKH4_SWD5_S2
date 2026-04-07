using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Abstraction
{

    interface IShape
    {
        /// property Signture
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        /// abstract method => a method that is declared in an abstract class but 
        /// does not have an implementation.
        /// virtual method => a method that is declared in a base class and can be overridden in a derived class.
        public double Perimeter();
        public double CalcArea();

        public void test()
        {
            Console.WriteLine("Hello i am  default implment method");
        }
    }

    /// just inhert form it ==> concept Binding
    abstract class Shape
    {
        ///property implementation => property with implementation
        public double Dim01 { get; protected set; }
        public double Dim02 { get; protected set; }

        //not implmented property just signture
        public abstract double Perimeter { get; }

        /// abstract method => a method that is declared in an abstract class but 
        /// does not have an implementation.
        /// virtual method => a method that is declared in a base class and can be overridden in a derived class.
        ///public abstract double Perimeter();
        public abstract double CalcArea();

        public void test()
        {
            Console.WriteLine("Hello i am  default implment method");
        }
    }

    abstract class RectShape : Shape
    {
        public override double CalcArea()
        {
            return Dim01 * Dim02;
        }
    }

    class Squere : RectShape
    {
        public Squere(double Dim)
        {
            Dim01 = Dim02 = Dim;
        }
        //public double Dim01 { get; set; }

        ///dynamic binding only
        //public new double Perimeter() not valid
        //{
        //    return Dim01 * 4;
        //}

        public override double Perimeter { get { return Dim01 * 4; } }
        //public override double Perimeter()
        //{
        //    return Dim01 * 4;
        //}

        //public override double CalcArea()
        //{
        //    return Dim01 * Dim01;
        //}
    }

    class Rectangle : RectShape
    {
        public Rectangle(double dim01 , double dim02)
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }
        public override double Perimeter { get { return (Dim01 + Dim02) * 2; } }
        //public override double Perimeter()
        //{
        //    return (Dim01 + Dim02) * 2;
        //}

        //public override double CalcArea()
        //{
        //    return Dim01 * Dim02;
        //}
    }

    class Circle : Shape
    {
        public Circle(double Reduies)
        {
            Dim01 = Dim02 = Reduies;
        }
        public override double Perimeter { get { return 2 * 3.14 * Dim01; } }
        //public override double Perimeter()
        //{
        //    return 2 * 3.14 * Dim01;
        //}

        public override double CalcArea()
        {
            return 3.14 * Dim01 * Dim01;
        }
    }
}
