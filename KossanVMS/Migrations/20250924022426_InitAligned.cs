using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class InitAligned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecord_VisitBranches_BranchID",
                table: "VisitRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecord_VisitCategories_CategoryID",
                table: "VisitRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecord_Visitors_VisitorID",
                table: "VisitRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecord_VisitPurpose_PurposeID",
                table: "VisitRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitRecord",
                table: "VisitRecord");

            migrationBuilder.RenameTable(
                name: "VisitRecord",
                newName: "VisitRecords");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecord_VisitorID",
                table: "VisitRecords",
                newName: "IX_VisitRecords_VisitorID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecord_PurposeID",
                table: "VisitRecords",
                newName: "IX_VisitRecords_PurposeID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecord_CategoryID",
                table: "VisitRecords",
                newName: "IX_VisitRecords_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecord_BranchID",
                table: "VisitRecords",
                newName: "IX_VisitRecords_BranchID");

            migrationBuilder.AddColumn<string>(
                name: "ICNo",
                table: "Visitors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitRecords",
                table: "VisitRecords",
                column: "VisitID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecords_VisitBranches_BranchID",
                table: "VisitRecords",
                column: "BranchID",
                principalTable: "VisitBranches",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecords_VisitCategories_CategoryID",
                table: "VisitRecords",
                column: "CategoryID",
                principalTable: "VisitCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecords_Visitors_VisitorID",
                table: "VisitRecords",
                column: "VisitorID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecords_VisitPurpose_PurposeID",
                table: "VisitRecords",
                column: "PurposeID",
                principalTable: "VisitPurpose",
                principalColumn: "PurposeID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecords_VisitBranches_BranchID",
                table: "VisitRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecords_VisitCategories_CategoryID",
                table: "VisitRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecords_Visitors_VisitorID",
                table: "VisitRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitRecords_VisitPurpose_PurposeID",
                table: "VisitRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitRecords",
                table: "VisitRecords");

            migrationBuilder.DropColumn(
                name: "ICNo",
                table: "Visitors");

            migrationBuilder.RenameTable(
                name: "VisitRecords",
                newName: "VisitRecord");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_VisitorID",
                table: "VisitRecord",
                newName: "IX_VisitRecord_VisitorID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_PurposeID",
                table: "VisitRecord",
                newName: "IX_VisitRecord_PurposeID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_CategoryID",
                table: "VisitRecord",
                newName: "IX_VisitRecord_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_BranchID",
                table: "VisitRecord",
                newName: "IX_VisitRecord_BranchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitRecord",
                table: "VisitRecord",
                column: "VisitID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecord_VisitBranches_BranchID",
                table: "VisitRecord",
                column: "BranchID",
                principalTable: "VisitBranches",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecord_VisitCategories_CategoryID",
                table: "VisitRecord",
                column: "CategoryID",
                principalTable: "VisitCategories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecord_Visitors_VisitorID",
                table: "VisitRecord",
                column: "VisitorID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitRecord_VisitPurpose_PurposeID",
                table: "VisitRecord",
                column: "PurposeID",
                principalTable: "VisitPurpose",
                principalColumn: "PurposeID",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
