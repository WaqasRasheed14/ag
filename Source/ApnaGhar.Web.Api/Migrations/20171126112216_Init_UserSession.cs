using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class Init_UserSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 11, 26, 19, 22, 16, 589, DateTimeKind.Local),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 11, 26, 19, 22, 16, 582, DateTimeKind.Local),
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateTable(
                name: "LookupLoginChannels",
                columns: table => new
                {
                    LoginChannelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChannelDescription = table.Column<string>(nullable: true),
                    ChannelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupLoginChannels", x => x.LoginChannelID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutMe = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    Gender = table.Column<byte>(nullable: false),
                    HashedPassword = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LookupLoginChannels");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 11, 26, 19, 22, 16, 589, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCity",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 11, 26, 19, 22, 16, 582, DateTimeKind.Local));
        }
    }
}
