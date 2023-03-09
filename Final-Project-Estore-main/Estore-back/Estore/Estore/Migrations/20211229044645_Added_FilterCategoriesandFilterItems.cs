using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class Added_FilterCategoriesandFilterItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FilterCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilterItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Filterselect = table.Column<string>(nullable: true),
                    IsDiscount = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false),
                    Productimg = table.Column<string>(nullable: true),
                    FilterCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilterItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilterItems_FilterCategories_FilterCategoryId",
                        column: x => x.FilterCategoryId,
                        principalTable: "FilterCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilterItems_FilterCategoryId",
                table: "FilterItems",
                column: "FilterCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilterItems");

            migrationBuilder.DropTable(
                name: "FilterCategories");
        }
    }
}
