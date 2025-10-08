using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class InitAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "visit_branches",
                columns: table => new
                {
                    branch_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    branch_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    branch_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    branch_status = table.Column<bool>(type: "bit", nullable: false),
                    branch_connection_string = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_branches", x => x.branch_id);
                });

            migrationBuilder.CreateTable(
                name: "visit_categories",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    category_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    category_status = table.Column<bool>(type: "bit", nullable: false),
                    category_contract = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "visit_purposes",
                columns: table => new
                {
                    purpose_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    purpose_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    purpose_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    purpose_status = table.Column<bool>(type: "bit", nullable: false),
                    purpose_contract = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_purposes", x => x.purpose_id);
                });

            migrationBuilder.CreateTable(
                name: "visitor_companies",
                columns: table => new
                {
                    company_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    company_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    registration_no = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    company_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_companies", x => x.company_id);
                });

            migrationBuilder.CreateTable(
                name: "visitors",
                columns: table => new
                {
                    visitor_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ic_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitors", x => x.visitor_id);
                });

            migrationBuilder.CreateTable(
                name: "vms_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password_hash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    password_salt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    user_role = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: true),
                    created_by = table.Column<int>(type: "int", nullable: true),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vms_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "visit_records",
                columns: table => new
                {
                    visit_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    purpose_id = table.Column<int>(type: "int", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    in_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    out_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    in_pbid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    out_pbid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vehicle_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    in_container = table.Column<byte>(type: "tinyint", nullable: false),
                    in_container_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    out_container = table.Column<byte>(type: "tinyint", nullable: false),
                    out_container_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    in_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    out_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    in_photo_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    out_photo_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gate_pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_records", x => x.visit_id);
                    table.ForeignKey(
                        name: "FK_visit_records_visit_branches_branch_id",
                        column: x => x.branch_id,
                        principalTable: "visit_branches",
                        principalColumn: "branch_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visit_records_visit_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "visit_categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_visit_records_visit_purposes_purpose_id",
                        column: x => x.purpose_id,
                        principalTable: "visit_purposes",
                        principalColumn: "purpose_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_visit_records_visitors_visitor_id",
                        column: x => x.visitor_id,
                        principalTable: "visitors",
                        principalColumn: "visitor_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitor_affiliations",
                columns: table => new
                {
                    affiliation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    company_id = table.Column<int>(type: "int", nullable: false),
                    relationship = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: true),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_affiliations", x => x.affiliation_id);
                    table.ForeignKey(
                        name: "FK_visitor_affiliations_visitor_companies_company_id",
                        column: x => x.company_id,
                        principalTable: "visitor_companies",
                        principalColumn: "company_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitor_affiliations_visitors_visitor_id",
                        column: x => x.visitor_id,
                        principalTable: "visitors",
                        principalColumn: "visitor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visitor_blacklists",
                columns: table => new
                {
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    is_blacklist = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
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

            migrationBuilder.CreateTable(
                name: "visitor_category_links",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_category_links", x => x.ID);
                    table.ForeignKey(
                        name: "FK_visitor_category_links_visit_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "visit_categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitor_category_links_visitors_visitor_id",
                        column: x => x.visitor_id,
                        principalTable: "visitors",
                        principalColumn: "visitor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visitor_contacts",
                columns: table => new
                {
                    contact_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_contacts", x => x.contact_id);
                    table.ForeignKey(
                        name: "FK_visitor_contacts_visitors_visitor_id",
                        column: x => x.visitor_id,
                        principalTable: "visitors",
                        principalColumn: "visitor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visitor_photos",
                columns: table => new
                {
                    photo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    photo_path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    capture_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_photos", x => x.photo_id);
                    table.ForeignKey(
                        name: "FK_visitor_photos_visitors_visitor_id",
                        column: x => x.visitor_id,
                        principalTable: "visitors",
                        principalColumn: "visitor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "visitor_purpose_links",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id = table.Column<int>(type: "int", nullable: false),
                    purpose_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETUTCDATE()"),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_purpose_links", x => x.ID);
                    table.ForeignKey(
                        name: "FK_visitor_purpose_links_visit_purposes_purpose_id",
                        column: x => x.purpose_id,
                        principalTable: "visit_purposes",
                        principalColumn: "purpose_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visitor_purpose_links_visitors_visitor_id",
                        column: x => x.visitor_id,
                        principalTable: "visitors",
                        principalColumn: "visitor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visit_branches_branch_name",
                table: "visit_branches",
                column: "branch_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visit_categories_category_name",
                table: "visit_categories",
                column: "category_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visit_purposes_purpose_name",
                table: "visit_purposes",
                column: "purpose_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_branch_id",
                table: "visit_records",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_category_id",
                table: "visit_records",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_purpose_id",
                table: "visit_records",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_visitor_id",
                table: "visit_records",
                column: "visitor_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_affiliations_company_id",
                table: "visitor_affiliations",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_affiliations_visitor_id_company_id_valid_from",
                table: "visitor_affiliations",
                columns: new[] { "visitor_id", "company_id", "valid_from" });

            migrationBuilder.CreateIndex(
                name: "IX_visitor_category_links_category_id",
                table: "visitor_category_links",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_category_links_visitor_id_category_id",
                table: "visitor_category_links",
                columns: new[] { "visitor_id", "category_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visitor_contacts_visitor_id",
                table: "visitor_contacts",
                column: "visitor_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visitor_photos_visitor_id",
                table: "visitor_photos",
                column: "visitor_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visitor_purpose_links_purpose_id",
                table: "visitor_purpose_links",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_purpose_links_visitor_id_purpose_id",
                table: "visitor_purpose_links",
                columns: new[] { "visitor_id", "purpose_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visitors_ic_no",
                table: "visitors",
                column: "ic_no",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "visit_records");

            migrationBuilder.DropTable(
                name: "visitor_affiliations");

            migrationBuilder.DropTable(
                name: "visitor_blacklists");

            migrationBuilder.DropTable(
                name: "visitor_category_links");

            migrationBuilder.DropTable(
                name: "visitor_contacts");

            migrationBuilder.DropTable(
                name: "visitor_photos");

            migrationBuilder.DropTable(
                name: "visitor_purpose_links");

            migrationBuilder.DropTable(
                name: "vms_users");

            migrationBuilder.DropTable(
                name: "visit_branches");

            migrationBuilder.DropTable(
                name: "visitor_companies");

            migrationBuilder.DropTable(
                name: "visit_categories");

            migrationBuilder.DropTable(
                name: "visit_purposes");

            migrationBuilder.DropTable(
                name: "visitors");
        }
    }
}
