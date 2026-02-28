using System.Text;
using System.Threading.Channels;

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

            #region Conditional Statment
            #region EX01
            #region if
            //Console.WriteLine("insert number of month in first Qurter of year: ");
            //int month;
            //if (int.TryParse(Console.ReadLine(), out month))
            //{
            //    //if (month == 1)
            //    //    Console.WriteLine("January");
            //    //if (month == 2)
            //    //    Console.WriteLine("February");
            //    //if (month == 3)
            //    //    Console.WriteLine("March");

            //    if (month == 1)
            //        Console.WriteLine("January");
            //    else if (month == 2)
            //        Console.WriteLine("February");
            //    else if (month == 3)
            //        Console.WriteLine("March");
            //    else
            //        Console.WriteLine("number is out of range");
            //}
            //else
            //    Console.WriteLine("invalid input for month");

            #endregion
            #region switch
            //Console.WriteLine("insert number of month in first Qurter of year: ");
            //int month;
            //int.TryParse(Console.ReadLine(), out month);
            ///// jump table 
            //switch (month)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 0: Console.WriteLine("invalid input for month"); break;
            //    default: Console.WriteLine("number is out of range"); break;
            //}

            #endregion

            #endregion

            #region EX02
            #region if
            //int salary;
            //if(int.TryParse(Console.ReadLine(), out salary))
            //{
            //    if (salary == 3000)
            //    {
            //        Console.WriteLine("option 3");
            //        Console.WriteLine("option 2");
            //        Console.WriteLine("option 1");
            //    }
            //    else if (salary == 2000)
            //    {
            //        Console.WriteLine("option 2");
            //        Console.WriteLine("option 1");
            //    }
            //    else if (salary == 1000)
            //    {
            //        Console.WriteLine("option 1");
            //    }
            //    else
            //        Console.WriteLine("can not do any option");
            //}
            //else Console.WriteLine("invalid input");
            #endregion
            #region switch
            //int salary;
            //if (int.TryParse(Console.ReadLine(), out salary))
            //{
            //    //switch (salary)
            //    //{
            //    //    case 3000:
            //    //        Console.WriteLine("option 3");
            //    //        Console.WriteLine("option 2");
            //    //        Console.WriteLine("option 1"); 
            //    //        break;
            //    //    case 2000:
            //    //        Console.WriteLine("option 2");
            //    //        Console.WriteLine("option 1");
            //    //        break;
            //    //    case 1000:
            //    //        Console.WriteLine("option 1"); 
            //    //        break;
            //    //    default: 
            //    //        Console.WriteLine("can not do any option"); 
            //    //        break;
            //    //}

            //    switch (salary)
            //    {
            //        case 3000:
            //            Console.WriteLine("option 3");
            //            //Console.WriteLine("option 2");
            //            //Console.WriteLine("option 1");
            //            //break;
            //            goto case 2000;
            //        case 2000:
            //            Console.WriteLine("option 2");
            //            //Console.WriteLine("option 1");
            //            //break;
            //            goto case 1000;
            //        case 1000:
            //            Console.WriteLine("option 1");
            //            break;
            //        default:
            //            Console.WriteLine("can not do any option");
            //            break;
            //    }
            //}
            //else Console.WriteLine("invalid input");

            #endregion
            #endregion

            #region Calculater
            // take number then opration then number and show result
            //calculator do (+ - * / %)
            //write program to do that and make it protictive

            //int num1, num2;
            //double result;
            //char op;
            //Console.WriteLine("enter first number");
            //if (!int.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.WriteLine("invalid format for first number");
            //    return;
            //}

            //Console.WriteLine("enter operation (+ - * / %)");
            //if (!(char.TryParse(Console.ReadLine(), out op)
            //    &&
            //    (op == '+' || op == '-' || op == '*'
            //    || op == '/' || op == '%')))
            //{
            //    Console.WriteLine("invalid format for operation");
            //    return;
            //}

            //Console.WriteLine("enter last number");
            //if (!int.TryParse(Console.ReadLine(), out num2))
            //{
            //    Console.WriteLine("invalid format for last number");
            //    return;
            //}

            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //            result = (double)num1 / num2;
            //        else
            //        {
            //            Console.WriteLine("can not divide by zero");
            //            return;
            //        }
            //        break;
            //    case '%':
            //        if (num2 != 0)
            //            result = num1 % num2;
            //        else
            //        {
            //            Console.WriteLine("can not divide by zero");
            //            return;
            //        }
            //        break;
            //    default: return;
            //}
            //Console.WriteLine($"{num1} {op} {num2} = {result}");

            #endregion
            #endregion

            #region Loop Statment
            // print numbers from 1 to 10
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            #region for
            /// for (initilization; condtion; increment | decrement)
            /// body
            /// 
            /// 1. initilization
            /// 2. check condtion
            /// 3. if condtion true => do body code
            /// 4. increment | decrement
            /// 5. check condtion
            /// 6. if condtion true => do body code
            /// 7. increment | decrement

            //for (int i = 1; i <= 10; ++i) //i++ // i+=1 // i = i+1
            //    Console.WriteLine(i);

            //int i = 1; //initilization
            //for (; ; )
            //{
            //    if (i <= 10) //condtion
            //    {
            //        if(i % 2 == 0)
            //        {
            //            i++;
            //            continue; //skip the rest of the loop body and go to the next iteration
            //        }
            //        Console.WriteLine(i); //body
            //        i++; //increment
            //    }
            //    else
            //        break; // exit the loop
            //}
            #endregion

            #region while
            ///while(reader.Read())
            ///{
            ///   do some code to read data from reader
            ///}

            //Console.WriteLine("insert 0 if you want to print");
            //string input = Console.ReadLine();
            //while (input == "0")
            //{
            //    Console.WriteLine("hello");
            //    Console.WriteLine("insert 0 if you want to print or press any key to exit");
            //    input = Console.ReadLine();
            //}

            //int num1, num2;
            //char op;
            //double result;
            //Console.WriteLine("enter first number");
            //while (!int.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.WriteLine("wrong format, enter first number");
            //}

            //Console.WriteLine("enter operation (+ - * / %)");
            //while (!(char.TryParse(Console.ReadLine(), out op)
            //    && (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')))
            //{
            //    Console.WriteLine("wrong format, enter operation (+ - * / %)");
            //}

            //Console.WriteLine("enter last number");
            //while (!int.TryParse(Console.ReadLine(), out num2) || ((op == '/' || op == '%') && num2 == 0))
            //{
            //    Console.WriteLine($"wrong format, enter last number {(op == '/' || op == '%' ? "and make sure not be zero" : "")}");
            //}

            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        result = (double)num1 / num2;
            //        break;
            //    case '%':
            //        result = num1 % num2;
            //        break;
            //    default: return;
            //}
            //Console.WriteLine($"{num1} {op} {num2} = {result}");
            #endregion

            #region do while
            //for (int i = 11; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 11; 
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i <= 10);

            //int num1, num2;
            //char op;
            //double result;
            //do
            //{
            //    Console.WriteLine("enter first number");
            //    while (!int.TryParse(Console.ReadLine(), out num1))
            //    {
            //        Console.WriteLine("wrong format, enter first number");
            //    }

            //    Console.WriteLine("enter operation (+ - * / %)");
            //    while (!(char.TryParse(Console.ReadLine(), out op)
            //        && (op == '+' || op == '-' || op == '*' || op == '/' || op == '%')))
            //    {
            //        Console.WriteLine("wrong format, enter operation (+ - * / %)");
            //    }

            //    Console.WriteLine("enter last number");
            //    while (!int.TryParse(Console.ReadLine(), out num2) || ((op == '/' || op == '%') && num2 == 0))
            //    {
            //        Console.WriteLine($"wrong format, enter last number {(op == '/' || op == '%' ? "and make sure not be zero" : "")}");
            //    }

            //    switch (op)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            result = (double)num1 / num2;
            //            break;
            //        case '%':
            //            result = num1 % num2;
            //            break;
            //        default: return;
            //    }
            //    Console.WriteLine($"{num1} {op} {num2} = {result}");
            //    Console.WriteLine("*************************************************************");
            //    Console.WriteLine("if you want to do anthor operation enter 'y' or press any key to exit");
            //} while (Console.ReadLine().ToUpper() == "Y");
            #endregion

            #region foreach [collections]
            //string text = Console.ReadLine();

            //for (int i = 0; i < text.Length; i++)
            //    Console.WriteLine(text[i]);

            ///// display
            //foreach (char item in text)
            //    Console.WriteLine(item);

            //List<string> names = new List<string>()
            //{
            //    "ali",
            //    "ahmed",
            //    "sara"
            //};

            //for (int i = 0; i < names.Count; i++) // with collections to edit
            //{
            //    names[i] += "hello";
            //}

            //vs

            //foreach (var item in names)
            //{
            //    item += "hello"; // not valid //for display only
            //}
            #endregion
            #endregion

            #region Block Scope
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(i); //out of scope

            //while (!double.TryParse(Console.ReadLine(), out double x))
            //{
            //    double z = 0;
            //    Console.WriteLine(x);
            //}
            ////x = 3; //out of scope
            ////z = 3; //out of scope 

            ////double y;
            //if (!double.TryParse(Console.ReadLine(), out double y))
            //{
            //    int z = 0;
            //    Console.WriteLine(y);
            //}
            //y = 3;
            //z = 3;//out of scope

            //int x = 0;
            //{ int z = 0; x = 1; }
            //{ int z = 0; x = 2; }
            #endregion

            #region Arrays
            #region one D Array
            //int[] numbers;
            // Declare for Reference from Type "Array of Integrs"
            // Refering to the default value of Reference Type = NULL
            // CLR Will Allocate 4 Bytes for The Reference at STACK
            // CLR Will Allocate Zero Bytes at HEAP 

            //numbers = new int[5];
            // CLR Allocate 20 Bytes at HEAP,
            // Intiailized with the default value of int = 0
            // make reference refer on first element in object of array

            //int[] numbers1 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
            //int[] numbers3 = { 1, 2, 3, 4, 5 };

            //numbers[0] = 1;
            // numbers[4] = 2; //size - 1
            //numbers[5] = 3; //not valid //runtime error

            //Console.WriteLine($"the size of array {numbers.Length}, the number of dimensions {numbers.Rank}");


            //write a program with protictive code to read elemnts of array from user
            //then print all elements
            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"enter the { i + 1 } element of array");
            //    while(!int.TryParse(Console.ReadLine(),out numbers[i]))
            //        Console.WriteLine($"wrong format, enter the {i + 1} element of array");
            //}

            //Console.WriteLine("the arry element :");
            //foreach(int item in numbers)
            //    Console.WriteLine(item);
            #endregion

            #endregion
        }
    }
}
