using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class PopulatedDBWithMoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HobbyLocation_Hobbies_HobbyID",
                table: "HobbyLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyLocation_Locations_LocationID",
                table: "HobbyLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUser_Hobbies_HobbyID",
                table: "HobbyUser");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUser_Users_UserID",
                table: "HobbyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HobbyUser",
                table: "HobbyUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HobbyLocation",
                table: "HobbyLocation");

            migrationBuilder.RenameTable(
                name: "HobbyUser",
                newName: "HobbyUsers");

            migrationBuilder.RenameTable(
                name: "HobbyLocation",
                newName: "HobbyLocations");

            migrationBuilder.RenameIndex(
                name: "IX_HobbyUser_UserID",
                table: "HobbyUsers",
                newName: "IX_HobbyUsers_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_HobbyLocation_LocationID",
                table: "HobbyLocations",
                newName: "IX_HobbyLocations_LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HobbyUsers",
                table: "HobbyUsers",
                columns: new[] { "HobbyID", "UserID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HobbyLocations",
                table: "HobbyLocations",
                columns: new[] { "HobbyID", "LocationID" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "EventCityCityID", "EventHobbyHobbyID", "EventName", "EventResposibleUserID" },
                values: new object[,]
                {
                    { 1, null, null, "Lets Do some Awsome Curling", null },
                    { 2, null, null, "BookClub All About The Books", null }
                });

            migrationBuilder.InsertData(
                table: "HobbyLocations",
                columns: new[] { "HobbyID", "LocationID" },
                values: new object[] { 297, 1 });

            migrationBuilder.InsertData(
                table: "HobbyUsers",
                columns: new[] { "HobbyID", "UserID" },
                values: new object[,]
                {
                    { 297, 1 },
                    { 297, 2 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "LocationCityCityID", "LocationName" },
                values: new object[] { 2, null, "The Castle With Zero Books..." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UserIsTeacher",
                value: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "UserAdress", "UserAge", "UserCityCityID", "UserIsTeacher", "UserName", "UserPhoneNumber" },
                values: new object[] { 3, "MorTest", 28, null, true, "William", "+46XXXXXXX3" });

            migrationBuilder.InsertData(
                table: "HobbyLocations",
                columns: new[] { "HobbyID", "LocationID" },
                values: new object[] { 922, 2 });

            migrationBuilder.InsertData(
                table: "HobbyUsers",
                columns: new[] { "HobbyID", "UserID" },
                values: new object[] { 922, 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyLocations_Hobbies_HobbyID",
                table: "HobbyLocations",
                column: "HobbyID",
                principalTable: "Hobbies",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyLocations_Locations_LocationID",
                table: "HobbyLocations",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUsers_Hobbies_HobbyID",
                table: "HobbyUsers",
                column: "HobbyID",
                principalTable: "Hobbies",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUsers_Users_UserID",
                table: "HobbyUsers",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HobbyLocations_Hobbies_HobbyID",
                table: "HobbyLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyLocations_Locations_LocationID",
                table: "HobbyLocations");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUsers_Hobbies_HobbyID",
                table: "HobbyUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_HobbyUsers_Users_UserID",
                table: "HobbyUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HobbyUsers",
                table: "HobbyUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HobbyLocations",
                table: "HobbyLocations");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HobbyLocations",
                keyColumns: new[] { "HobbyID", "LocationID" },
                keyValues: new object[] { 297, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyLocations",
                keyColumns: new[] { "HobbyID", "LocationID" },
                keyValues: new object[] { 922, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyUsers",
                keyColumns: new[] { "HobbyID", "UserID" },
                keyValues: new object[] { 297, 1 });

            migrationBuilder.DeleteData(
                table: "HobbyUsers",
                keyColumns: new[] { "HobbyID", "UserID" },
                keyValues: new object[] { 297, 2 });

            migrationBuilder.DeleteData(
                table: "HobbyUsers",
                keyColumns: new[] { "HobbyID", "UserID" },
                keyValues: new object[] { 922, 3 });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "HobbyUsers",
                newName: "HobbyUser");

            migrationBuilder.RenameTable(
                name: "HobbyLocations",
                newName: "HobbyLocation");

            migrationBuilder.RenameIndex(
                name: "IX_HobbyUsers_UserID",
                table: "HobbyUser",
                newName: "IX_HobbyUser_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_HobbyLocations_LocationID",
                table: "HobbyLocation",
                newName: "IX_HobbyLocation_LocationID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HobbyUser",
                table: "HobbyUser",
                columns: new[] { "HobbyID", "UserID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_HobbyLocation",
                table: "HobbyLocation",
                columns: new[] { "HobbyID", "LocationID" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserID",
                keyValue: 1,
                column: "UserIsTeacher",
                value: false);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyLocation_Hobbies_HobbyID",
                table: "HobbyLocation",
                column: "HobbyID",
                principalTable: "Hobbies",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyLocation_Locations_LocationID",
                table: "HobbyLocation",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUser_Hobbies_HobbyID",
                table: "HobbyUser",
                column: "HobbyID",
                principalTable: "Hobbies",
                principalColumn: "HobbyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HobbyUser_Users_UserID",
                table: "HobbyUser",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
