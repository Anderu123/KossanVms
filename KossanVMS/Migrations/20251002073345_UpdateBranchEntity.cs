using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class UpdateBranchEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "branch_contract",
                table: "visit_branches",
                newName: "branch_connection_string");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "branch_connection_string",
                table: "visit_branches",
                newName: "branch_contract");
        }
    }
}
