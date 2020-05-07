using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    CityCountry = table.Column<string>(nullable: true),
                    CityCounty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    UserAdress = table.Column<string>(nullable: true),
                    UserPhoneNumber = table.Column<string>(nullable: true),
                    UserAge = table.Column<int>(nullable: false),
                    UserIsTeacher = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    CityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_Matches_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyActivationLevel = table.Column<int>(nullable: false),
                    HobbyName = table.Column<string>(nullable: true),
                    LocationID = table.Column<int>(nullable: true),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyID);
                    table.ForeignKey(
                        name: "FK_Hobbies_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hobbies_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(nullable: true),
                    EventHobbyHobbyID = table.Column<int>(nullable: true),
                    EventResposibleUserID = table.Column<int>(nullable: true),
                    EventCityCityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Events_Cities_EventCityCityID",
                        column: x => x.EventCityCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Hobbies_EventHobbyHobbyID",
                        column: x => x.EventHobbyHobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Users_EventResposibleUserID",
                        column: x => x.EventResposibleUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityCountry", "CityCounty", "CityName" },
                values: new object[,]
                {
                    { 1, "Sweden", "Västra Götaland", "Göteborg" },
                    { 2, "Denmark", "Malmo", "Malmo" },
                    { 3, "Sweden", "Stockholm", "Stockholm" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyActivationLevel", "HobbyName", "LocationID", "UserID" },
                values: new object[,]
                {
                    { 1, 2, "Badminton", null, null },
                    { 2, 2, "Tennis", null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "CityID", "LocationName" },
                values: new object[] { 1, null, "Fjäderborgen" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserAdress", "UserAge", "UserIsTeacher", "UserName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { 1, "Drottninggatan", 20, false, "Sebbe", "+46XXXXXXX" },
                    { 2, "Kungsgatan", 22, false, "Oskar", "+46XXXXXXX2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventCityCityID",
                table: "Events",
                column: "EventCityCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventHobbyHobbyID",
                table: "Events",
                column: "EventHobbyHobbyID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventResposibleUserID",
                table: "Events",
                column: "EventResposibleUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_LocationID",
                table: "Hobbies",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_UserID",
                table: "Hobbies",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityID",
                table: "Locations",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_UserID",
                table: "Matches",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
