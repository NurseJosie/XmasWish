using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace XmasWish.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlreadyGifted_Gifts_GiftId",
                table: "AlreadyGifted");

            migrationBuilder.DropForeignKey(
                name: "FK_AlreadyGifted_People_PersonId",
                table: "AlreadyGifted");

            migrationBuilder.DropIndex(
                name: "IX_AlreadyGifted_GiftId",
                table: "AlreadyGifted");

            migrationBuilder.DropIndex(
                name: "IX_AlreadyGifted_PersonId",
                table: "AlreadyGifted");

            migrationBuilder.DropColumn(
                name: "XmasWish",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AlreadyGifted");

            migrationBuilder.DropColumn(
                name: "GiftId",
                table: "AlreadyGifted");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "AlreadyGifted");

            migrationBuilder.RenameColumn(
                name: "XmasWish",
                table: "Gifts",
                newName: "GiftName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GiftName",
                table: "Gifts",
                newName: "XmasWish");

            migrationBuilder.AddColumn<string>(
                name: "XmasWish",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AlreadyGifted",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GiftId",
                table: "AlreadyGifted",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "AlreadyGifted",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AlreadyGifted_GiftId",
                table: "AlreadyGifted",
                column: "GiftId");

            migrationBuilder.CreateIndex(
                name: "IX_AlreadyGifted_PersonId",
                table: "AlreadyGifted",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlreadyGifted_Gifts_GiftId",
                table: "AlreadyGifted",
                column: "GiftId",
                principalTable: "Gifts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlreadyGifted_People_PersonId",
                table: "AlreadyGifted",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id");
        }
    }
}
