using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class faqModification2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 17, 34, 710, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 483, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 17, 34, 703, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 473, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 483, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 3, 17, 34, 710, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 473, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 3, 17, 34, 703, DateTimeKind.Local));
        }
    }
}
