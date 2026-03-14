using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Car
    {
        //full property
        //int id;
        //public int ID 
        //{ 
        //    get { return id; }
        //    set { id = value; }
        //}
        //string model;
        //int speed;

        //automatic property => backing field
        public int Id { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        // If No User-Defined Constructor Exist,
        // Compiler Will Always Generate Empty Parameterless Constructor
        // public Car() { } => Do Nothing


        // If U Write User-Defined Constructor,
        // Compiler Will No Longer Generate Empty Parameterless Constrcutor

        /// user defined constructor
        public Car(int id, string model, int speed)
        {
            Id = id;
            Model = model;
            Speed = speed;
            Console.WriteLine("constructor 04");
        }

        public Car(int id, string model) : this(id, model, 120)
        {
            //Id = id;
            //Model = model;
            //Speed = 120;
            Console.WriteLine("constructor 03");
        }

        public Car(int id) : this(id , "BMW")
        {
            //Id = id;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("constructor 02");
        }

        public Car() : this(10)
        {
            //Id = 10;
            //Model = "BMW";
            //Speed = 120;
            Console.WriteLine("constructor 01");
        }

        public override string ToString()
        {
            return $"{Id} , {Model} , {Speed}";
        }
    }
}
