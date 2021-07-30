using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentProgram.DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentNumber = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    facultyName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    departmentName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
