using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class ShopCategories_Table_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDiscount = table.Column<bool>(nullable: false),
                    IsNewCollection = table.Column<bool>(nullable: false),
                    IsBestnewDeal = table.Column<bool>(nullable: false),
                    BrandName = table.Column<string>(maxLength: 63, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCategories", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopCategories");
        }
    }
}
