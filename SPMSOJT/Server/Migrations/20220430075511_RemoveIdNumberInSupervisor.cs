using Microsoft.EntityFrameworkCore.Migrations;

namespace SPMSOJT.Server.Migrations
{
    public partial class RemoveIdNumberInSupervisor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idnumber",
                table: "supervisor_info");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "idnumber",
                table: "supervisor_info",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
