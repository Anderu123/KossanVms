using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class Edittables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visitors_visitor_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_affiliations_visitors_visitor_id",
                table: "visitor_affiliations");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_category_links_visitors_visitor_id",
                table: "visitor_category_links");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_contacts_visitors_visitor_id",
                table: "visitor_contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_photos_visitors_visitor_id",
                table: "visitor_photos");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_purpose_links_visitors_visitor_id",
                table: "visitor_purpose_links");

            migrationBuilder.DropTable(
                name: "visitor_blacklists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records");

            migrationBuilder.DropIndex(
                name: "IX_visit_records_visitor_id",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "visit_id",
                table: "visit_records");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "visitors",
                newName: "visitor_no");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "visitor_purpose_links",
                newName: "visitor_no");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_purpose_links_visitor_id_purpose_id",
                table: "visitor_purpose_links",
                newName: "IX_visitor_purpose_links_visitor_no_purpose_id");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "visitor_photos",
                newName: "visitor_no");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_photos_visitor_id",
                table: "visitor_photos",
                newName: "IX_visitor_photos_visitor_no");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "visitor_contacts",
                newName: "visitor_no");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_contacts_visitor_id",
                table: "visitor_contacts",
                newName: "IX_visitor_contacts_visitor_no");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "visitor_category_links",
                newName: "visitor_no");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_category_links_visitor_id_category_id",
                table: "visitor_category_links",
                newName: "IX_visitor_category_links_visitor_no_category_id");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "visitor_affiliations",
                newName: "visitor_no");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_affiliations_visitor_id_company_id_valid_from",
                table: "visitor_affiliations",
                newName: "IX_visitor_affiliations_visitor_no_company_id_valid_from");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "visit_records",
                newName: "visitor_no");

            migrationBuilder.AddColumn<bool>(
                name: "black_list",
                table: "visitors",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "photo_url",
                table: "visitor_photos",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records",
                column: "visitor_no");

            migrationBuilder.CreateTable(
                name: "visitor_branch_links",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_no = table.Column<int>(type: "int", nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_branch_links", x => x.ID);
                    table.ForeignKey(
                        name: "FK_visitor_branch_links_visit_branches_branch_id",
                        column: x => x.branch_id,
                        principalTable: "visit_branches",
                        principalColumn: "branch_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitor_branch_links_visitors_visitor_no",
                        column: x => x.visitor_no,
                        principalTable: "visitors",
                        principalColumn: "visitor_no",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_visitor_no_in_time",
                table: "visit_records",
                columns: new[] { "visitor_no", "in_time" });

            migrationBuilder.CreateIndex(
                name: "IX_visitor_branch_links_branch_id",
                table: "visitor_branch_links",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_branch_links_visitor_no_branch_id",
                table: "visitor_branch_links",
                columns: new[] { "visitor_no", "branch_id" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visitors_visitor_no",
                table: "visit_records",
                column: "visitor_no",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_affiliations_visitors_visitor_no",
                table: "visitor_affiliations",
                column: "visitor_no",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_category_links_visitors_visitor_no",
                table: "visitor_category_links",
                column: "visitor_no",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_contacts_visitors_visitor_no",
                table: "visitor_contacts",
                column: "visitor_no",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_photos_visitors_visitor_no",
                table: "visitor_photos",
                column: "visitor_no",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_purpose_links_visitors_visitor_no",
                table: "visitor_purpose_links",
                column: "visitor_no",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visitors_visitor_no",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_affiliations_visitors_visitor_no",
                table: "visitor_affiliations");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_category_links_visitors_visitor_no",
                table: "visitor_category_links");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_contacts_visitors_visitor_no",
                table: "visitor_contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_photos_visitors_visitor_no",
                table: "visitor_photos");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_purpose_links_visitors_visitor_no",
                table: "visitor_purpose_links");

            migrationBuilder.DropTable(
                name: "visitor_branch_links");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records");

            migrationBuilder.DropIndex(
                name: "IX_visit_records_visitor_no_in_time",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "black_list",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "photo_url",
                table: "visitor_photos");

            migrationBuilder.RenameColumn(
                name: "visitor_no",
                table: "visitors",
                newName: "visitor_id");

            migrationBuilder.RenameColumn(
                name: "visitor_no",
                table: "visitor_purpose_links",
                newName: "visitor_id");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_purpose_links_visitor_no_purpose_id",
                table: "visitor_purpose_links",
                newName: "IX_visitor_purpose_links_visitor_id_purpose_id");

            migrationBuilder.RenameColumn(
                name: "visitor_no",
                table: "visitor_photos",
                newName: "visitor_id");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_photos_visitor_no",
                table: "visitor_photos",
                newName: "IX_visitor_photos_visitor_id");

            migrationBuilder.RenameColumn(
                name: "visitor_no",
                table: "visitor_contacts",
                newName: "visitor_id");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_contacts_visitor_no",
                table: "visitor_contacts",
                newName: "IX_visitor_contacts_visitor_id");

            migrationBuilder.RenameColumn(
                name: "visitor_no",
                table: "visitor_category_links",
                newName: "visitor_id");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_category_links_visitor_no_category_id",
                table: "visitor_category_links",
                newName: "IX_visitor_category_links_visitor_id_category_id");

            migrationBuilder.RenameColumn(
                name: "visitor_no",
                table: "visitor_affiliations",
                newName: "visitor_id");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_affiliations_visitor_no_company_id_valid_from",
                table: "visitor_affiliations",
                newName: "IX_visitor_affiliations_visitor_id_company_id_valid_from");

            migrationBuilder.RenameColumn(
                name: "visitor_no",
                table: "visit_records",
                newName: "visitor_id");

            migrationBuilder.AddColumn<int>(
                name: "visit_id",
                table: "visit_records",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records",
                column: "visit_id");

            migrationBuilder.CreateTable(
                name: "visitor_blacklists",
                columns: table => new
                {
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    is_blacklist = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_blacklists", x => x.visitor_id);
                    table.ForeignKey(
                        name: "FK_visitor_blacklists_visitors_visitor_id",
                        column: x => x.visitor_id,
                        principalTable: "visitors",
                        principalColumn: "visitor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_visitor_id",
                table: "visit_records",
                column: "visitor_id");

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visitors_visitor_id",
                table: "visit_records",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_affiliations_visitors_visitor_id",
                table: "visitor_affiliations",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_category_links_visitors_visitor_id",
                table: "visitor_category_links",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_contacts_visitors_visitor_id",
                table: "visitor_contacts",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_photos_visitors_visitor_id",
                table: "visitor_photos",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_purpose_links_visitors_visitor_id",
                table: "visitor_purpose_links",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
