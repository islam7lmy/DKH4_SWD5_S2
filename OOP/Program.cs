//using Commen;
//using OOP.Inhertiance;
using OOP.PolyMorphism_OverRiding;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            /// Access Modifiers Types
            /// 1. private
            /// 2. private protected
            /// 3. protected
            /// 4. internal
            /// 5. internal protected
            /// 6. public 

            //TypeA a = new TypeA();
            ////a.x = 1; //invalid
            ////a.y = 1; //invalid
            //a.z = 1; //public

            //TypeC c = new TypeC();
            ////c.x = 1;//invalid
            ////c.y = 2; //invalid
            //c.z = 3;//public

            #endregion

            #region Struct
            #region EX01:Point
            //Point P1;
            ///// allocate 8 unitialized bytes in stack

            //P1 = new Point();
            ///// new keyword just for Constructor Selection  that will initialize the attributes of struct

            //P1.X = 10;
            //P1.Y = 10;

            //Console.WriteLine(P1);

            //Console.WriteLine(P1);

            ////P1 = new Point(10, 20);

            ////Console.WriteLine(P1);
            #endregion

            #region EX02:Employee
            //Employee emp = new Employee();
            //emp.SetName("123456789123456789123456789");
            //Console.WriteLine(emp.GetName());
            //emp.Salary = 1000;
            //Console.WriteLine(emp.Salary);
            #endregion

            #region EX03 PhoneBook [indexer]
            //PhoneBook book = new PhoneBook(3);
            //Console.WriteLine(book.Size);
            //book.AddNumber("amr", 123, 0);
            //book.AddNumber("ali", 456, 1);
            //book.AddNumber("aya", 789, 2);

            //book.Size = 5;
            //book.AddNumber("omr", 999, 3);
            //Console.WriteLine(book.Size);

            //book.Size = 4;
            //Console.WriteLine(book.Size);

            //////book.SetNumber("ali", 123);
            //////Console.WriteLine(book.GetNumber("ali"));

            ////book["ali"] = 123;
            ////Console.WriteLine(book["ali"]);

            //for (int i = 0; i < book.Size; i++)
            //{
            //    Console.WriteLine(book[i]);
            //}

            //Console.WriteLine(book[4]);
            #endregion
            #endregion

            #region Class
            #region ex: Car
            //Car c1;
            // declare reference => refer to null => and then will refer on object of type car
            // allocate 4 bytes in stack uninitilized
            // zero bytes has been allocated in heap
            //c1.Id = 10;
            //c1.Model = "oudi";
            //c1.Speed = 10;


            //c1 = new Car();
            //new 
            // 1. Allocate Required Number Of Bytes in HEAP
            // 2. Initialize All Allocated Bytes With Default Value based on Its Datatype
            // 3. Call User-Defined Constructor If Exists
            // 4. Assign The Reference (C1) To Allocated Object
            //Console.WriteLine(c1.Id);

            //Car c1 = new Car();
            //Console.WriteLine(c1);
            //Car c2 = new Car(20);
            //Console.WriteLine(c2);
            //Car c3 = new Car(30 , "audi");
            //Console.WriteLine(c3);
            //Car c4 = new Car(40, "skoda", 160);
            //Console.WriteLine(c4);
            #endregion
            #region ex:Inhertance
            //Parent p1 = new Parent(10);
            //Parent p1 = new Parent(10, 20);
            //Child c1 = new Child(10, 20, 30);
            #endregion
            #region Realtionship between classes
            /// inhertance child is a perant  ,  dog is an anmial
            /// Aggregation has as
            /// 1. composition => room has walls
            /// 2. association => room has chairs
            #endregion
            #region class vs struct
            /// 1. referance type           |   1. value type
            /// 2. support all oop pailers  |   2. support encabsulation & overriding
            /// 3. all acces modifiers      |   3. privat , public , internal
            /// 4. if you not create user defined constructor ,compiler wil create paremter less constructor do nothing   |   4. clr create paramter less constructor if you not define it to intial attributes with default values debend on its data type
            #endregion
            #endregion

            #region PolyMorphism
            #region Function OverLoading
            //Sum(10.0, 10);
            #endregion
            #region Function OverRiding
            //TypeA typeA = new TypeA();
            //TypeB B = new TypeB(1,2);
            //B.MyFun01(); // with new keyword
            //B.MyFun02(); // with override keyword
            #endregion
            #endregion

            #region Binding
            #region What is Binding
            ///binding
            /// 1. reference from parent type => object from child type
            //Parent parent = new Child(1,2,3);
            //TypeA A = new TypeB(10, 20);
            //A.A = 10;
            ////A.B = 20; //invalid

            ///// 2.1 static Binding [Early Binding]
            ////// Compiler Will Bind Function Call Based On Reference Type NOT Object Type
            ////// at Compilation Time
            //A.MyFun01(); ///will run parent code

            ///// 2.2 dynamic Binding [Late Binding]
            ////// CLR Will Bind Function Call Based On Object Type NOT Reference Type
            ////// at Runtime.
            //A.MyFun02(); //will run Child Code

            #endregion
            #region Not Binding
            ///animal = dog; //binding
            ///dog =(dog) animal; //not binding

            //Child child = (Child)new Parent(10); //not binding
            //TypeB B = (TypeB)new TypeA(10); //not binding
            #endregion
            #region Why Need Binding
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            //ProcessEmployee(fullTimeEmployee);

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //ProcessEmployee(partTimeEmployee);
            #endregion
            #region More Practise On Binding
            //TypeA typeA = new TypeC(1, 2, 3); ///Reference form indirect parent
            //typeA.A = 11;
            ////typeA.B = 22; invalid
            ////typeA.C = 33; invalid
            //typeA.MyFun01(); // static binding method => I am Base [Parent]
            //typeA.MyFun02(); // Dynamic Binded Method => TypeC: A = 11 , B = 2 , C = 3

            //TypeB typeB = new TypeC(1, 2, 3); /// reference from dirict parent
            //typeB.A = 11;
            //typeB.B = 22;
            ////typeB.C = 30; invalid  
            //typeB.MyFun01();// static binding method => I am Base [Child]
            //typeB.MyFun02();// Dynamic Binded Method => TypeC: A = 11 , B = 22 , C = 3

            //TypeA typeA = new TypeD(1, 2, 3, 4);
            //TypeB typeB = new TypeD(1, 2, 3, 4);
            //TypeC typeC = new TypeD(1, 2, 3, 4);

            //typeA.MyFun02(); //TypeC: A = 1, B = 2, C = 3
            //typeB.MyFun02(); //TypeC: A = 1, B = 2, C = 3
            //typeC.MyFun02(); //TypeC: A = 1, B = 2, C = 3


            //TypeA typeA = new TypeE(1, 2, 3, 4, 5);
            //TypeB typeB = new TypeE(1, 2, 3, 4, 5);
            //TypeC typeC = new TypeE(1, 2, 3, 4, 5);
            //TypeD typeD01 = new TypeD(1, 2, 3, 4);
            //TypeD typeD = new TypeE(1, 2, 3, 4, 5);

            //typeA.MyFun02(); //TypeC: A = 1, B = 2, C = 3
            //typeB.MyFun02(); //TypeC: A = 1, B = 2, C = 3
            //typeC.MyFun02(); //TypeC: A = 1, B = 2, C = 3
            //typeD01.MyFun02(); //TypeD: A = 1 , B = 2 , C = 3 , D = 4 
            //typeD.MyFun02(); //TypeE: A = 1 , B = 2 , C = 3 , D = 4 , E = 5

            #endregion
            #endregion
        }

        #region PolyMorphism 1. Function overloading
        //1.data type of paramaters
        //2.count of paramaters
        //3.order if not same data type of paramaters

        public static int Sum (int x , int y)
        {
            return x + y;
        }

        //public static double Sum(int x, int y)  // not overloading
        //{
        //    return x + y;
        //}

        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static int Sum(double x, double y)
        {
            return (int)(x + y);
        }

        public static int Sum(double x, int y)
        {
            return (int)(x + y);
        }

        public static int Sum(int x, double y)
        {
            return (int)(x + y);
        }
        #endregion

        #region Why Need Binding
        public static void ProcessEmployee(Employee emp)
        {
            if (emp is not null)
            {
                emp.MyFun01(); // static binded method => I am Employee
                emp.MyFun02(); // dynamic binded method => debend on object you sent in parameter
            }
        }

        //public static void ProcessEmployee(FullTimeEmployee emp)
        //{
        //    if(emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}

        //public static void ProcessEmployee(PartTimeEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}

        //public static void ProcessEmployee(FreeLanceEmployee emp)
        //{
        //    if (emp is not null)
        //    {
        //        emp.MyFun01();
        //        emp.MyFun02();
        //    }
        //}
        #endregion
    }
}
