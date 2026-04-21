using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Sealed
{
    internal class Parent
    {
        private int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value - 1000; }
        }

        public virtual void print()
        {
            Console.WriteLine("hello Parent");
        }
    }

    class child02 : Parent
    {
        public override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value - 1500; }
        }

        public override void print()
        {
            Console.WriteLine("hello child");
        }
    }

    class child : Parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value - 1500; }
        }

        public sealed override void print()
        {
            Console.WriteLine("hello child");
        }
    }

    sealed class GrandChild : child
    {
        public GrandChild()
        {
            Salary = 10000;
            print();
        }

        void test()
        {
            Salary = 1024545;
            print();
        }

        //satatic binding
        public new void print()
        {
            Console.WriteLine("hello Parent");
        }

        //public override int Salary { get => base.Salary; set => base.Salary = value; }
        //public override void print()
        //{
        //    base.print();
        //}
    }

    //class GrandGrandChild : GrandChild //sealed
    //{

    //}
}
