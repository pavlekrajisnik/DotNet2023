using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirtualDj.Migrations
{
    /// <inheritdoc />
    public partial class UserCharacterRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Pjesme",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pjesme_UserId",
                table: "Pjesme",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pjesme_Users_UserId",
                table: "Pjesme",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pjesme_Users_UserId",
                table: "Pjesme");

            migrationBuilder.DropIndex(
                name: "IX_Pjesme_UserId",
                table: "Pjesme");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Pjesme");
        }
    }
}
