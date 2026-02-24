using System.Text;

namespace Demo01
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Comments
            //line comment
            /*
             * block comment
             */
            #endregion

            #region Value Type
            //int X;
            ///// allocate 4 uninitialized bytes in stack
            ///// int : C# keyword

            //X = 5;

            //Int32 Y;
            ///// allocate 4 uninitialized bytes in stack
            ///// int32 : BCL

            //Y = 10;

            //Y = X; 

            //X += 1;

            //Console.WriteLine(X);
            //Console.WriteLine(Y);
            #endregion

            #region Reference Type
            //Point p1;
            ///// Declare for reference from type point, referring to null
            ///// 4 bytes have been allocated in stack
            ///// zero bytes have been allocated in heap 

            //p1 = new Point();
            /////new
            /////1. allocate required bytes for object point in heap [4 bytes for x , 4 bytes for y]
            /////2. initilize the allocated bytes with the default value of it's datatype [x = 0 , y = 0]
            /////3. call user defined constructor if exists
            /////4. assign reference p1 to the allocated object

            //Console.WriteLine(p1.GetHashCode());

            //Point p2 = new Point();
            //Console.WriteLine(p2.GetHashCode());
            //p2 = p1;
            //Console.WriteLine("after assignment");
            //Console.WriteLine(p1.GetHashCode());
            //Console.WriteLine(p2.GetHashCode());

            //p1.x = 10;

            //Console.WriteLine(p1.x);
            //Console.WriteLine(p2.x);

            #endregion

            #region object
            //Point o1 = new Point();
            //Point o2 = new Point();

            //o1.GetHashCode();
            //o1.ToString();
            //o1.Equals(o2);
            //o1.GetType();

            //int x = 10;

            //x.GetHashCode();
            //x.ToString();
            //x.Equals(10);
            //x.GetType();


            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            //o2 = o1;
            //Console.WriteLine("after assignment");
            //Console.WriteLine(o1.GetHashCode());
            //Console.WriteLine(o2.GetHashCode());

            #endregion

            #region Fractions and Discards
            //Int64 x = 7_321_456_879; // discard for reading only

            //float f1 = 2.2f;
            //double d1 = 2.2;
            //decimal m1 = 2.2m;

            //var div = 2.2M; //syntex suger
            #endregion

            #region Value Type Casting
            ///1. implicit Casting  (safe Casting)
            //int x = 5;
            //long y = x;
            //y = 737_373_986_531;

            ///2. explicit casting (unsafe casting)
            //x = (int)y;
            //Console.WriteLine(x);

            ///3. checked and unchecked explicit casting (overflow)
            //unchecked
            //{
            //    x = (int)y;
            //    Console.WriteLine(x);
            //}
            //checked
            //{
            //    x = (int)y;
            //    unchecked
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            ///4. parse (string to value type) (not error handling)
            //Console.WriteLine("please insert your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("please insert your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("hello " + name + " your age is " + age);
            //Console.WriteLine("do some code");

            //5. try parse (string to value type with error handling)
            //Console.WriteLine("please insert your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("please insert your age: ");
            //int age;
            //bool result = int.TryParse(Console.ReadLine(),out age);
            //if (result)
            //{
            //    Console.WriteLine("hello " + name + " your age is " + age);

            //}
            //else
            //{
            //    Console.WriteLine("invalid age");
            //}
            //Console.WriteLine("do some code");

            ///6. convert class (any datatype to any datatype) (not error handling)
            //Console.WriteLine("please insert your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("please insert your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("hello " + name + " your age is " + age);
            //Console.WriteLine("do some code");
            #endregion

            #region Operators

            #region Unary Operators
            //int x = 10;
            ///// prefix [increment and then print]
            //Console.WriteLine(++x); //increment x to 11 then print 11
            ///// postfix [print and then increment]
            //Console.WriteLine(x++); //print 11 then increment x to 12
            //Console.WriteLine(x); //print 12
            ///// prefix [decrement and then print]
            //Console.WriteLine(--x); //decrement x to 11 then print 11
            ///// postfix [print and then decrement]
            //Console.WriteLine(x--); //print 11 then decrement x to 10
            //Console.WriteLine(x); //print 10


            //++x;
            //Console.WriteLine(x);
            //x++;
            //Console.WriteLine(x);
            //--x;
            //Console.WriteLine(x);
            //x--;
            //Console.WriteLine(x);
            #endregion

            #region Binary operator
            //int sum, sub, mul, div, mod;
            //int num1 = 10, num2 = 3;
            //sum = num1 + num2; 
            //sub = num1 - num2;
            //mul = num1 * num2;
            //div = num1 / num2;
            //mod = num1 % num2;

            ////double div2 = 10.0 / 3; // int / int = int
            //double div2 = (double) num1 / num2; // int / int = int
            //Console.WriteLine(div2);
            #endregion

            #region Assignment operator
            //int x;
            //x = 5; // assignment operator
            //x += 10; // x = x + 10
            //x -= 2; // x = x - 2
            //x *= 3; // x = x * 3
            //x /= 4; // x = x / 4
            //x %= 3; // x = x % 3
            #endregion

            #region Relational operator [Comparision]
            //int x = 10, y = 20;
            //Console.WriteLine(x == y);//equality operator
            //Console.WriteLine(x != y);//inequality operator
            //Console.WriteLine(x > y);//greater than operator
            //Console.WriteLine(x < y);//less than operator
            //Console.WriteLine(x >= y);//greater than or equal operator
            //Console.WriteLine(x <= y);//less than or equal operator
            #endregion

            #region logical operators
            //Console.WriteLine(!false); // logical not operator
            //Console.WriteLine(false && true); //short circute // logical and operator
            //Console.WriteLine(true || false); //short circute // logical or operator

            //Console.WriteLine((4<5) && !((7<9) || 5 == 5 ));
            #endregion

            #region Bitwise operator
            //Console.WriteLine(false & true); //long circute //bitwise and operator
            //Console.WriteLine(true | false); //long circute //bitwise or operator
            //Console.WriteLine(true ^ false); //long circute //bitwise Xor or operator
            #endregion

            #region Ternary Operator [Conditional operator]
            //int x = 4, y = 7, d = 10;
            //if (x > y)
            //    Console.WriteLine("x is greater than y");
            //else
            //    Console.WriteLine("y is greater than x");

            //Console.WriteLine(x > y ? "x is greater than y" : "y is greater than x");

            //int flag;
            //if (x > y)
            //    flag = 1;
            //else
            //    flag = 0;

            //flag = x > y ? 1 : 0;

            //ternary not recommended for complex conditions
            //int max;
            //if (x > y)
            //    if (x > d)
            //        max = x;
            //    else
            //        max = d;
            //else
            //    if (y > d)
            //    max = y;
            //else
            //    max = d;

            //max = x > y ? (x > d ? x : d) : (y > d ? y : d);
            #endregion

            #region Operator priorty
            /*
             * 1. unary operators (prefix)
             * 2. round brackets ()
             * 3. multiplicative operators (*, /, %)
             * 4. additive operators (+, -)
             */
            //int a = 20, b = 10, c = 15, d = 5, e;
            //e = (a + b) * c / d; // e = (20 + 10) * 15 / 5 = 30 * 15 / 5 = 450 / 5 = 90
            //e = ((--a + b) * c) / d; // e = ((19 + 10) * 15) / 5 = (29 * 15) / 5 = 435 /5 = 87 
            //e = --a + b * c / d; // e = 19 + 10 * 15 / 5 = 19 + 150 / 5 = 19 + 30 = 49
            //Console.WriteLine(e);
            #endregion
            #endregion

            #region string vs stringbuilder
            //string x = "hello"; // syntex sugar for string x = new string("hello");
            //Console.WriteLine(x.GetHashCode());
            ////x = "world"; //string imutable type x = new string("world");
            //x += " world"; //string imutable type x = new string("hello world");
            //Console.WriteLine(x.GetHashCode());
            ///////////////////////////////////////////////////
            //StringBuilder sb = new StringBuilder();
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append("hello");
            //Console.WriteLine(sb.GetHashCode());
            //sb.Append(" world");
            //Console.WriteLine(sb.GetHashCode());
            ////sb.Clear();
            ////sb.Remove(5, 6);
            ////sb.Insert(0, "test ");
            ////sb.Replace("hello", "C#");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region String Formatting
            // Equation : 4 + 2 = 6
            //int x = 4, y = 2;
            //string result = "Equation : " + x + " + " + y + " = " + (x + y); // string concatenation 
            //string result = string.Format("Equation : {0} + {1} = {2}", x, y, (x + y)); // string format method
            //string result = $"Equation : {x} + {y} = {x + y}"; // string interpolation
            #endregion
        }
    }
}
