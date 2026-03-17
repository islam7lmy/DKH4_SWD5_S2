using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inhertiance
{
    //[derived class]
    internal class Child : Parent // Inhertiance
    {
        public int Z { get; set; }

        ///clr will create parameter less constructor 
        ///by chain base parameter less constructor
        //public Child() : base()
        //{

        //}

        //chaning on parent userdefiend constructor
        public Child(int _x, int _y, int _z) : base(_x, _y)
        {
            //X = _x;
            //Y = _y;
            Z = _z;
            Console.WriteLine("Constructor of child");
        }

        //overriding using :new key word [hiding , mask]
        public new int product(int a, int b) 
        {
            return a * b * 10;
        }

        public override int sum()
        {
            return base.sum() +  Z;
        }

        public override string ToString()
        {
            return base.ToString() + $" {Z}";
        }

    }
}
