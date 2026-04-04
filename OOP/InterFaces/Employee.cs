using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.InterFaces
{
    internal class Employee : ICloneable,IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        /// default constructor
        public Employee()
        {
            
        }

        /// copy constructor => a constructor that takes an object of the same class as a parameter 
        /// and initializes the new object with the values of the existing object.
        public Employee(Employee emp)
        {
            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Salary = emp.Salary;
        }

        public object Clone()
        {
            ///this keyword => refer on object instance that call method
            //return new Employee()
            //{
            //    Id = this.Id,// emp01.Id
            //    Name = this.Name, // emp01.Name
            //    Salary = this.Salary // emp01.Salary
            //};
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        ///+ve : this > obj
        ///-ve : this < obj
        ///0 : this == obj
        public int CompareTo(object? obj)
        {
            Employee other = (Employee)obj; ///explicit casting , unsafe casting
            if (this.Salary > other.Salary)
                return 1;
            else if (this.Salary < other.Salary)
                return -1;
            else
                return 0;
        }
    }
}
