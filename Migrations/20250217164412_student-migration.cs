using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student__System_With_Code_First.Migrations
{
    /// <inheritdoc />
    public partial class studentmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "student_tbl",
                columns: table => new
                {
                    stud_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stud_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stud_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stud_phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stud_address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_student_tbl", x => x.stud_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "student_tbl");
        }
    }
}
