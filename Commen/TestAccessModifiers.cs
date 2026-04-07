using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Commen
{
    public class TestAccessModifiers
    {
        private int test { get; set; }
        private protected int test1 { get; set; }
        protected int test2 { get; set; }
        internal int test3 { get; set; }
        internal protected int test4 { get; set; }
        public int test5 { get; set; }
    }

    public class TestAccessModifiers2 : TestAccessModifiers
    {
        public void tryAccessModifiers()
        {
            //test = 1; //private
            test1 = 2;  //private protected
            test2 = 3;  //protected
            test3 = 4;  //internal
            test4 = 5;  //internal protected
            test5 = 6;  //public
        }
    }

    public class pro
    {
        public void testcode()
        {
            TestAccessModifiers2 testAccessModifiers2 = new TestAccessModifiers2();

            //testAccessModifiers2.test = 1; //private
            //testAccessModifiers2.test1 = 2; //private protected 
            //testAccessModifiers2.test2 = 3; //protected
            testAccessModifiers2.test3 = 4;
            testAccessModifiers2.test4 = 5;
            testAccessModifiers2.test5 = 6;
        }
    }


    ///private => only in current class => [انا بس]
    ///private protected => current class + derived class  [in same assembly] => [ولادى جوه الشركه بس]
    ///protected => current class + derived class  [in any assembly] => [انا و اولادى]
    ///internal => any class in same assembly => [شركتى بس]
    ///protected internal =>  any class in same assembly + current class + derived class  [in any assembly] => [ولادى + اى حد فى الشركة]
    ///public => in any where => [كل الناس]
}
