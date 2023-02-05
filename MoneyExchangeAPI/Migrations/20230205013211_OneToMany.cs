using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoneyExchangeAPI.Migrations
{
    /// <inheritdoc />
    public partial class OneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "House",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "House",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsersUserId",
                table: "House",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_House_CityId",
                table: "House",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_House_UsersUserId",
                table: "House",
                column: "UsersUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_House_City_CityId",
                table: "House",
                column: "CityId",
                principalTable: "City",
                principalColumn: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_House_User_UsersUserId",
                table: "House",
                column: "UsersUserId",
                principalTable: "User",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_House_City_CityId",
                table: "House");

            migrationBuilder.DropForeignKey(
                name: "FK_House_User_UsersUserId",
                table: "House");

            migrationBuilder.DropIndex(
                name: "IX_House_CityId",
                table: "House");

            migrationBuilder.DropIndex(
                name: "IX_House_UsersUserId",
                table: "House");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "House");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "House");

            migrationBuilder.DropColumn(
                name: "UsersUserId",
                table: "House");
        }
    }
}
