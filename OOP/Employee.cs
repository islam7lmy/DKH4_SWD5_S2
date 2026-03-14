using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct Employee
    {
        public int ID;
        // encapsulation :Seperates The Data Defintion (Attribute) From Its Use (GetterSetter Or Property)
        #region Name  [getter setter method]
        string Name;

        // Getter For Name Attribute
        public string GetName()
        {
            return Name;
        }
        // Setter For Name Attribute
        public void SetName(string value)
        {
            Name = value.Length <= 20 ? value : value.Substring(0, 20);
        }
        #endregion
        // Property => Easy Use Like Attribute and at the Same Time Have The 3 Features Of Encapsulation
        #region 1. Full Property
        decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value < 2000 ? 2000 : value;
            }
        }
        #endregion
        #region Automatic Property
        // Compiler Will Generate Backing Field [Hidden Private Attribute]
        public int Age { get; set; }

        public decimal Deductions { get { return Salary * .2M; } } //Drived attribute
        #endregion

        public Employee(int _id , string _name ,decimal salary , int _age)
        {
            ID = _id;
            SetName(_name);
            Salary = salary;
            Age = _age;
        }
    }
}
