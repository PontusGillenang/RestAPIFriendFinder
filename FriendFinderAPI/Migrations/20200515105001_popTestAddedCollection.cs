using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class popTestAddedCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_UserCityID",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_UserCityID",
                table: "Users",
                column: "UserCityID",
                principalTable: "Cities",
                principalColumn: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_UserCityID",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_UserCityID",
                table: "Users",
                column: "UserCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
