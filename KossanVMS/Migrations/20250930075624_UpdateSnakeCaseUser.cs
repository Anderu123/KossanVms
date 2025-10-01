using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class UpdateSnakeCaseUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_VmsUsers",
                table: "VmsUsers");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "VmsUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "VmsUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "VmsUsers");

            migrationBuilder.RenameTable(
                name: "VmsUsers",
                newName: "vms_users");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "vms_users",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "vms_users",
                newName: "user_name");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "vms_users",
                newName: "user_role");

            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "vms_users",
                newName: "password_salt");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "vms_users",
                newName: "password_hash");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "vms_users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "vms_users",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "vms_users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "vms_users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "vms_users",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vms_users",
                table: "vms_users",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_vms_users",
                table: "vms_users");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "vms_users");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "vms_users");

            migrationBuilder.DropColumn(
                name: "status",
                table: "vms_users");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "vms_users");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "vms_users");

            migrationBuilder.RenameTable(
                name: "vms_users",
                newName: "VmsUsers");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "VmsUsers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "user_role",
                table: "VmsUsers",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "user_name",
                table: "VmsUsers",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "password_salt",
                table: "VmsUsers",
                newName: "PasswordSalt");

            migrationBuilder.RenameColumn(
                name: "password_hash",
                table: "VmsUsers",
                newName: "PasswordHash");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "VmsUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "VmsUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "VmsUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_VmsUsers",
                table: "VmsUsers",
                column: "Id");
        }
    }
}
