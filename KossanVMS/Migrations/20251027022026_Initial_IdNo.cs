using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class Initial_IdNo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "register_types",
                columns: table => new
                {
                    register_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    register_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    register_user_role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register_types", x => x.register_type_id);
                });

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
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    category_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    category_status = table.Column<bool>(type: "bit", nullable: false),
                    category_contract = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_categories", x => x.category_id);
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
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_companies", x => x.company_id);
                });

            migrationBuilder.CreateTable(
                name: "visitors",
                columns: table => new
                {
                    visitor_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    id_type = table.Column<byte>(type: "tinyint", nullable: false),
                    full_name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    company_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    expiry_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    black_list = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitors", x => x.visitor_no);
                    table.UniqueConstraint("AK_visitors_id_no", x => x.id_no);
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
                    visit_record_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    company_id = table.Column<int>(type: "int", nullable: true),
                    register_type_id = table.Column<int>(type: "int", nullable: true),
                    in_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    out_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    vehicle_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    in_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    in_photo_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tag_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gate_pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    visit_person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    do_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    body_temperature = table.Column<decimal>(type: "decimal(4,1)", precision: 4, scale: 1, nullable: true),
                    expiry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_records", x => x.visit_record_id);
                    table.ForeignKey(
                        name: "FK_visit_records_register_types_register_type_id",
                        column: x => x.register_type_id,
                        principalTable: "register_types",
                        principalColumn: "register_type_id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visit_records_visitor_companies_company_id",
                        column: x => x.company_id,
                        principalTable: "visitor_companies",
                        principalColumn: "company_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visit_records_visitors_id_no",
                        column: x => x.id_no,
                        principalTable: "visitors",
                        principalColumn: "id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitor_affiliations",
                columns: table => new
                {
                    affiliation_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    company_id = table.Column<int>(type: "int", nullable: false),
                    relationship = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    valid_from = table.Column<DateTime>(type: "datetime2", nullable: true),
                    valid_to = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        name: "FK_visitor_affiliations_visitors_id_no",
                        column: x => x.id_no,
                        principalTable: "visitors",
                        principalColumn: "id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitor_branch_links",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        name: "FK_visitor_branch_links_visitors_id_no",
                        column: x => x.id_no,
                        principalTable: "visitors",
                        principalColumn: "id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitor_category_links",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                        name: "FK_visitor_category_links_visitors_id_no",
                        column: x => x.id_no,
                        principalTable: "visitors",
                        principalColumn: "id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitor_contacts",
                columns: table => new
                {
                    contact_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_contacts", x => x.contact_id);
                    table.ForeignKey(
                        name: "FK_visitor_contacts_visitors_id_no",
                        column: x => x.id_no,
                        principalTable: "visitors",
                        principalColumn: "id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visitor_photos",
                columns: table => new
                {
                    photo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    capture_photo_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    upload_photo_path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    photo_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    capture_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    upload_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor_photos", x => x.photo_id);
                    table.ForeignKey(
                        name: "FK_visitor_photos_visitors_id_no",
                        column: x => x.id_no,
                        principalTable: "visitors",
                        principalColumn: "id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_branch_id",
                table: "visit_records",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_category_id",
                table: "visit_records",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_company_id",
                table: "visit_records",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_id_no",
                table: "visit_records",
                column: "id_no");

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_register_type_id",
                table: "visit_records",
                column: "register_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_affiliations_company_id",
                table: "visitor_affiliations",
                column: "company_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_affiliations_id_no",
                table: "visitor_affiliations",
                column: "id_no");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_branch_links_branch_id",
                table: "visitor_branch_links",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_branch_links_id_no",
                table: "visitor_branch_links",
                column: "id_no");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_category_links_category_id",
                table: "visitor_category_links",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_category_links_id_no",
                table: "visitor_category_links",
                column: "id_no");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_contacts_id_no",
                table: "visitor_contacts",
                column: "id_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visitor_photos_id_no",
                table: "visitor_photos",
                column: "id_no",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "visit_records");

            migrationBuilder.DropTable(
                name: "visitor_affiliations");

            migrationBuilder.DropTable(
                name: "visitor_branch_links");

            migrationBuilder.DropTable(
                name: "visitor_category_links");

            migrationBuilder.DropTable(
                name: "visitor_contacts");

            migrationBuilder.DropTable(
                name: "visitor_photos");

            migrationBuilder.DropTable(
                name: "vms_users");

            migrationBuilder.DropTable(
                name: "register_types");

            migrationBuilder.DropTable(
                name: "visitor_companies");

            migrationBuilder.DropTable(
                name: "visit_branches");

            migrationBuilder.DropTable(
                name: "visit_categories");

            migrationBuilder.DropTable(
                name: "visitors");
        }
    }
}
