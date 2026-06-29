using EFCoreNavigationalProperties.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFCoreNavigationalProperties
{
    internal class Program
    {
        static void Main()
        {
            ///1.Loading Navigational Properties
            ///     1.1.byDefault
            ///     1.2.Explicit
            ///     1.3.Eager
            ///     1.4.Lazy
            ///2.LINQ Join Operators - Join(), GroupJoin()
            ///     2.1.Innerjoin
            ///     2.2.Groupjoin
            ///     2.3.Leftjoin
            ///     2.4.Crossjoin
            using AppDbContext dbContext = new AppDbContext();
            #region 1.Loading Navigational Properties
            #region 1.1.byDefault
            //var Emp = (from e in dbContext.Employees
            //          where e.Id == 1
            //          select e).FirstOrDefault();

            //if(Emp is not null)
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, Department = {Emp.Department?.Name ?? "NA"}");
            #endregion
            #region 1.2.Explicit
            //var Emp = (from e in dbContext.Employees
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //{
            //    dbContext.Entry(Emp).Reference(e => e.Department).Load();
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, DepartmentId = {Emp.DepartmentId}, Department = {Emp.Department?.Name ?? "NA"}");
            //}
            ///////////////////////////////////////////////////////////////////
            //var Dept = (from d in dbContext.Departments
            //            where d.Id == 10
            //            select d).FirstOrDefault();
            //if (Dept is not null)
            //{
            //    dbContext.Entry(Dept).Collection(d=>d.Employees).Load();
            //    Console.WriteLine($"Department: Id = {Dept.Id}, Name = {Dept.Name}, CreationDate = {Dept.CreationDate}");
            //    if (Dept.Employees is not null)
            //        foreach (var emp in Dept.Employees)
            //        {
            //            Console.WriteLine($"\tEmployee: Id = {emp.Id}, Name = {emp.Name}, DepartmentId = {emp.DepartmentId}");
            //        }
            //}
            #endregion
            #region 1.3.Eager
            //var Emp = (from e in dbContext.Employees
            //           .Include(em=>em.Department)
            //           //.Include(em=>em.Department).ThenInclude(d=>d.Project)
            //           //.Include(em=>em.Department).ThenInclude(d=>d.Product)
            //           where e.Id == 1
            //           select e).FirstOrDefault();


            //if (Emp is not null)
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, Department = {Emp.Department?.Name ?? "NA"}");
            #endregion
            #region 1.4.Lazy
            //var Emp = (from e in dbContext.Employees
            //           where e.Id == 1
            //           select e).FirstOrDefault();

            //if (Emp is not null)
            //    Console.WriteLine($"Employee: Id = {Emp.Id}, Name = {Emp.Name}, Department = {Emp.Department?.Name ?? "NA"}");
            #endregion
            #endregion

            #region 2.LINQ Join Operators
            #region 2.1.Innerjoin
            #region Query Exprission
            //var result = from D in dbContext.Departments
            //             join E in dbContext.Employees
            //             on D.Id equals E.DepartmentId
            //             select new
            //             {
            //                 empid = E.Id,
            //                 empname = E.Name,
            //                 deptid = D.Id,
            //                 deptname = D.Name
            //             };
            #endregion
            #region falunt Exprission
            //var result2 = dbContext.Departments.Join(
            //    dbContext.Employees,
            //    d=>d.Id,
            //    e=>e.DepartmentId,
            //    (D, E) => new{

            //        empid = E.Id,
            //        empname = E.Name,
            //        deptid = D.Id,
            //        deptname = D.Name
            //    });
            #endregion
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Employee: Id = {item.empid}, Name = {item.empname}, DepartmentId = {item.deptid}, DepartmentName = {item.deptname}");
            //}

            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"Employee: Id = {item.empid}, Name = {item.empname}, DepartmentId = {item.deptid}, DepartmentName = {item.deptname}");
            //}
            #endregion
            #region Group Join
            //var result = from D in dbContext.Departments
            //             join E in dbContext.Employees
            //             on D.Id equals E.DepartmentId into EmpGroup
            //             select new
            //             {
            //                 Department = D,
            //                 Employees = EmpGroup
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Department: Id = {item.Department.Id}, Name = {item.Department.Name}");
            //    foreach (var emp in item.Employees)
            //    {
            //        Console.WriteLine($"\tEmployee: Id = {emp.Id}, Name = {emp.Name}, DepartmentId = {emp.DepartmentId}");
            //    }
            //}
            #endregion
            #region LeftJoin
            //var result = from D in dbContext.Departments
            //             join E in dbContext.Employees
            //             on D.Id equals E.DepartmentId into EmpGroup
            //             ///////////////////////////////////////////
            //             from Emp in EmpGroup.DefaultIfEmpty()
            //             select new
            //             {
            //                 Department = D,
            //                 Employee = Emp
            //             };

            //var result2 = from E in dbContext.Employees
            //             join D in dbContext.Departments
            //             on E.DepartmentId equals D.Id into DeptGroup
            //              ///////////////////////////////////////////
            //              from Dept in DeptGroup.DefaultIfEmpty()
            //             select new
            //             {
            //                 Department = Dept,
            //                 Employee = E
            //             };

            //foreach (var item in result2)
            //{
            //    var emp = item.Employee;
            //    Console.WriteLine($".............Employee: Id = {emp.Id}, Name = {emp.Name}, Department = {emp.Department?.Name ?? "NA"}");
            //    if (item.Department is null)
            //        Console.WriteLine("Department: NA");
            //    else
            //        Console.WriteLine($"Department: Id = {item.Department.Id}, Name = {item.Department.Name}");
            //    Console.WriteLine("****************************************************************************************");
            //}
            #endregion
            #region CrossJoin
            //var result = from e in dbContext.Employees
            //             from d in dbContext.Departments
            //             select new
            //             {
            //                 empname = e.Name,
            //                 deptname = d.Name
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            var result = dbContext.EmployeeDepartmentsView.ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"Employee: Id = {item.EmpId}, Name = {item.EmpName}, DepartmentId = {item.DepartmentId}, DepartmentName = {item.DepartmentName}");
            }
            #endregion
        }
    }
}
