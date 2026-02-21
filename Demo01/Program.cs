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
            int x = 5;
            long y = x;
            y = 737_373_986_531;

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
            #endregion
        }
    }
}
