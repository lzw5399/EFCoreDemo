using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreDemo2.Migrations
{
    public partial class addowned2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    MailFrom = table.Column<string>(nullable: true),
                    MailTo = table.Column<string>(nullable: true),
                    EmailContent_Title = table.Column<string>(nullable: true),
                    EmailContent_Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");
        }
    }
}
