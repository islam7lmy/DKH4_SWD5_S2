using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    /// contract
    internal interface IMyType
    {
        /// What You Can Write Inside The Interface?
        /// 1. Method Signature
        /// 2. Property Signature
        /// 3. Event Signature
        /// 4. Indexer Signature
        /// 5. Default Implementation (C# 8.0 +)

        /// Default Access Modifier Inside The Interface is Public
        /// Private Access Modifier Is Not Allowed Inside The Interface

        /// Property Signture
        int Salary { get; set; }

        /// Method Signture
        void MyFunc();

        // 3. Default Implmented Method => C# 8.0 Feature (.NET Core 3.1 [2019])
        void Print() /// dynamic binding
        {
            Console.WriteLine("Hello Default Implmented Method From InterFace");
        }
    }

    class MyType : IMyType  /// implmention
    {
        public int Age { get; set; }

        ///clr will generate backing field [hiden private field]
        ///property
        public int Salary { get; set; }

        ///method
        public void MyFunc()
        {
            Console.WriteLine("Hello");
        }

        public void MyFunc02()
        {
            Console.WriteLine("hi i am child method");
        }

        public virtual void Print()
        {
            Console.WriteLine("Hello Default Implmented Method From Implmented Class");
        }
    }
    class MyTypeChildv2 : MyType
    {
        public override void Print() ///dynamic binded
        {
            Console.WriteLine("Hello Default Implmented Method From Implmented Class Child");
        }
    }
    class MyTypeChild : MyType
    {
        public new void Print() ///static binded
        {
            Console.WriteLine("Hello Default Implmented Method From Implmented Class Child");
        }
    }


    class MyTypeV2 : IMyType
    {

        private int salary;
        public int Salary { get { return salary - 1000; } set { salary = value <= 2000 ? 2000 : value; } }

        public void MyFunc()
        {
            Console.WriteLine("Hello V2");
        }
    }

    class MyTypeV3 
    {
        public int Salary { get; set; }

        ///method
        public void MyFunc()
        {
            Console.WriteLine("Hello");
        }
    }
}
