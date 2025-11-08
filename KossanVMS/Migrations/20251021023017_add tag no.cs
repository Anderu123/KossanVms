using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class addtagno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "register_types",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "register_types",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "register_types",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "register_types",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "register_types",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_by",
                table: "register_types");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "register_types");

            migrationBuilder.DropColumn(
                name: "status",
                table: "register_types");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "register_types");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "register_types");
        }
    }
}
