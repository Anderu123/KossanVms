using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Visitors_ICNo",
                table: "Visitors");

            migrationBuilder.DropIndex(
                name: "IX_VisitorPhotos_VisitorID",
                table: "VisitorPhotos");

            migrationBuilder.DropIndex(
                name: "IX_VisitorContacts_VisitorID",
                table: "VisitorContacts");

            migrationBuilder.DropIndex(
                name: "IX_VisitorCompanies_VisitorID",
                table: "VisitorCompanies");

            migrationBuilder.DropColumn(
                name: "ICNo",
                table: "Visitors");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorPhotos_VisitorID",
                table: "VisitorPhotos",
                column: "VisitorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitorContacts_VisitorID",
                table: "VisitorContacts",
                column: "VisitorID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitorCompanies_VisitorID",
                table: "VisitorCompanies",
                column: "VisitorID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_VisitorPhotos_VisitorID",
                table: "VisitorPhotos");

            migrationBuilder.DropIndex(
                name: "IX_VisitorContacts_VisitorID",
                table: "VisitorContacts");

            migrationBuilder.DropIndex(
                name: "IX_VisitorCompanies_VisitorID",
                table: "VisitorCompanies");

            migrationBuilder.AddColumn<string>(
                name: "ICNo",
                table: "Visitors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_ICNo",
                table: "Visitors",
                column: "ICNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitorPhotos_VisitorID",
                table: "VisitorPhotos",
                column: "VisitorID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorContacts_VisitorID",
                table: "VisitorContacts",
                column: "VisitorID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorCompanies_VisitorID",
                table: "VisitorCompanies",
                column: "VisitorID");
        }
    }
}
