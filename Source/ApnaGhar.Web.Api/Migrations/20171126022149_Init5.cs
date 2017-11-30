using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class Init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupContinent",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "LookupContinent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupContinent",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "LookupContinent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Listing",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CurrencyTypeID = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listing", x => x.ListingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listing");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "LookupContinent");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LookupContinent");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "LookupContinent");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LookupContinent");
        }
    }
}
