using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class RefactoringClassStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cities_CityID",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CityID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "UserCityCityID",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCityCityID",
                table: "Locations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCityCityID",
                table: "Users",
                column: "UserCityCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationCityCityID",
                table: "Locations",
                column: "LocationCityCityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cities_LocationCityCityID",
                table: "Locations",
                column: "LocationCityCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_UserCityCityID",
                table: "Users",
                column: "UserCityCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cities_LocationCityCityID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_UserCityCityID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserCityCityID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Locations_LocationCityCityID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "UserCityCityID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LocationCityCityID",
                table: "Locations");

            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID1 = table.Column<int>(type: "int", nullable: true),
                    UserID2 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_Matches_Users_UserID1",
                        column: x => x.UserID1,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Users_UserID2",
                        column: x => x.UserID2,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityID",
                table: "Locations",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserID1",
                table: "Matches",
                column: "UserID1");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserID2",
                table: "Matches",
                column: "UserID2");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cities_CityID",
                table: "Locations",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
