using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class update_Post_and_Blogwriter_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogWriterId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogWriterId",
                table: "Posts",
                column: "BlogWriterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_BlogWriters_BlogWriterId",
                table: "Posts",
                column: "BlogWriterId",
                principalTable: "BlogWriters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_BlogWriters_BlogWriterId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_BlogWriterId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "BlogWriterId",
                table: "Posts");
        }
    }
}
