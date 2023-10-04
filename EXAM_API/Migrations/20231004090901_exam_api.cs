using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EXAM_API.Migrations
{
    /// <inheritdoc />
    public partial class exam_api : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments_Tbl",
                columns: table => new
                {
                    code_department = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_department = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    number_of_personals = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments_Tbl", x => x.code_department);
                });

            migrationBuilder.CreateTable(
                name: "Employees_Tbl",
                columns: table => new
                {
                    code_employee = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name_employee = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    rank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code_department = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees_Tbl", x => x.code_employee);
                    table.ForeignKey(
                        name: "FK_Employees_Tbl_Departments_Tbl_code_department",
                        column: x => x.code_department,
                        principalTable: "Departments_Tbl",
                        principalColumn: "code_department",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Tbl_code_department",
                table: "Employees_Tbl",
                column: "code_department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees_Tbl");

            migrationBuilder.DropTable(
                name: "Departments_Tbl");
        }
    }
}
