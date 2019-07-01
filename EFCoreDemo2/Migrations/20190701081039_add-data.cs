using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo2.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[] { 5, "233", "Science" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Type" },
                values: new object[] { 6, "测试匿名类", "Classic" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
