using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class Update_ContactInfo_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ContactType",
                table: "ContactInfos",
                maxLength: 64,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ContactType",
                table: "ContactInfos",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64,
                oldNullable: true);
        }
    }
}
