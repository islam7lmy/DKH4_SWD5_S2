using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal interface IMoveable
    {
        public int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }

    internal interface IFlayable
    {
        public int Speed { get; set; }
        void Forward();
        void Backward();
        void Left();
        void Right();
    }

    class Car : IMoveable
    {
        public int Speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Move BackWord On Ground");
        }

        public void Forward()
        {
            Console.WriteLine("Move ForWard On Ground");
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }


    class AirPlane : IMoveable,IFlayable
    {
        int IMoveable.Speed { get; set; } //Explicit implement
        int IFlayable.Speed { get; set; } //Explicit implement

        void IMoveable.Forward() //Explicit implement
        {
            Console.WriteLine("Move Forward On Ground");
        }

        void IFlayable.Forward() //Explicit implement
        {
            Console.WriteLine("Flay Forward On Air");
        }

        void IMoveable.Backward() //Explicit implement
        {
            Console.WriteLine("Move Backward On Ground");
        }

        void IFlayable.Backward() //Explicit implement
        {
            Console.WriteLine("Flay Backward On Air");
        }

        public void Left() //implicit in case code will run same same
        {
            Console.WriteLine("Move Left");
        }

        public void Right() //implicit in case code will run same same
        {
            Console.WriteLine("Move Right");
        }

    }
}
