using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class removepurposetableasnotrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visit_purposes_purpose_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_purpose_links_visit_purposes_purpose_id",
                table: "visitor_purpose_links");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_purpose_links_visitors_visitor_no",
                table: "visitor_purpose_links");

            migrationBuilder.DropIndex(
                name: "IX_visitor_purpose_links_visitor_no_purpose_id",
                table: "visitor_purpose_links");

            migrationBuilder.DropIndex(
                name: "IX_visit_purposes_purpose_name",
                table: "visit_purposes");

            migrationBuilder.AddColumn<int>(
                name: "VisitorNo1",
                table: "visitor_purpose_links",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_purpose_links_visit_purposes_purpose_id",
                table: "visitor_purpose_links",
                column: "purpose_id",
                principalTable: "visit_purposes",
                principalColumn: "purpose_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_purpose_links_visitors_VisitorNo1",
                table: "visitor_purpose_links",
                column: "VisitorNo1",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visit_purposes_purpose_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_purpose_links_visit_purposes_purpose_id",
                table: "visitor_purpose_links");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_purpose_links_visitors_VisitorNo1",
                table: "visitor_purpose_links");

            migrationBuilder.DropIndex(
                name: "IX_visitor_purpose_links_VisitorNo1",
                table: "visitor_purpose_links");

            migrationBuilder.DropColumn(
                name: "VisitorNo1",
                table: "visitor_purpose_links");

            migrationBuilder.CreateIndex(
                name: "IX_visitor_purpose_links_visitor_no_purpose_id",
                table: "visitor_purpose_links",
                columns: new[] { "visitor_no", "purpose_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_visit_purposes_purpose_name",
                table: "visit_purposes",
                column: "purpose_name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visit_purposes_purpose_id",
                table: "visit_records",
                column: "purpose_id",
                principalTable: "visit_purposes",
                principalColumn: "purpose_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_purpose_links_visit_purposes_purpose_id",
                table: "visitor_purpose_links",
                column: "purpose_id",
                principalTable: "visit_purposes",
                principalColumn: "purpose_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_purpose_links_visitors_visitor_no",
                table: "visitor_purpose_links",
                column: "visitor_no",
                principalTable: "visitors",
                principalColumn: "visitor_no",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
