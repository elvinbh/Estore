using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class CreateTablesAboutTextsandAboutVideos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutTexts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Img = table.Column<string>(nullable: true),
                    Video = table.Column<string>(nullable: true),
                    AboutTextId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutVideos_AboutTexts_AboutTextId",
                        column: x => x.AboutTextId,
                        principalTable: "AboutTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutVideos_AboutTextId",
                table: "AboutVideos",
                column: "AboutTextId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutVideos");

            migrationBuilder.DropTable(
                name: "AboutTexts");
        }
    }
}
