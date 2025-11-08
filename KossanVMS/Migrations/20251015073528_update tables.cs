using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class updatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "photo_path",
                table: "visitor_photos",
                newName: "upload_photo_path");

            migrationBuilder.AddColumn<string>(
                name: "capture_photo_path",
                table: "visitor_photos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "upload_date",
                table: "visitor_photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "capture_photo_path",
                table: "visitor_photos");

            migrationBuilder.DropColumn(
                name: "upload_date",
                table: "visitor_photos");

            migrationBuilder.RenameColumn(
                name: "upload_photo_path",
                table: "visitor_photos",
                newName: "photo_path");
        }
    }
}
