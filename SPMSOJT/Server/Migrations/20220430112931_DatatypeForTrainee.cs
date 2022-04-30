using Microsoft.EntityFrameworkCore.Migrations;

namespace SPMSOJT.Server.Migrations
{
    public partial class DatatypeForTrainee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainee_info_organization_info_organizationId",
                table: "trainee_info");

            migrationBuilder.DropForeignKey(
                name: "FK_trainee_info_supervisor_info_supervisorId",
                table: "trainee_info");

            migrationBuilder.DropForeignKey(
                name: "FK_trainee_info_user_info_studentId",
                table: "trainee_info");

            migrationBuilder.DropIndex(
                name: "IX_trainee_info_organizationId",
                table: "trainee_info");

            migrationBuilder.DropIndex(
                name: "IX_trainee_info_studentId",
                table: "trainee_info");

            migrationBuilder.DropIndex(
                name: "IX_trainee_info_supervisorId",
                table: "trainee_info");

            migrationBuilder.AlterColumn<int>(
                name: "supervisorId",
                table: "trainee_info",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "studentId",
                table: "trainee_info",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "organizationId",
                table: "trainee_info",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "supervisorId",
                table: "trainee_info",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "studentId",
                table: "trainee_info",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "organizationId",
                table: "trainee_info",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_trainee_info_organizationId",
                table: "trainee_info",
                column: "organizationId");

            migrationBuilder.CreateIndex(
                name: "IX_trainee_info_studentId",
                table: "trainee_info",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_trainee_info_supervisorId",
                table: "trainee_info",
                column: "supervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_trainee_info_organization_info_organizationId",
                table: "trainee_info",
                column: "organizationId",
                principalTable: "organization_info",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_trainee_info_supervisor_info_supervisorId",
                table: "trainee_info",
                column: "supervisorId",
                principalTable: "supervisor_info",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_trainee_info_user_info_studentId",
                table: "trainee_info",
                column: "studentId",
                principalTable: "user_info",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
