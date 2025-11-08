using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class addidtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_visitors_ic_no",
                table: "visitors");

            migrationBuilder.RenameColumn(
                name: "ic_no",
                table: "visitors",
                newName: "id_no");

            migrationBuilder.AddColumn<byte>(
                name: "id_type",
                table: "visitors",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.CreateIndex(
                name: "IX_visitors_id_type_id_no",
                table: "visitors",
                columns: new[] { "id_type", "id_no" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_visitors_id_type_id_no",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "id_type",
                table: "visitors");

            migrationBuilder.RenameColumn(
                name: "id_no",
                table: "visitors",
                newName: "ic_no");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_ic_no",
                table: "visitors",
                column: "ic_no",
                unique: true);
        }
    }
}
