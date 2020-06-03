using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FriendFinderAPI.Migrations
{
    public partial class UpdateEventModelAddedDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EventName",
                table: "Events",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EventEnd",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EventStart",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1,
                columns: new[] { "EventEnd", "EventStart" },
                values: new object[] { new DateTime(2020, 10, 6, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2,
                columns: new[] { "EventEnd", "EventStart" },
                values: new object[] { new DateTime(2020, 11, 14, 20, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 14, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3,
                columns: new[] { "EventEnd", "EventStart" },
                values: new object[] { new DateTime(2020, 12, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 12, 10, 19, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4,
                columns: new[] { "EventEnd", "EventStart" },
                values: new object[] { new DateTime(2020, 7, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 7, 9, 14, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5,
                columns: new[] { "EventEnd", "EventStart" },
                values: new object[] { new DateTime(2020, 11, 20, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 11, 20, 20, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 6,
                columns: new[] { "EventEnd", "EventStart" },
                values: new object[] { new DateTime(2020, 10, 4, 3, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 10, 3, 19, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventEnd",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventStart",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "EventName",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
