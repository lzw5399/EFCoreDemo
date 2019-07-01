using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo2.Migrations
{
    public partial class Schemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "tt");

            migrationBuilder.CreateTable(
                name: "Schemas",
                schema: "tt",
                columns: table => new
                {
                    Id = table.Column<byte[]>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schemas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schemas",
                schema: "tt");
        }
    }
}
