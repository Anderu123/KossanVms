using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class removerelationshippurpose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visit_purposes_purpose_id",
                table: "visit_records");

            migrationBuilder.DropTable(
                name: "visitor_purpose_links");

            migrationBuilder.DropTable(
                name: "visit_purposes");

            migrationBuilder.DropIndex(
                name: "IX_visit_records_purpose_id",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "purpose_id",
                table: "visit_records");

            migrationBuilder.AddColumn<string>(
                name: "tag_no",
                table: "visit_records",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tag_no",
                table: "visit_records");

            migrationBuilder.AddColumn<int>(
                name: "purpose_id",
                table: "visit_records",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "visit_purposes",
                columns: table => new
                {
                    purpose_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    purpose_contract = table.Column<bool>(type: "bit", nullable: false),
                    purpose_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    purpose_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    purpose_status = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_purposes", x => x.purpose_id);
                });

            migrationBuilder.CreateTable(
                name: "visitor_purpose_links",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purpose_id = table.Column<int>(type: "int", nullable: false),
                    VisitorNo1 = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    status = table.Column<int>(type: "int", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()"),
                    visitor_no = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_purpose_links", x => x.ID);
                    table.ForeignKey(
                        name: "FK_visitor_purpose_links_visit_purposes_purpose_id",
                        column: x => x.purpose_id,
                        principalTable: "visit_purposes",
                        principalColumn: "purpose_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_visitor_purpose_links_visitors_VisitorNo1",
                        column: x => x.VisitorNo1,
                        principalTable: "visitors",
                        principalColumn: "visitor_no",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_purpose_id",
                table: "visit_records",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_purpose_links_purpose_id",
                table: "visitor_purpose_links",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_purpose_links_VisitorNo1",
                table: "visitor_purpose_links",
                column: "VisitorNo1");

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visit_purposes_purpose_id",
                table: "visit_records",
                column: "purpose_id",
                principalTable: "visit_purposes",
                principalColumn: "purpose_id");
        }
    }
}
