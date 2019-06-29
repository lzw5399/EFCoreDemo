using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstEFCoreDemo.Migrations
{
    public partial class changeToUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_FirstName_LastName",
                table: "Blogs");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_FirstName_LastName",
                table: "Blogs",
                columns: new[] { "FirstName", "LastName" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Blogs_FirstName_LastName",
                table: "Blogs");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_FirstName_LastName",
                table: "Blogs",
                columns: new[] { "FirstName", "LastName" });
        }
    }
}
