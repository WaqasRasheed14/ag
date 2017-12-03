using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class listingModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 14, 42, 51, 476, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 14, 23, 54, 156, DateTimeKind.Local));

            migrationBuilder.AddForeignKey(
                name: "FK_ListingFacilities_Listing_ListingID",
                table: "ListingFacilities",
                column: "ListingID",
                principalTable: "Listing",
                principalColumn: "ListingID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ListingFacilities_Listing_ListingID",
                table: "ListingFacilities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 14, 23, 54, 156, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 14, 42, 51, 476, DateTimeKind.Local));
        }
    }
}
