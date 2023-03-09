using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class Added_Tables_BestCollectionModels_AND_BestCollectionitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BestCollectionModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 63, nullable: false),
                    Leftimg = table.Column<string>(maxLength: 100, nullable: false),
                    Modelimg = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestCollectionModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BestCollectionitems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(maxLength: 63, nullable: false),
                    Img = table.Column<string>(maxLength: 100, nullable: false),
                    BestCollectionModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BestCollectionitems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BestCollectionitems_BestCollectionModels_BestCollectionModelId",
                        column: x => x.BestCollectionModelId,
                        principalTable: "BestCollectionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BestCollectionitems_BestCollectionModelId",
                table: "BestCollectionitems",
                column: "BestCollectionModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BestCollectionitems");

            migrationBuilder.DropTable(
                name: "BestCollectionModels");
        }
    }
}
