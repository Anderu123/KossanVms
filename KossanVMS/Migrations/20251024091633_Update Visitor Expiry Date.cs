using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KossanVMS.Migrations
{
    public partial class UpdateVisitorExpiryDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "expiry_date",
                table: "visitors",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "expiry_date",
                table: "visitors");
        }
    }
}
