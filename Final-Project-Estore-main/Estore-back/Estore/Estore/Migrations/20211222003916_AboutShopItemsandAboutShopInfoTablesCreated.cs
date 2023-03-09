using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class AboutShopItemsandAboutShopInfoTablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutShopInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutShopInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutShopItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Img = table.Column<string>(nullable: true),
                    AboutShopInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutShopItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutShopItems_AboutShopInfos_AboutShopInfoId",
                        column: x => x.AboutShopInfoId,
                        principalTable: "AboutShopInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutShopItems_AboutShopInfoId",
                table: "AboutShopItems",
                column: "AboutShopInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutShopItems");

            migrationBuilder.DropTable(
                name: "AboutShopInfos");
        }
    }
}
