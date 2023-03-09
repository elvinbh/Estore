using Microsoft.EntityFrameworkCore.Migrations;

namespace Estore.Migrations
{
    public partial class update_table_posttags : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Tags_TagsId",
                table: "PostTags");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "PostTags");

            migrationBuilder.AlterColumn<int>(
                name: "TagsId",
                table: "PostTags",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Tags_TagsId",
                table: "PostTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostTags_Tags_TagsId",
                table: "PostTags");

            migrationBuilder.AlterColumn<int>(
                name: "TagsId",
                table: "PostTags",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "PostTags",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_PostTags_Tags_TagsId",
                table: "PostTags",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
