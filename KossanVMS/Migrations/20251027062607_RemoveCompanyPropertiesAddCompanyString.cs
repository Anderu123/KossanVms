using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class RemoveCompanyPropertiesAddCompanyString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visitor_companies_company_id",
                table: "visit_records");

            migrationBuilder.DropIndex(
                name: "IX_visit_records_company_id",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "company_id",
                table: "visit_records");

            migrationBuilder.AddColumn<string>(
                name: "company",
                table: "visit_records",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "company",
                table: "visit_records");

            migrationBuilder.AddColumn<int>(
                name: "company_id",
                table: "visit_records",
                type: "int",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 4);

            migrationBuilder.CreateIndex(
                name: "IX_visit_records_company_id",
                table: "visit_records",
                column: "company_id");

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visitor_companies_company_id",
                table: "visit_records",
                column: "company_id",
                principalTable: "visitor_companies",
                principalColumn: "company_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
