using Commen;

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

            Car c1 = new Car();
            //Console.WriteLine(c1);
            //Car c2 = new Car(20);
            //Console.WriteLine(c2);
            //Car c3 = new Car(30 , "audi");
            //Console.WriteLine(c3);
            //Car c4 = new Car(40, "skoda", 160);
            //Console.WriteLine(c4);
            #endregion
            #endregion
        }
    }
}
