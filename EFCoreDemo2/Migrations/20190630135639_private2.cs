using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo2.Migrations
{
    public partial class private2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Emails",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Emails");
        }
    }
}
