using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "branch",
                columns: table => new
                {
                    b_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    b_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    b_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    b_status = table.Column<bool>(type: "bit", nullable: false),
                    b_connection_string = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch", x => x.b_id);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    c_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    c_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    c_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    c_status = table.Column<bool>(type: "bit", nullable: false),
                    c_contract = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.c_id);
                });

            migrationBuilder.CreateTable(
                name: "purpose",
                columns: table => new
                {
                    p_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    p_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    p_description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    p_status = table.Column<bool>(type: "bit", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purpose", x => x.p_id);
                });

            migrationBuilder.CreateTable(
                name: "register_type",
                columns: table => new
                {
                    rt_type_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rt_type_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    rt_user_role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_register_type", x => x.rt_type_id);
                });

            migrationBuilder.CreateTable(
                name: "visitor",
                columns: table => new
                {
                    v_no = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    v_id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    v_id_type = table.Column<byte>(type: "tinyint", nullable: false),
                    v_full_name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    v_expiry_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    v_black_list = table.Column<bool>(type: "bit", nullable: false),
                    v_visit_person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    v_vehicle_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    v_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visitor", x => x.v_no);
                    table.UniqueConstraint("AK_visitors_id_no", x => x.v_id_no);
                });

            migrationBuilder.CreateTable(
                name: "vms_users",
                schema: "dbo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    password_hash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    password_salt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    user_role = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vms_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "branch_link",
                columns: table => new
                {
                    bl_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch_link", x => x.bl_id);
                    table.ForeignKey(
                        name: "FK_branch_link_branch_branch_id",
                        column: x => x.branch_id,
                        principalTable: "branch",
                        principalColumn: "b_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_branch_link_visitor_visitor_id_no",
                        column: x => x.visitor_id_no,
                        principalTable: "visitor",
                        principalColumn: "v_id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "category_link",
                columns: table => new
                {
                    cl_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category_link", x => x.cl_id);
                    table.ForeignKey(
                        name: "FK_category_link_category_category_id",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "c_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_category_link_visitor_visitor_id_no",
                        column: x => x.visitor_id_no,
                        principalTable: "visitor",
                        principalColumn: "v_id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    c_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    c_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_state = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_company_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.c_id);
                    table.ForeignKey(
                        name: "FK_contact_visitor_visitor_id_no",
                        column: x => x.visitor_id_no,
                        principalTable: "visitor",
                        principalColumn: "v_id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "photo",
                columns: table => new
                {
                    p_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    p_capture_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    p_upload_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    p_url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    p_capture_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    p_upload_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photo", x => x.p_id);
                    table.ForeignKey(
                        name: "FK_photo_visitor_visitor_id_no",
                        column: x => x.visitor_id_no,
                        principalTable: "visitor",
                        principalColumn: "v_id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "purpose_link",
                columns: table => new
                {
                    pl_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    purpose_id = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_purpose_link", x => x.pl_id);
                    table.ForeignKey(
                        name: "FK_purpose_link_purpose_purpose_id",
                        column: x => x.purpose_id,
                        principalTable: "purpose",
                        principalColumn: "p_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_purpose_link_visitor_visitor_id_no",
                        column: x => x.visitor_id_no,
                        principalTable: "visitor",
                        principalColumn: "v_id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visit_record",
                columns: table => new
                {
                    vr_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    visitor_id_no = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    branch_id = table.Column<int>(type: "int", nullable: false),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    register_type_id = table.Column<int>(type: "int", nullable: true),
                    vr_in_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    vr_out_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    vr_vehicle_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr_remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr_photo_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr_tag_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr_gate_pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr_visit_person = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr_do_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vr_body_temperature = table.Column<decimal>(type: "decimal(4,1)", precision: 4, scale: 1, nullable: true),
                    vr_expiry_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    purpose_id = table.Column<int>(type: "int", nullable: true),
                    VisitRecordContactContactID = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<int>(type: "int", nullable: false),
                    created_by = table.Column<int>(type: "int", nullable: false),
                    created_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<int>(type: "int", nullable: true),
                    updated_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visit_record", x => x.vr_id);
                    table.ForeignKey(
                        name: "FK_visit_record_branch_branch_id",
                        column: x => x.branch_id,
                        principalTable: "branch",
                        principalColumn: "b_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visit_record_category_category_id",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "c_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visit_record_contact_VisitRecordContactContactID",
                        column: x => x.VisitRecordContactContactID,
                        principalTable: "contact",
                        principalColumn: "c_id");
                    table.ForeignKey(
                        name: "FK_visit_record_purpose_purpose_id",
                        column: x => x.purpose_id,
                        principalTable: "purpose",
                        principalColumn: "p_id");
                    table.ForeignKey(
                        name: "FK_visit_record_register_type_register_type_id",
                        column: x => x.register_type_id,
                        principalTable: "register_type",
                        principalColumn: "rt_type_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visit_record_visitor_visitor_id_no",
                        column: x => x.visitor_id_no,
                        principalTable: "visitor",
                        principalColumn: "v_id_no",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_branch_link_branch_id",
                table: "branch_link",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_branch_link_visitor_id_no",
                table: "branch_link",
                column: "visitor_id_no");

            migrationBuilder.CreateIndex(
                name: "IX_category_link_category_id",
                table: "category_link",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_category_link_visitor_id_no",
                table: "category_link",
                column: "visitor_id_no");

            migrationBuilder.CreateIndex(
                name: "IX_contact_visitor_id_no",
                table: "contact",
                column: "visitor_id_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_photo_visitor_id_no",
                table: "photo",
                column: "visitor_id_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_purpose_link_purpose_id",
                table: "purpose_link",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_purpose_link_visitor_id_no",
                table: "purpose_link",
                column: "visitor_id_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visit_record_branch_id",
                table: "visit_record",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_record_category_id",
                table: "visit_record",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_record_purpose_id",
                table: "visit_record",
                column: "purpose_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_record_register_type_id",
                table: "visit_record",
                column: "register_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_visit_record_visitor_id_no",
                table: "visit_record",
                column: "visitor_id_no");

            migrationBuilder.CreateIndex(
                name: "IX_visit_record_VisitRecordContactContactID",
                table: "visit_record",
                column: "VisitRecordContactContactID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "branch_link");

            migrationBuilder.DropTable(
                name: "category_link");

            migrationBuilder.DropTable(
                name: "photo");

            migrationBuilder.DropTable(
                name: "purpose_link");

            migrationBuilder.DropTable(
                name: "visit_record");

            migrationBuilder.DropTable(
                name: "vms_users",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "branch");

            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "purpose");

            migrationBuilder.DropTable(
                name: "register_type");

            migrationBuilder.DropTable(
                name: "visitor");
        }
    }
}
