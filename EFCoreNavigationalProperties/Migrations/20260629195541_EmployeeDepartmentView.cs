using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreNavigationalProperties.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeDepartmentView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                create view EmployeeDepartmentView
                with encryption
                as 
                 select 
                 E.Id 'EmpId',
                 E.Name 'EmpName',
                 D.Id 'DepartmentId',
                 D.Name 'DepartmentName'
                 from  Employees E
                 left outer join Departments D
                 on D.Id = e.DepartmentId
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"drop view EmployeeDepartmentView");
        }
    }
}
