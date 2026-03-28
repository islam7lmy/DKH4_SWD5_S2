using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    // base class
    class TypeA
    {
        public int A { get; set; }
        public TypeA(int _A)
        {
            A = _A;
        }

        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA: A = {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }

        // 1. Apply Method Overriding: Using "new" Keyword
        // Static Binded Method
        public new void MyFun01()
        {
            //base.MyFun01(); //calling
            Console.WriteLine("I am Base [Child]");
        }

        // 2. Apply Method Overriding: Using "override" Keyword
        // But Before Anything, the Method that will be Overrided Using "override" Keyword
        // Must be Non-Private Virtual
        // Dynamic Binded Method
        public override void MyFun02()
        {
            //base.MyFun02(); //rewrite
            Console.WriteLine($"TypeB: A = {A} , B = {B}");
        }

        //public void MyFun03()
        //{
        //    Console.WriteLine("test");
        //}
    }

    class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int _A, int _B , int _C) : base(_A,_B)
        {
            C = _C;
        }

        public new void MyFun01()
        {
            //base.MyFun01(); //calling
            Console.WriteLine("I am [Grand Child]");
        }

        public override void MyFun02()
        {
            //base.MyFun02(); //rewrite
            Console.WriteLine($"TypeC: A = {A} , B = {B} , C = {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int _A, int _B, int _C, int _D) : base(_A, _B,_C)
        {
            D = _D;
        }

        /// static binding
        public new virtual void MyFun02()
        {
            //base.MyFun02(); //rewrite
            Console.WriteLine($"TypeD: A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int _A, int _B, int _C, int _D , int _E) : base(_A, _B, _C,_D)
        {
            E = _E;
        }

        /// dynamic binding
        public override void MyFun02()
        {
            //base.MyFun02(); //rewrite
            Console.WriteLine($"TypeE: A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");
        }
    }
}
