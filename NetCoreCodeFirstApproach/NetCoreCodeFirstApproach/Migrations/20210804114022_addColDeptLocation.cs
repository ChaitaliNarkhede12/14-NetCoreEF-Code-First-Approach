using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreCodeFirstApproach.Migrations
{
    public partial class addColDeptLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DeptLocation",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DeptId", "DeptLocation", "DeptName" },
                values: new object[] { 1, null, "IT" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "DeptId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DeptLocation",
                table: "Departments");
        }
    }
}
