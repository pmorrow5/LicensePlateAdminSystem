using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LicensePlateDataAccess.Migrations
{
    public partial class seedlicenseplatesimulateddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LicensePlates",
                columns: new[] { "Id", "FileName", "IsProcessed", "LicensePlateText", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE1.jpg", true, "FUNTIME", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE2.jpg", true, "GVMESPD", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE3.jpg", true, "PULTOYS", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE4.jpg", true, "NCC1701", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE5.jpg", true, "MYCAR01", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE6.jpg", true, "FBIAGNT", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE7.jpg", true, "FLYERS1", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE8.jpg", true, "EMC2FST", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE9.jpg", true, "FSTRNU", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "https://plateimagesyyyymmddxyz.blob.core.windows.net/images/FAKE10.jpg", true, "BACKOFF", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "LicensePlates",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
