using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class ChangedMatchPropertysadas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Users_UserID",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_UserID",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "UserID1",
                table: "Matches",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID2",
                table: "Matches",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserID1",
                table: "Matches",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserID2",
                table: "Matches",
                column: "UserID2");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Users_UserID1",
                table: "Matches",
                column: "UserID1",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Users_UserID2",
                table: "Matches",
                column: "UserID2",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Users_UserID1",
                table: "Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Users_UserID2",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_UserID1",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_UserID2",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "UserID1",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "UserID2",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserID",
                table: "Matches",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Users_UserID",
                table: "Matches",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
