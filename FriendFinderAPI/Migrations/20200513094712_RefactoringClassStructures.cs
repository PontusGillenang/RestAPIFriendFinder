using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class RefactoringClassStructures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Locations_LocationID",
                table: "Hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Users_UserID",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_LocationID",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_UserID",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Hobbies");

            migrationBuilder.CreateTable(
                name: "HobbyLocation",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false),
                    LocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyLocation", x => new { x.HobbyID, x.LocationID });
                    table.ForeignKey(
                        name: "FK_HobbyLocation_Hobbies_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyLocation_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HobbyUser",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyUser", x => new { x.HobbyID, x.UserID });
                    table.ForeignKey(
                        name: "FK_HobbyUser_Hobbies_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyUser_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HobbyLocation_LocationID",
                table: "HobbyLocation",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyUser_UserID",
                table: "HobbyUser",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HobbyLocation");

            migrationBuilder.DropTable(
                name: "HobbyUser");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Hobbies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Hobbies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_LocationID",
                table: "Hobbies",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_UserID",
                table: "Hobbies",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Locations_LocationID",
                table: "Hobbies",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Users_UserID",
                table: "Hobbies",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
