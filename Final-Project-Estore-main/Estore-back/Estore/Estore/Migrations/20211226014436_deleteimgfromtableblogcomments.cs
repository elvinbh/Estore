using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class deleteimgfromtableblogcomments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "BlogComments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "BlogComments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
