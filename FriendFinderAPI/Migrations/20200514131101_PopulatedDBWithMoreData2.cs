using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class PopulatedDBWithMoreData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Cities_EventCityCityID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Hobbies_EventHobbyHobbyID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_EventResposibleUserID",
                table: "Events");

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

            migrationBuilder.DropIndex(
                name: "IX_Events_EventCityCityID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventHobbyHobbyID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventResposibleUserID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserCityCityID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LocationCityCityID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "EventCityCityID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventHobbyHobbyID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventResposibleUserID",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "UserCityID",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationCityID",
                table: "Locations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventCityID",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventHobbyID",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventResposibleID",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                columns: new[] { "EventCityID", "EventHobbyID", "EventResposibleID" },
                values: new object[] { 18153, 297, 1 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                columns: new[] { "EventCityID", "EventHobbyID", "EventResposibleID" },
                values: new object[] { 18133, 922, 3 });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 1,
                column: "LocationCityID",
                value: 18153);

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2,
                column: "LocationCityID",
                value: 18133);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UserCityID",
                value: 18153);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 2,
                column: "UserCityID",
                value: 18153);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3,
                column: "UserCityID",
                value: 18133);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCityID",
                table: "Users",
                column: "UserCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationCityID",
                table: "Locations",
                column: "LocationCityID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Cities_EventCityID",
                table: "Events",
                column: "EventCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Hobbies_EventHobbyID",
                table: "Events",
                column: "EventHobbyID",
                principalTable: "Hobbies",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_EventResposibleID",
                table: "Events",
                column: "EventResposibleID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cities_LocationCityID",
                table: "Locations",
                column: "LocationCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Cities_UserCityID",
                table: "Users",
                column: "UserCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Cities_EventCityID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Hobbies_EventHobbyID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Users_EventResposibleID",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cities_LocationCityID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Cities_UserCityID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserCityID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Locations_LocationCityID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventCityID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventHobbyID",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_EventResposibleID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "UserCityID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LocationCityID",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "EventCityID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventHobbyID",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventResposibleID",
                table: "Events");

            migrationBuilder.AddColumn<int>(
                name: "UserCityCityID",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationCityCityID",
                table: "Locations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventCityCityID",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventHobbyHobbyID",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EventResposibleUserID",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserCityCityID",
                table: "Users",
                column: "UserCityCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationCityCityID",
                table: "Locations",
                column: "LocationCityCityID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Cities_EventCityCityID",
                table: "Events",
                column: "EventCityCityID",
                principalTable: "Cities",
                principalColumn: "CityID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Hobbies_EventHobbyHobbyID",
                table: "Events",
                column: "EventHobbyHobbyID",
                principalTable: "Hobbies",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Users_EventResposibleUserID",
                table: "Events",
                column: "EventResposibleUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);

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
    }
}
