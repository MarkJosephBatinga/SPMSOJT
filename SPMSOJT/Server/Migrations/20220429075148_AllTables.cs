using Microsoft.EntityFrameworkCore.Migrations;

namespace SPMSOJT.Server.Migrations
{
    public partial class AllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_info");

            migrationBuilder.CreateTable(
                name: "coordinator_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    barangay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phonenum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schoolemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coordinator_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "organization_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    org_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    branch_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_person = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact_number = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organization_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "supervisor_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middle_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    suffix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    barangay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phonenum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    citizenship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schoolemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idnumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    college = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    schoolname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    school_barangay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    school_city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    school_province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    school_zipcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supervisor_info", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "trainee_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    school_year = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: true),
                    supervisorId = table.Column<int>(type: "int", nullable: true),
                    organizationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainee_info", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainee_info_organization_info_organizationId",
                        column: x => x.organizationId,
                        principalTable: "organization_info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trainee_info_supervisor_info_supervisorId",
                        column: x => x.supervisorId,
                        principalTable: "supervisor_info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trainee_info_user_info_studentId",
                        column: x => x.studentId,
                        principalTable: "user_info",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coordinator_info");

            migrationBuilder.DropTable(
                name: "trainee_info");

            migrationBuilder.DropTable(
                name: "organization_info");

            migrationBuilder.DropTable(
                name: "supervisor_info");

            migrationBuilder.CreateTable(
                name: "address_info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barangay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_address_info", x => x.Id);
                });
        }
    }
}
