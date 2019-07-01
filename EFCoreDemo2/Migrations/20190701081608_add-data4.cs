using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo2.Migrations
{
    public partial class adddata4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[] { 7, "233", "Science" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[] { 5, "233", "Science" });
        }
    }
}
