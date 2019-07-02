using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo3.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "sequ",
                startValue: 1000L,
                incrementBy: 5);

            migrationBuilder.CreateTable(
                name: "Sequencesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sequencesses", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sequencesses");

            migrationBuilder.DropSequence(
                name: "sequ");
        }
    }
}
