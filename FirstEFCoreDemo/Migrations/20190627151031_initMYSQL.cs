using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstEFCoreDemo.Migrations
{
    public partial class initMYSQL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "IsDelete",
                table: "Blogs",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Blogs");
        }
    }
}
