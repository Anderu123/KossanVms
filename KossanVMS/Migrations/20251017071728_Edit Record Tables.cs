using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class EditRecordTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "in_container",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "in_container_no",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "in_pbid",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "out_container",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "out_container_no",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "out_pbid",
                table: "visit_records");

            migrationBuilder.RenameColumn(
                name: "out_remarks",
                table: "visit_records",
                newName: "visit_person");

            migrationBuilder.RenameColumn(
                name: "out_photo_path",
                table: "visit_records",
                newName: "do_no");

            migrationBuilder.AddColumn<int>(
                name: "visit_record_id",
                table: "visit_records",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "body_temperature",
                table: "visit_records",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "company_id",
                table: "visit_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "expiry_date",
                table: "visit_records",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "register_type_id",
                table: "visit_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records",
                column: "visit_record_id");

            migrationBuilder.CreateTable(
                name: "register_types",
                columns: table => new
                {
                    register_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    register_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    register_user_role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register_types", x => x.register_type_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_company_id",
                table: "visit_records",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_register_type_id",
                table: "visit_records",
                column: "register_type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_register_types_register_type_id",
                table: "visit_records",
                column: "register_type_id",
                principalTable: "register_types",
                principalColumn: "register_type_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visitor_companies_company_id",
                table: "visit_records",
                column: "company_id",
                principalTable: "visitor_companies",
                principalColumn: "company_id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_register_types_register_type_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visitor_companies_company_id",
                table: "visit_records");

            migrationBuilder.DropTable(
                name: "register_types");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records");

            migrationBuilder.DropIndex(
                name: "IX_visit_records_company_id",
                table: "visit_records");

            migrationBuilder.DropIndex(
                name: "IX_visit_records_register_type_id",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "visit_record_id",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "body_temperature",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "company_id",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "expiry_date",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "register_type_id",
                table: "visit_records");

            migrationBuilder.RenameColumn(
                name: "visit_person",
                table: "visit_records",
                newName: "out_remarks");

            migrationBuilder.RenameColumn(
                name: "do_no",
                table: "visit_records",
                newName: "out_photo_path");

            migrationBuilder.AddColumn<byte>(
                name: "in_container",
                table: "visit_records",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "in_container_no",
                table: "visit_records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "in_pbid",
                table: "visit_records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "out_container",
                table: "visit_records",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "out_container_no",
                table: "visit_records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "out_pbid",
                table: "visit_records",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records",
                column: "visitor_no");
        }
    }
}
