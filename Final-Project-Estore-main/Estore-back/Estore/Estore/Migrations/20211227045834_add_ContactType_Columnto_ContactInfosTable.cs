using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class add_ContactType_Columnto_ContactInfosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ContactType",
                table: "ContactInfos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactType",
                table: "ContactInfos");
        }
    }
}
