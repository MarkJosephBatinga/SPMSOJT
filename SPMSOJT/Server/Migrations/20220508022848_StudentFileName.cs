using Microsoft.EntityFrameworkCore.Migrations;

namespace SPMSOJT.Server.Migrations
{
    public partial class StudentFileName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentFileName",
                table: "c_task_info",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentFileName",
                table: "c_task_info");
        }
    }
}
