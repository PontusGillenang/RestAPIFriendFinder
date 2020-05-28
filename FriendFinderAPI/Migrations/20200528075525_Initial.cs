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
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    CityCountry = table.Column<string>(nullable: true),
                    CityCounty = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    UserAdress = table.Column<string>(nullable: true),
                    UserPhoneNumber = table.Column<string>(nullable: true),
                    UserAge = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(nullable: true),
                    HobbyId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Events_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HobbyLocations",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false),
                    LocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyLocations", x => new { x.HobbyId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_HobbyLocations_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyLocations_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HobbyUsers",
                columns: table => new
                {
                    HobbyId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    SkillLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HobbyUsers", x => new { x.HobbyId, x.UserId });
                    table.ForeignKey(
                        name: "FK_HobbyUsers_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalTable: "Hobbies",
                        principalColumn: "HobbyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HobbyUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventUsers",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    EventUserId = table.Column<int>(nullable: false),
                    UserIsResponsible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventUsers", x => new { x.EventId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EventUsers_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityCountry", "CityCounty", "CityName" },
                values: new object[,]
                {
                    { 1, "Andorra", "Andorra la Vella", "Andorra la Vella" },
                    { 2, "United Arab Emirates", "Umm al Qaywayn", "Umm al Qaywayn" },
                    { 3, "United Arab Emirates", "Raʼs al Khaymah", "Ras al-Khaimah" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "HobbyName" },
                values: new object[,]
                {
                    { 1, "Abseiling" },
                    { 2, "Acting" },
                    { 3, "Action figure" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "CityId", "EventName", "HobbyId" },
                values: new object[,]
                {
                    { 2, 2, "BookClub All About The Books", 1 },
                    { 1, 1, "Lets Do some Awsome Curling", 2 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "CityId", "LocationName" },
                values: new object[,]
                {
                    { 2, 1, "The Castle With Zero Books..." },
                    { 1, 2, "Fjäderborgen" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CityId", "UserAdress", "UserAge", "UserName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { 2, 1, "Kungsgatan", 22, "Oskar", "+46XXXXXXX2" },
                    { 3, 1, "MorTest", 28, "William", "+46XXXXXXX3" },
                    { 1, 2, "Drottninggatan", 20, "Sebbe", "+46XXXXXXX" }
                });

            migrationBuilder.InsertData(
                table: "EventUsers",
                columns: new[] { "EventId", "UserId", "EventUserId", "UserIsResponsible" },
                values: new object[,]
                {
                    { 1, 2, 1, true },
                    { 1, 1, 2, false }
                });

            migrationBuilder.InsertData(
                table: "HobbyLocations",
                columns: new[] { "HobbyId", "LocationId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "HobbyUsers",
                columns: new[] { "HobbyId", "UserId", "SkillLevel" },
                values: new object[,]
                {
                    { 2, 2, 1 },
                    { 3, 3, 3 },
                    { 1, 1, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_CityId",
                table: "Events",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_HobbyId",
                table: "Events",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_EventUsers_UserId",
                table: "EventUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyLocations_LocationId",
                table: "HobbyLocations",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_HobbyUsers_UserId",
                table: "HobbyUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityId",
                table: "Locations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventUsers");

            migrationBuilder.DropTable(
                name: "HobbyLocations");

            migrationBuilder.DropTable(
                name: "HobbyUsers");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
