using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class Initial : Migration
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
                name: "Hobbies",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyActivationLevel = table.Column<int>(nullable: false),
                    HobbyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    LocationCityID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_LocationCityID",
                        column: x => x.LocationCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
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
                    UserIsTeacher = table.Column<bool>(nullable: false),
                    UserCityCityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Cities_UserCityCityID",
                        column: x => x.UserCityCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HobbyLocations",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false),
                    LocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyLocations", x => new { x.HobbyID, x.LocationID });
                    table.ForeignKey(
                        name: "FK_HobbyLocations_Hobbies_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyLocations_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(nullable: true),
                    EventHobbyID = table.Column<int>(nullable: false),
                    EventResposibleID = table.Column<int>(nullable: false),
                    EventCityID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Events_Cities_EventCityID",
                        column: x => x.EventCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Hobbies_EventHobbyID",
                        column: x => x.EventHobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Users_EventResposibleID",
                        column: x => x.EventResposibleID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HobbyUsers",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyUsers", x => new { x.HobbyID, x.UserID });
                    table.ForeignKey(
                        name: "FK_HobbyUsers_Hobbies_HobbyID",
                        column: x => x.HobbyID,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyUsers_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityCountry", "CityCounty", "CityName" },
                values: new object[,]
                {
                    { 1, "Andorra", "Andorra la Vella", "Andorra la Vella" },
                    { 2, "United Arab Emirates", "Umm al Qaywayn", "Umm al Qaywayn" },
                    { 3, "United Arab Emirates", "Raʼs al Khaymah", "Ras al-Khaimah" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyID", "HobbyActivationLevel", "HobbyName" },
                values: new object[,]
                {
                    { 1, 0, "Abseiling" },
                    { 2, 0, "Acting" },
                    { 3, 0, "Action figure" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserAdress", "UserAge", "UserCityCityID", "UserIsTeacher", "UserName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { 1, "Drottninggatan", 20, null, true, "Sebbe", "+46XXXXXXX" },
                    { 2, "Kungsgatan", 22, null, false, "Oskar", "+46XXXXXXX2" },
                    { 3, "MorTest", 28, null, true, "William", "+46XXXXXXX3" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "EventCityID", "EventHobbyID", "EventName", "EventResposibleID" },
                values: new object[,]
                {
                    { 1, 1, 2, "Lets Do some Awsome Curling", 1 },
                    { 2, 2, 1, "BookClub All About The Books", 3 }
                });

            migrationBuilder.InsertData(
                table: "HobbyUsers",
                columns: new[] { "HobbyID", "UserID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationCityID", "LocationName" },
                values: new object[,]
                {
                    { 2, 1, "The Castle With Zero Books..." },
                    { 1, 2, "Fjäderborgen" }
                });

            migrationBuilder.InsertData(
                table: "HobbyLocations",
                columns: new[] { "HobbyID", "LocationID" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "HobbyLocations",
                columns: new[] { "HobbyID", "LocationID" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventCityID",
                table: "Events",
                column: "EventCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventHobbyID",
                table: "Events",
                column: "EventHobbyID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_EventResposibleID",
                table: "Events",
                column: "EventResposibleID");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyLocations_LocationID",
                table: "HobbyLocations",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyUsers_UserID",
                table: "HobbyUsers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationCityID",
                table: "Locations",
                column: "LocationCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCityCityID",
                table: "Users",
                column: "UserCityCityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "HobbyLocations");

            migrationBuilder.DropTable(
                name: "HobbyUsers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
