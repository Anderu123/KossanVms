using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class UpdateSnakeCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VisitorBlackList_Visitors_VisitorID",
                table: "VisitorBlackList");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorCompanies_Visitors_VisitorID",
                table: "VisitorCompanies");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorContacts_Visitors_VisitorID",
                table: "VisitorContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_VisitorPhotos_Visitors_VisitorID",
                table: "VisitorPhotos");

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
                name: "PK_Visitors",
                table: "Visitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitRecords",
                table: "VisitRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitPurpose",
                table: "VisitPurpose");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorPhotos",
                table: "VisitorPhotos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorContacts",
                table: "VisitorContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorCompanies",
                table: "VisitorCompanies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitorBlackList",
                table: "VisitorBlackList");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitCategories",
                table: "VisitCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VisitBranches",
                table: "VisitBranches");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "VisitRecords");

            migrationBuilder.DropColumn(
                name: "LastEditUser",
                table: "VisitRecords");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "VisitRecords");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "VisitPurpose");

            migrationBuilder.DropColumn(
                name: "LastEditUser",
                table: "VisitPurpose");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "VisitPurpose");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "VisitorBlackList");

            migrationBuilder.DropColumn(
                name: "LastEditUser",
                table: "VisitorBlackList");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "VisitorBlackList");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "VisitCategories");

            migrationBuilder.DropColumn(
                name: "LastEditUser",
                table: "VisitCategories");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "VisitCategories");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "VisitBranches");

            migrationBuilder.DropColumn(
                name: "LastEditUser",
                table: "VisitBranches");

            migrationBuilder.DropColumn(
                name: "UpdateTime",
                table: "VisitBranches");

            migrationBuilder.RenameTable(
                name: "Visitors",
                newName: "visitors");

            migrationBuilder.RenameTable(
                name: "VisitRecords",
                newName: "visit_records");

            migrationBuilder.RenameTable(
                name: "VisitPurpose",
                newName: "visit_purposes");

            migrationBuilder.RenameTable(
                name: "VisitorPhotos",
                newName: "visitor_photos");

            migrationBuilder.RenameTable(
                name: "VisitorContacts",
                newName: "visitor_contacts");

            migrationBuilder.RenameTable(
                name: "VisitorCompanies",
                newName: "visitor_companies");

            migrationBuilder.RenameTable(
                name: "VisitorBlackList",
                newName: "visitor_blacklists");

            migrationBuilder.RenameTable(
                name: "VisitCategories",
                newName: "visit_categories");

            migrationBuilder.RenameTable(
                name: "VisitBranches",
                newName: "visit_branches");

            migrationBuilder.RenameColumn(
                name: "ICNo",
                table: "visitors",
                newName: "ic_no");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "visitors",
                newName: "full_name");

            migrationBuilder.RenameColumn(
                name: "VisitorID",
                table: "visitors",
                newName: "visitor_id");

            migrationBuilder.RenameColumn(
                name: "VisitorID",
                table: "visit_records",
                newName: "visitor_id");

            migrationBuilder.RenameColumn(
                name: "VehicleNo",
                table: "visit_records",
                newName: "vehicle_no");

            migrationBuilder.RenameColumn(
                name: "PurposeID",
                table: "visit_records",
                newName: "purpose_id");

            migrationBuilder.RenameColumn(
                name: "OutTime",
                table: "visit_records",
                newName: "out_time");

            migrationBuilder.RenameColumn(
                name: "OutRemarks",
                table: "visit_records",
                newName: "out_remarks");

            migrationBuilder.RenameColumn(
                name: "OutPhotoPath",
                table: "visit_records",
                newName: "out_photo_path");

            migrationBuilder.RenameColumn(
                name: "OutPBID",
                table: "visit_records",
                newName: "out_pbid");

            migrationBuilder.RenameColumn(
                name: "OutContainerNO",
                table: "visit_records",
                newName: "out_container_no");

            migrationBuilder.RenameColumn(
                name: "OutContainer",
                table: "visit_records",
                newName: "out_container");

            migrationBuilder.RenameColumn(
                name: "InTime",
                table: "visit_records",
                newName: "in_time");

            migrationBuilder.RenameColumn(
                name: "InRemarks",
                table: "visit_records",
                newName: "in_remarks");

            migrationBuilder.RenameColumn(
                name: "InPhotoPath",
                table: "visit_records",
                newName: "in_photo_path");

            migrationBuilder.RenameColumn(
                name: "InPBID",
                table: "visit_records",
                newName: "in_pbid");

            migrationBuilder.RenameColumn(
                name: "InContainerNO",
                table: "visit_records",
                newName: "in_container_no");

            migrationBuilder.RenameColumn(
                name: "InContainer",
                table: "visit_records",
                newName: "in_container");

            migrationBuilder.RenameColumn(
                name: "GatePass",
                table: "visit_records",
                newName: "gate_pass");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "visit_records",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "BranchID",
                table: "visit_records",
                newName: "branch_id");

            migrationBuilder.RenameColumn(
                name: "VisitID",
                table: "visit_records",
                newName: "visit_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_VisitorID",
                table: "visit_records",
                newName: "IX_visit_records_visitor_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_PurposeID",
                table: "visit_records",
                newName: "IX_visit_records_purpose_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_CategoryID",
                table: "visit_records",
                newName: "IX_visit_records_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitRecords_BranchID",
                table: "visit_records",
                newName: "IX_visit_records_branch_id");

            migrationBuilder.RenameColumn(
                name: "PurposeStatus",
                table: "visit_purposes",
                newName: "purpose_status");

            migrationBuilder.RenameColumn(
                name: "PurposeName",
                table: "visit_purposes",
                newName: "purpose_name");

            migrationBuilder.RenameColumn(
                name: "PurposeDescription",
                table: "visit_purposes",
                newName: "purpose_description");

            migrationBuilder.RenameColumn(
                name: "PurposeContract",
                table: "visit_purposes",
                newName: "purpose_contract");

            migrationBuilder.RenameColumn(
                name: "PurposeID",
                table: "visit_purposes",
                newName: "purpose_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitPurpose_PurposeName",
                table: "visit_purposes",
                newName: "IX_visit_purposes_purpose_name");

            migrationBuilder.RenameColumn(
                name: "VisitorID",
                table: "visitor_photos",
                newName: "visitor_id");

            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "visitor_photos",
                newName: "photo_path");

            migrationBuilder.RenameColumn(
                name: "CaptureDate",
                table: "visitor_photos",
                newName: "capture_date");

            migrationBuilder.RenameColumn(
                name: "PhotoID",
                table: "visitor_photos",
                newName: "photo_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorPhotos_VisitorID",
                table: "visitor_photos",
                newName: "IX_visitor_photos_visitor_id");

            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "visitor_contacts",
                newName: "tel");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "visitor_contacts",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "PostCode",
                table: "visitor_contacts",
                newName: "postcode");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "visitor_contacts",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "visitor_contacts",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "VisitorID",
                table: "visitor_contacts",
                newName: "visitor_id");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "visitor_contacts",
                newName: "contact_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorContacts_VisitorID",
                table: "visitor_contacts",
                newName: "IX_visitor_contacts_visitor_id");

            migrationBuilder.RenameColumn(
                name: "Company",
                table: "visitor_companies",
                newName: "company");

            migrationBuilder.RenameColumn(
                name: "VisitorID",
                table: "visitor_companies",
                newName: "visitor_id");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "visitor_companies",
                newName: "company_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitorCompanies_VisitorID",
                table: "visitor_companies",
                newName: "IX_visitor_companies_visitor_id");

            migrationBuilder.RenameColumn(
                name: "IsBlackList",
                table: "visitor_blacklists",
                newName: "is_blacklist");

            migrationBuilder.RenameColumn(
                name: "VisitorID",
                table: "visitor_blacklists",
                newName: "visitor_id");

            migrationBuilder.RenameColumn(
                name: "CategoryStatus",
                table: "visit_categories",
                newName: "category_status");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "visit_categories",
                newName: "category_name");

            migrationBuilder.RenameColumn(
                name: "CategoryDescription",
                table: "visit_categories",
                newName: "category_description");

            migrationBuilder.RenameColumn(
                name: "CategoryContract",
                table: "visit_categories",
                newName: "category_contract");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "visit_categories",
                newName: "category_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitCategories_CategoryName",
                table: "visit_categories",
                newName: "IX_visit_categories_category_name");

            migrationBuilder.RenameColumn(
                name: "BranchStatus",
                table: "visit_branches",
                newName: "branch_status");

            migrationBuilder.RenameColumn(
                name: "BranchName",
                table: "visit_branches",
                newName: "branch_name");

            migrationBuilder.RenameColumn(
                name: "BranchDescription",
                table: "visit_branches",
                newName: "branch_description");

            migrationBuilder.RenameColumn(
                name: "BranchContract",
                table: "visit_branches",
                newName: "branch_contract");

            migrationBuilder.RenameColumn(
                name: "BranchID",
                table: "visit_branches",
                newName: "branch_id");

            migrationBuilder.RenameIndex(
                name: "IX_VisitBranches_BranchName",
                table: "visit_branches",
                newName: "IX_visit_branches_branch_name");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visitors",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visitors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visitors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visitors",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visit_records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visit_records",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visit_records",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visit_records",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visit_records",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visit_purposes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visit_purposes",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visit_purposes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visit_purposes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visit_purposes",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visitor_photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visitor_photos",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visitor_photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visitor_photos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visitor_photos",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visitor_contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visitor_contacts",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visitor_contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visitor_contacts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visitor_contacts",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visitor_companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visitor_companies",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visitor_companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visitor_companies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visitor_companies",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visitor_blacklists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visitor_blacklists",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visitor_blacklists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visitor_blacklists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visitor_blacklists",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visit_categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visit_categories",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visit_categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visit_categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visit_categories",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "visit_branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                table: "visit_branches",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "status",
                table: "visit_branches",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "visit_branches",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_date",
                table: "visit_branches",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visitors",
                table: "visitors",
                column: "visitor_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records",
                column: "visit_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_purposes",
                table: "visit_purposes",
                column: "purpose_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visitor_photos",
                table: "visitor_photos",
                column: "photo_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visitor_contacts",
                table: "visitor_contacts",
                column: "contact_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visitor_companies",
                table: "visitor_companies",
                column: "company_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visitor_blacklists",
                table: "visitor_blacklists",
                column: "visitor_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_categories",
                table: "visit_categories",
                column: "category_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_visit_branches",
                table: "visit_branches",
                column: "branch_id");

            migrationBuilder.CreateIndex(
                name: "IX_visitors_ic_no",
                table: "visitors",
                column: "ic_no",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visit_branches_branch_id",
                table: "visit_records",
                column: "branch_id",
                principalTable: "visit_branches",
                principalColumn: "branch_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visit_categories_category_id",
                table: "visit_records",
                column: "category_id",
                principalTable: "visit_categories",
                principalColumn: "category_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visit_purposes_purpose_id",
                table: "visit_records",
                column: "purpose_id",
                principalTable: "visit_purposes",
                principalColumn: "purpose_id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_visit_records_visitors_visitor_id",
                table: "visit_records",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_blacklists_visitors_visitor_id",
                table: "visitor_blacklists",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_companies_visitors_visitor_id",
                table: "visitor_companies",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_contacts_visitors_visitor_id",
                table: "visitor_contacts",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_visitor_photos_visitors_visitor_id",
                table: "visitor_photos",
                column: "visitor_id",
                principalTable: "visitors",
                principalColumn: "visitor_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visit_branches_branch_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visit_categories_category_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visit_purposes_purpose_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visit_records_visitors_visitor_id",
                table: "visit_records");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_blacklists_visitors_visitor_id",
                table: "visitor_blacklists");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_companies_visitors_visitor_id",
                table: "visitor_companies");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_contacts_visitors_visitor_id",
                table: "visitor_contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_visitor_photos_visitors_visitor_id",
                table: "visitor_photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visitors",
                table: "visitors");

            migrationBuilder.DropIndex(
                name: "IX_visitors_ic_no",
                table: "visitors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visitor_photos",
                table: "visitor_photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visitor_contacts",
                table: "visitor_contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visitor_companies",
                table: "visitor_companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visitor_blacklists",
                table: "visitor_blacklists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_records",
                table: "visit_records");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_purposes",
                table: "visit_purposes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_categories",
                table: "visit_categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_visit_branches",
                table: "visit_branches");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visitors");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visitor_photos");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visitor_photos");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visitor_photos");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visitor_photos");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visitor_photos");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visitor_contacts");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visitor_contacts");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visitor_contacts");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visitor_contacts");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visitor_contacts");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visitor_companies");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visitor_companies");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visitor_companies");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visitor_companies");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visitor_companies");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visitor_blacklists");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visitor_blacklists");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visitor_blacklists");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visitor_blacklists");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visitor_blacklists");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visit_records");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visit_purposes");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visit_purposes");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visit_purposes");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visit_purposes");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visit_purposes");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visit_categories");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visit_categories");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visit_categories");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visit_categories");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visit_categories");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "visit_branches");

            migrationBuilder.DropColumn(
                name: "created_date",
                table: "visit_branches");

            migrationBuilder.DropColumn(
                name: "status",
                table: "visit_branches");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "visit_branches");

            migrationBuilder.DropColumn(
                name: "updated_date",
                table: "visit_branches");

            migrationBuilder.RenameTable(
                name: "visitors",
                newName: "Visitors");

            migrationBuilder.RenameTable(
                name: "visitor_photos",
                newName: "VisitorPhotos");

            migrationBuilder.RenameTable(
                name: "visitor_contacts",
                newName: "VisitorContacts");

            migrationBuilder.RenameTable(
                name: "visitor_companies",
                newName: "VisitorCompanies");

            migrationBuilder.RenameTable(
                name: "visitor_blacklists",
                newName: "VisitorBlackList");

            migrationBuilder.RenameTable(
                name: "visit_records",
                newName: "VisitRecords");

            migrationBuilder.RenameTable(
                name: "visit_purposes",
                newName: "VisitPurpose");

            migrationBuilder.RenameTable(
                name: "visit_categories",
                newName: "VisitCategories");

            migrationBuilder.RenameTable(
                name: "visit_branches",
                newName: "VisitBranches");

            migrationBuilder.RenameColumn(
                name: "ic_no",
                table: "Visitors",
                newName: "ICNo");

            migrationBuilder.RenameColumn(
                name: "full_name",
                table: "Visitors",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "Visitors",
                newName: "VisitorID");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "VisitorPhotos",
                newName: "VisitorID");

            migrationBuilder.RenameColumn(
                name: "photo_path",
                table: "VisitorPhotos",
                newName: "PhotoPath");

            migrationBuilder.RenameColumn(
                name: "capture_date",
                table: "VisitorPhotos",
                newName: "CaptureDate");

            migrationBuilder.RenameColumn(
                name: "photo_id",
                table: "VisitorPhotos",
                newName: "PhotoID");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_photos_visitor_id",
                table: "VisitorPhotos",
                newName: "IX_VisitorPhotos_VisitorID");

            migrationBuilder.RenameColumn(
                name: "tel",
                table: "VisitorContacts",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "VisitorContacts",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "postcode",
                table: "VisitorContacts",
                newName: "PostCode");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "VisitorContacts",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "VisitorContacts",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "VisitorContacts",
                newName: "VisitorID");

            migrationBuilder.RenameColumn(
                name: "contact_id",
                table: "VisitorContacts",
                newName: "ContactID");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_contacts_visitor_id",
                table: "VisitorContacts",
                newName: "IX_VisitorContacts_VisitorID");

            migrationBuilder.RenameColumn(
                name: "company",
                table: "VisitorCompanies",
                newName: "Company");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "VisitorCompanies",
                newName: "VisitorID");

            migrationBuilder.RenameColumn(
                name: "company_id",
                table: "VisitorCompanies",
                newName: "CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_visitor_companies_visitor_id",
                table: "VisitorCompanies",
                newName: "IX_VisitorCompanies_VisitorID");

            migrationBuilder.RenameColumn(
                name: "is_blacklist",
                table: "VisitorBlackList",
                newName: "IsBlackList");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "VisitorBlackList",
                newName: "VisitorID");

            migrationBuilder.RenameColumn(
                name: "visitor_id",
                table: "VisitRecords",
                newName: "VisitorID");

            migrationBuilder.RenameColumn(
                name: "vehicle_no",
                table: "VisitRecords",
                newName: "VehicleNo");

            migrationBuilder.RenameColumn(
                name: "purpose_id",
                table: "VisitRecords",
                newName: "PurposeID");

            migrationBuilder.RenameColumn(
                name: "out_time",
                table: "VisitRecords",
                newName: "OutTime");

            migrationBuilder.RenameColumn(
                name: "out_remarks",
                table: "VisitRecords",
                newName: "OutRemarks");

            migrationBuilder.RenameColumn(
                name: "out_photo_path",
                table: "VisitRecords",
                newName: "OutPhotoPath");

            migrationBuilder.RenameColumn(
                name: "out_pbid",
                table: "VisitRecords",
                newName: "OutPBID");

            migrationBuilder.RenameColumn(
                name: "out_container_no",
                table: "VisitRecords",
                newName: "OutContainerNO");

            migrationBuilder.RenameColumn(
                name: "out_container",
                table: "VisitRecords",
                newName: "OutContainer");

            migrationBuilder.RenameColumn(
                name: "in_time",
                table: "VisitRecords",
                newName: "InTime");

            migrationBuilder.RenameColumn(
                name: "in_remarks",
                table: "VisitRecords",
                newName: "InRemarks");

            migrationBuilder.RenameColumn(
                name: "in_photo_path",
                table: "VisitRecords",
                newName: "InPhotoPath");

            migrationBuilder.RenameColumn(
                name: "in_pbid",
                table: "VisitRecords",
                newName: "InPBID");

            migrationBuilder.RenameColumn(
                name: "in_container_no",
                table: "VisitRecords",
                newName: "InContainerNO");

            migrationBuilder.RenameColumn(
                name: "in_container",
                table: "VisitRecords",
                newName: "InContainer");

            migrationBuilder.RenameColumn(
                name: "gate_pass",
                table: "VisitRecords",
                newName: "GatePass");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "VisitRecords",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "branch_id",
                table: "VisitRecords",
                newName: "BranchID");

            migrationBuilder.RenameColumn(
                name: "visit_id",
                table: "VisitRecords",
                newName: "VisitID");

            migrationBuilder.RenameIndex(
                name: "IX_visit_records_visitor_id",
                table: "VisitRecords",
                newName: "IX_VisitRecords_VisitorID");

            migrationBuilder.RenameIndex(
                name: "IX_visit_records_purpose_id",
                table: "VisitRecords",
                newName: "IX_VisitRecords_PurposeID");

            migrationBuilder.RenameIndex(
                name: "IX_visit_records_category_id",
                table: "VisitRecords",
                newName: "IX_VisitRecords_CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_visit_records_branch_id",
                table: "VisitRecords",
                newName: "IX_VisitRecords_BranchID");

            migrationBuilder.RenameColumn(
                name: "purpose_status",
                table: "VisitPurpose",
                newName: "PurposeStatus");

            migrationBuilder.RenameColumn(
                name: "purpose_name",
                table: "VisitPurpose",
                newName: "PurposeName");

            migrationBuilder.RenameColumn(
                name: "purpose_description",
                table: "VisitPurpose",
                newName: "PurposeDescription");

            migrationBuilder.RenameColumn(
                name: "purpose_contract",
                table: "VisitPurpose",
                newName: "PurposeContract");

            migrationBuilder.RenameColumn(
                name: "purpose_id",
                table: "VisitPurpose",
                newName: "PurposeID");

            migrationBuilder.RenameIndex(
                name: "IX_visit_purposes_purpose_name",
                table: "VisitPurpose",
                newName: "IX_VisitPurpose_PurposeName");

            migrationBuilder.RenameColumn(
                name: "category_status",
                table: "VisitCategories",
                newName: "CategoryStatus");

            migrationBuilder.RenameColumn(
                name: "category_name",
                table: "VisitCategories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "category_description",
                table: "VisitCategories",
                newName: "CategoryDescription");

            migrationBuilder.RenameColumn(
                name: "category_contract",
                table: "VisitCategories",
                newName: "CategoryContract");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "VisitCategories",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_visit_categories_category_name",
                table: "VisitCategories",
                newName: "IX_VisitCategories_CategoryName");

            migrationBuilder.RenameColumn(
                name: "branch_status",
                table: "VisitBranches",
                newName: "BranchStatus");

            migrationBuilder.RenameColumn(
                name: "branch_name",
                table: "VisitBranches",
                newName: "BranchName");

            migrationBuilder.RenameColumn(
                name: "branch_description",
                table: "VisitBranches",
                newName: "BranchDescription");

            migrationBuilder.RenameColumn(
                name: "branch_contract",
                table: "VisitBranches",
                newName: "BranchContract");

            migrationBuilder.RenameColumn(
                name: "branch_id",
                table: "VisitBranches",
                newName: "BranchID");

            migrationBuilder.RenameIndex(
                name: "IX_visit_branches_branch_name",
                table: "VisitBranches",
                newName: "IX_VisitBranches_BranchName");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "VisitorBlackList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastEditUser",
                table: "VisitorBlackList",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "VisitorBlackList",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "VisitRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastEditUser",
                table: "VisitRecords",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "VisitRecords",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "VisitPurpose",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastEditUser",
                table: "VisitPurpose",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "VisitPurpose",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "VisitCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastEditUser",
                table: "VisitCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "VisitCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "VisitBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastEditUser",
                table: "VisitBranches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateTime",
                table: "VisitBranches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visitors",
                table: "Visitors",
                column: "VisitorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorPhotos",
                table: "VisitorPhotos",
                column: "PhotoID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorContacts",
                table: "VisitorContacts",
                column: "ContactID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorCompanies",
                table: "VisitorCompanies",
                column: "CompanyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitorBlackList",
                table: "VisitorBlackList",
                column: "VisitorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitRecords",
                table: "VisitRecords",
                column: "VisitID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitPurpose",
                table: "VisitPurpose",
                column: "PurposeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitCategories",
                table: "VisitCategories",
                column: "CategoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VisitBranches",
                table: "VisitBranches",
                column: "BranchID");

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorBlackList_Visitors_VisitorID",
                table: "VisitorBlackList",
                column: "VisitorID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorCompanies_Visitors_VisitorID",
                table: "VisitorCompanies",
                column: "VisitorID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorContacts_Visitors_VisitorID",
                table: "VisitorContacts",
                column: "VisitorID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VisitorPhotos_Visitors_VisitorID",
                table: "VisitorPhotos",
                column: "VisitorID",
                principalTable: "Visitors",
                principalColumn: "VisitorID",
                onDelete: ReferentialAction.Cascade);

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
    }
}
