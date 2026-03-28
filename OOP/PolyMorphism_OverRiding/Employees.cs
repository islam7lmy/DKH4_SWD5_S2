using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.PolyMorphism_OverRiding
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void MyFun01()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void MyFun02()
        {
            Console.WriteLine($"Employee: id = {Id} , name = {Name} , age = {Age}");
        }
    }

    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public new void MyFun01()
        {
            Console.WriteLine("I am FullTime Employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Employee: id = {Id} , name = {Name} , age = {Age} , salary = {Salary} ");
        }
    }

    class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }
        public new void MyFun01()
        {
            Console.WriteLine("I am PartTime Employee");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Employee: id = {Id} , name = {Name} , age = {Age} , hourRate = {HourRate} , countOfHours = {CountOfHours} ");
        }
    }

    class FreeLanceEmployee : Employee
    {

    }
}
