using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class ShopCategoriesTableAddedImgColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "ShopCategories",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "ShopCategories");
        }
    }
}
