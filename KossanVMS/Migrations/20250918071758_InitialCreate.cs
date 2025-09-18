using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitBranches",
                columns: table => new
                {
                    BranchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BranchDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    BranchStatus = table.Column<bool>(type: "bit", nullable: false),
                    BranchContract = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitBranches", x => x.BranchID);
                });

            migrationBuilder.CreateTable(
                name: "VisitCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false),
                    CategoryContract = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitCategories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ICNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorID);
                });

            migrationBuilder.CreateTable(
                name: "VisitPurpose",
                columns: table => new
                {
                    PurposeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PurposeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PurposeDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PurposeStatus = table.Column<bool>(type: "bit", nullable: false),
                    PurposeContract = table.Column<bool>(type: "bit", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitPurpose", x => x.PurposeID);
                });

            migrationBuilder.CreateTable(
                name: "VmsUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VmsUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitorBlackList",
                columns: table => new
                {
                    VisitorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsBlackList = table.Column<bool>(type: "bit", nullable: false),
                    VisitorID1 = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastEditUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorBlackList", x => x.VisitorID);
                    table.ForeignKey(
                        name: "FK_VisitorBlackList_Visitors_VisitorID1",
                        column: x => x.VisitorID1,
                        principalTable: "Visitors",
                        principalColumn: "VisitorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorCompanies",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorID = table.Column<int>(type: "int", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorCompanies", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_VisitorCompanies_Visitors_VisitorID",
                        column: x => x.VisitorID,
                        principalTable: "Visitors",
                        principalColumn: "VisitorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorContacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorContacts", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_VisitorContacts_Visitors_VisitorID",
                        column: x => x.VisitorID,
                        principalTable: "Visitors",
                        principalColumn: "VisitorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitorPhotos",
                columns: table => new
                {
                    PhotoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorID = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CaptureDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorPhotos", x => x.PhotoID);
                    table.ForeignKey(
                        name: "FK_VisitorPhotos_Visitors_VisitorID",
                        column: x => x.VisitorID,
                        principalTable: "Visitors",
                        principalColumn: "VisitorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VisitBranches_BranchName",
                table: "VisitBranches",
                column: "BranchName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitCategories_CategoryName",
                table: "VisitCategories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitorBlackList_VisitorID1",
                table: "VisitorBlackList",
                column: "VisitorID1");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorCompanies_VisitorID",
                table: "VisitorCompanies",
                column: "VisitorID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorContacts_VisitorID",
                table: "VisitorContacts",
                column: "VisitorID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitorPhotos_VisitorID",
                table: "VisitorPhotos",
                column: "VisitorID");

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_ICNo",
                table: "Visitors",
                column: "ICNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_VisitPurpose_PurposeName",
                table: "VisitPurpose",
                column: "PurposeName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitBranches");

            migrationBuilder.DropTable(
                name: "VisitCategories");

            migrationBuilder.DropTable(
                name: "VisitorBlackList");

            migrationBuilder.DropTable(
                name: "VisitorCompanies");

            migrationBuilder.DropTable(
                name: "VisitorContacts");

            migrationBuilder.DropTable(
                name: "VisitorPhotos");

            migrationBuilder.DropTable(
                name: "VisitPurpose");

            migrationBuilder.DropTable(
                name: "VmsUsers");

            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
