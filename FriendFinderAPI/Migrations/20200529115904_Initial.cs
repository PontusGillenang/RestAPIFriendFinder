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
                    { 1, "Sverige", "Västra Götaland", "Göteborg" },
                    { 2, "Sverige", "Stockholm", "Stockholm" },
                    { 3, "Sverige", "Skåne", "Malmö" },
                    { 4, "Norge", "Oslo", "Oslo" },
                    { 5, "Danmark", "Köpenhamn", "Köpenhamn" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "HobbyId", "HobbyName" },
                values: new object[,]
                {
                    { 1, "3D printing" },
                    { 2, "Acting" },
                    { 3, "Adventure racing" },
                    { 4, "Airsoft" },
                    { 5, "Alpine skiing" },
                    { 6, "Amateur Astronomy" },
                    { 7, "Beer Pong" },
                    { 8, "Biathlon" },
                    { 9, "Bird watching" },
                    { 10, "Brännboll" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "CityId", "EventName", "HobbyId" },
                values: new object[,]
                {
                    { 4, 3, "Malmö for Biathlon in the World", 8 },
                    { 5, 4, "Nightime in Oslo with The Stars", 6 },
                    { 3, 2, "Amatuer Airsoft Mayhem", 4 },
                    { 2, 1, "Beginners Acting Club", 2 },
                    { 1, 1, "3D Print Workshop", 1 },
                    { 6, 5, "Danske Ølefest me Beer Pong", 7 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "CityId", "LocationName" },
                values: new object[,]
                {
                    { 10, 5, "Nytorv" },
                    { 9, 5, "Nyhavn" },
                    { 8, 4, "Domkirke" },
                    { 7, 4, "Kampen" },
                    { 5, 3, "Stora Torget" },
                    { 4, 2, "Södermalm" },
                    { 3, 2, "Skansen" },
                    { 2, 1, "Haga Teatern" },
                    { 6, 3, "Triangeln" },
                    { 1, 1, "Chalmers Tekniska Högskola" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CityId", "UserAdress", "UserAge", "UserName", "UserPhoneNumber" },
                values: new object[,]
                {
                    { 3, 3, "Karl Andersgatan 6", 24, "Petra Levinman", "+46XXXXXXX2" },
                    { 10, 3, "Opalgatan 54", 28, "William Morberg", "+46XXXXXXX9" },
                    { 9, 2, "Vättlegatan 2", 27, "Ina Pålström", "+46XXXXXXX8" },
                    { 4, 4, "Beringsväg 10", 25, "Pontus Bergman", "+47XXXXXXX3" },
                    { 5, 4, "Kongasnåret 1", 43, "Olle Kvist", "+47XXXXXXX4" },
                    { 8, 2, "Djurgårdsvägen 21", 26, "Pelle Plutter", "+46XXXXXXX7" },
                    { 2, 5, "Knudsgate 15", 22, "Peder Åborg", "+45XXXXXXX1" },
                    { 6, 5, "Gregorstande 6", 32, "Christina Kerlpalm", "+45XXXXXXX5" },
                    { 7, 1, "Kungsportsavenyn 3", 34, "Osborn Börjesson", "+46XXXXXXX6" },
                    { 1, 1, "Drottninggatan 2", 20, "Sebbe Persson", "+46XXXXXXX" }
                });

            migrationBuilder.InsertData(
                table: "EventUsers",
                columns: new[] { "EventId", "UserId", "UserIsResponsible" },
                values: new object[,]
                {
                    { 4, 6, false },
                    { 6, 10, false },
                    { 6, 9, true },
                    { 5, 8, false },
                    { 5, 7, true },
                    { 3, 4, false },
                    { 3, 3, true },
                    { 1, 2, false },
                    { 1, 1, true },
                    { 4, 5, true }
                });

            migrationBuilder.InsertData(
                table: "HobbyLocations",
                columns: new[] { "HobbyId", "LocationId" },
                values: new object[,]
                {
                    { 7, 9 },
                    { 1, 1 },
                    { 8, 6 },
                    { 6, 6 },
                    { 4, 3 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "HobbyUsers",
                columns: new[] { "HobbyId", "UserId", "SkillLevel" },
                values: new object[,]
                {
                    { 7, 10, 1 },
                    { 3, 3, 2 },
                    { 1, 2, 1 },
                    { 8, 6, 0 },
                    { 7, 9, 2 },
                    { 6, 8, 2 },
                    { 6, 7, 0 },
                    { 1, 1, 3 },
                    { 3, 4, 0 },
                    { 8, 5, 1 }
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
