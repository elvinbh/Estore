using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class add_img_Column_to_BlogComments_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "BlogComments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "BlogComments");
        }
    }
}
