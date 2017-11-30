using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class Init_CheckRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listing");

            migrationBuilder.DropTable(
                name: "LookupLoginChannels");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "CurrencyType");

            migrationBuilder.RenameColumn(
                name: "LookupContinent",
                table: "LookupCountry",
                newName: "ContinentID");

            migrationBuilder.CreateTable(
                name: "LookupState",
                columns: table => new
                {
                    StateID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryID = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    StateDesc = table.Column<string>(nullable: true),
                    StateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupState", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_LookupState_LookupCountry_CountryID",
                        column: x => x.CountryID,
                        principalTable: "LookupCountry",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LookupCity",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityDesc = table.Column<string>(nullable: true),
                    CityName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false),
                    StateID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupCity", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_LookupCity_LookupState_StateID",
                        column: x => x.StateID,
                        principalTable: "LookupState",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LookupCountry_ContinentID",
                table: "LookupCountry",
                column: "ContinentID");

            migrationBuilder.CreateIndex(
                name: "IX_LookupCity_StateID",
                table: "LookupCity",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_LookupState_CountryID",
                table: "LookupState",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_LookupCountry_LookupContinent_ContinentID",
                table: "LookupCountry",
                column: "ContinentID",
                principalTable: "LookupContinent",
                principalColumn: "ContinentID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LookupCountry_LookupContinent_ContinentID",
                table: "LookupCountry");

            migrationBuilder.DropTable(
                name: "LookupCity");

            migrationBuilder.DropTable(
                name: "LookupState");

            migrationBuilder.DropIndex(
                name: "IX_LookupCountry_ContinentID",
                table: "LookupCountry");

            migrationBuilder.RenameColumn(
                name: "ContinentID",
                table: "LookupCountry",
                newName: "LookupContinent");

            migrationBuilder.CreateTable(
                name: "CurrencyType",
                columns: table => new
                {
                    CurrencyTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CurrencyDescription = table.Column<string>(nullable: true),
                    CurrencyName = table.Column<string>(nullable: true),
                    CurrencySymbol = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyType", x => x.CurrencyTypeID);
                });

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
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatePosted = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Listing",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CurrencyTypeID = table.Column<int>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listing", x => x.ListingID);
                    table.ForeignKey(
                        name: "FK_Listing_CurrencyType_CurrencyTypeID",
                        column: x => x.CurrencyTypeID,
                        principalTable: "CurrencyType",
                        principalColumn: "CurrencyTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Listing_CurrencyTypeID",
                table: "Listing",
                column: "CurrencyTypeID");
        }
    }
}
