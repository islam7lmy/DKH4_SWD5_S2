using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Operators_OverLoading
{

    class Employee //model [DB]
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly BirthDate { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public decimal Detuctions { get { return Salary * .2m; } }

        /// object memeber method
        public EmployeeViewModel ToViewModel(Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.Detuctions,
            };
        }

    }
    internal class EmployeeViewModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal NetSalary { get; set; }

        public override string ToString()
        {
            return $"Name : {FullName}\nAge : {Age}\nAddress : {Address}\nNetSalary : {NetSalary}";
        }

        ///user defined casting operator
        public static /*EmployeeViewModel*/ explicit operator EmployeeViewModel(Employee emp)
        {
            return new EmployeeViewModel()
            { 
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address= $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.Detuctions,
            };
        }

        //public static /*EmployeeViewModel*/ implicit operator EmployeeViewModel(Employee emp)
        //{
        //    return new EmployeeViewModel();
        //}

        ///manual mapping
        public static EmployeeViewModel FromEmployee(Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.Detuctions,
            };
        }

    }

    static class test
    {
        public static EmployeeViewModel ToEmployeeViewModel(this Employee emp)
        {
            return new EmployeeViewModel()
            {
                FullName = $"{emp.FirstName} {emp.LastName}",
                Age = DateTime.Now.Year - emp.BirthDate.Year,
                Address = $"{emp.Address}, {emp.City}, {emp.Country}",
                NetSalary = emp.Salary - emp.Detuctions,
            };
        }

        public static void add(this int num, int value)
        {
            num += value;
        }

        public static void sub(this int num, int value)
        {
            num -= value;
        }
    }
}
