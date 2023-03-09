using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class Update_BlogComments_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "BlogComments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurName",
                table: "BlogComments");
        }
    }
}
