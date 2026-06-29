using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations.InheritanceDb
{
    /// <inheritdoc />
    public partial class TPC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FullTime_Persons_Id",
                table: "FullTime");

            migrationBuilder.DropForeignKey(
                name: "FK_PartTime_Persons_Id",
                table: "PartTime");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PartTime",
                table: "PartTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FullTime",
                table: "FullTime");

            migrationBuilder.RenameTable(
                name: "PartTime",
                newName: "PartTimePersons");

            migrationBuilder.RenameTable(
                name: "FullTime",
                newName: "FullTimePersons");

            migrationBuilder.CreateSequence(
                name: "FullTimeSequence");

            migrationBuilder.CreateSequence(
                name: "PartTimeSequence");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PartTimePersons",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [PartTimeSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "PartTimePersons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PartTimePersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "FullTimePersons",
                type: "int",
                nullable: false,
                defaultValueSql: "NEXT VALUE FOR [FullTimeSequence]",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "FullTimePersons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "FullTimePersons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartTimePersons",
                table: "PartTimePersons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FullTimePersons",
                table: "FullTimePersons",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PartTimePersons",
                table: "PartTimePersons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FullTimePersons",
                table: "FullTimePersons");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "PartTimePersons");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PartTimePersons");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "FullTimePersons");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "FullTimePersons");

            migrationBuilder.DropSequence(
                name: "FullTimeSequence");

            migrationBuilder.DropSequence(
                name: "PartTimeSequence");

            migrationBuilder.RenameTable(
                name: "PartTimePersons",
                newName: "PartTime");

            migrationBuilder.RenameTable(
                name: "FullTimePersons",
                newName: "FullTime");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "PartTime",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [PartTimeSequence]");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "FullTime",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValueSql: "NEXT VALUE FOR [FullTimeSequence]");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PartTime",
                table: "PartTime",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FullTime",
                table: "FullTime",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FullTime_Persons_Id",
                table: "FullTime",
                column: "Id",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartTime_Persons_Id",
                table: "PartTime",
                column: "Id",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
