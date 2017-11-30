using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class Init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CurrencyTypeID",
                table: "Listing",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Listing_CurrencyTypeID",
                table: "Listing",
                column: "CurrencyTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_CurrencyType_CurrencyTypeID",
                table: "Listing",
                column: "CurrencyTypeID",
                principalTable: "CurrencyType",
                principalColumn: "CurrencyTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_CurrencyType_CurrencyTypeID",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Listing_CurrencyTypeID",
                table: "Listing");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyTypeID",
                table: "Listing",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
