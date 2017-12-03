using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class faqModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 483, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 1, 22, 37, 239, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 473, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 1, 22, 37, 224, DateTimeKind.Local));

            migrationBuilder.AlterColumn<string>(
                name: "FAQCategoryName",
                table: "FAQCategory",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "FAQCategoryDescription",
                table: "FAQCategory",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 1, 22, 37, 239, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 483, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 1, 22, 37, 224, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 3, 14, 26, 473, DateTimeKind.Local));

            migrationBuilder.AlterColumn<int>(
                name: "FAQCategoryName",
                table: "FAQCategory",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FAQCategoryDescription",
                table: "FAQCategory",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
