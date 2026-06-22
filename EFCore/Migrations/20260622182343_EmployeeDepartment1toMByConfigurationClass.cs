using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeDepartment1toMByConfigurationClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                schema: "dbo",
                table: "DepartmentsInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsInfo_ManagerId",
                schema: "dbo",
                table: "DepartmentsInfo",
                column: "ManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsInfo_Employees_ManagerId",
                schema: "dbo",
                table: "DepartmentsInfo",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DepartmentsInfo_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId",
                principalSchema: "dbo",
                principalTable: "DepartmentsInfo",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentsInfo_Employees_ManagerId",
                schema: "dbo",
                table: "DepartmentsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DepartmentsInfo_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentsInfo_ManagerId",
                schema: "dbo",
                table: "DepartmentsInfo");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                schema: "dbo",
                table: "DepartmentsInfo");
        }
    }
}
