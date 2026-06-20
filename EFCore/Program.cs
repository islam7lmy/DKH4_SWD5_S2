using EFCore.Contexts;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region How To Migrate
            //to add db to sql server:

            ///1.Install-Package "Microsoft.EntityFrameworkCore.SqlServer" -v "7.0"
            ///2.create Compnydbcontext that inhert DbContext
            ///3.override OnConfiguring and set db conection string
            ///4.add dbset<> for class (Models) that want to be tables
            ///5.install Package Microsoft.EntityFrameworkCore.Tools
            ///6.Add-Migration "InitialCreate"
            ///7.Update-Database
            #endregion

            #region CRUD Operations [Create, Read, Update, Delete]
            ///unmanaged code
            CompanyDBContext context = new CompanyDBContext();
            //try
            //{
            //    ///CRUD Operations [Create, Read, Update, Delete]
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    context.Dispose(); //[release | Close] DbConnetion
            //}

            //using (CompanyDBContext context2 = new CompanyDBContext())
            //{
            //    ///CRUD Operations [Create, Read, Update, Delete]
            //}

            //using CompanyDBContext context3 = new CompanyDBContext();
            /////CRUD Operations [Create, Read, Update, Delete]
            /////code after this line will be executed after dispose context3
            /////Crud Operations [Create, Read, Update, Delete]
            /////code after this line will be executed after dispose context3

            using CompanyDBContext dBContext = new CompanyDBContext();

            //Employee E01 = new Employee()
            //{
            //    Name = "Ahmed",
            //    Salary = 5000,
            //    Age = 30,
            //};

            //Employee E02 = new Employee()
            //{
            //    Name = "Ali",
            //    Salary = 10000,
            //    Age = 27,
            //};

            #region Create
            //dBContext.Employees.Add(E02);
            //dBContext.Set<Employee>().Add(E01);
            //dBContext.Add(E02);
            //dBContext.Entry(E02).State = EntityState.Added;

            //Console.WriteLine(dBContext.Entry(E02).State);
            //dBContext.Employees.Add(E02);
            //Console.WriteLine(dBContext.Entry(E02).State);
            //dBContext.SaveChanges();
            //Console.WriteLine(dBContext.Entry(E02).State);
            #endregion

            #region Read
            #region Multi Elements
            ////Iqueryable<Employee> Employees = dBContext.Employees; //select * from Employees
            //var Result = from emp in dBContext.Employees
            //             where emp.Id == 1 
            //             select emp; //linq query => select * from Employees where Id = 1

            ////IEnumerable<Employee> Employees2 = dBContext.Employees.Where(e => e.Id == 1); //select * from Employees where Id = 1
            //var Result2 = (from emp in dBContext.Employees
            //              where emp.Id == 1
            //              select emp).ToList();

            //var Result3 = dBContext.Employees.Where(e => e.Id == 1).ToList(); //select * from Employees where Id = 1

            //foreach (var emp in Result)
            //{
            //    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}");
            //}
            #endregion
            #region One Element
            //var emp = (from emp1 in dBContext.Employees
            //             where emp1.Id == 1
            //             select emp1)
            //             //.First(); //top(1) => select top(1) * from Employees where Id = 1
            //             //.FirstOrDefault(); //top(1) or null => select top(1) * from Employees where Id = 1
            //             //.Single(); //top(2) => select top(2) * from Employees where Id = 1
            //             .SingleOrDefault(); //top(2) or null => select top(2) * from Employees where Id = 1
            //Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Salary: {emp.Salary}, Age: {emp.Age}");
            #endregion
            #endregion
            #endregion

        }
    }
}
