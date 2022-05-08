using Microsoft.EntityFrameworkCore.Migrations;

namespace SPMSOJT.Server.Migrations
{
    public partial class AddStudentIdToCompiledTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "c_task_info",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "c_task_info");
        }
    }
}
