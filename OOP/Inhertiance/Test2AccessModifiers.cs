using Commen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP.Inhertiance
{
    internal class Test2AccessModifiers: TestAccessModifiers
    {
        public void tryAccessModifiers()
        {
            //test = 1; //private
            //test1 = 2;  //private protected
            test2 = 3;  //protected
            //test3 = 4;  //internal
            test4 = 5;  //internal protected
            test5 = 6;  //public
        }
    }

    internal class proplus
    {
        public void testcode()
        {
            TestAccessModifiers2 testAccessModifiers2 = new TestAccessModifiers2();

            //testAccessModifiers2.test = 1; //private
            //testAccessModifiers2.test1 = 2; //private protected 
            //testAccessModifiers2.test2 = 3; //protected
            //testAccessModifiers2.test3 = 4; //internal
            //testAccessModifiers2.test4 = 5; //internal protected
            testAccessModifiers2.test5 = 6;


            Test2AccessModifiers test2AccessModifiers = new Test2AccessModifiers();
            //testAccessModifiers2.test = 1; //private
            //testAccessModifiers2.test1 = 2; //private protected 
            //testAccessModifiers2.test2 = 3; //protected
            //testAccessModifiers2.test3 = 4; //internal
            //testAccessModifiers2.test4 = 5; //internal protected
            testAccessModifiers2.test5 = 6;
        }
    }
}
