using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ApnaGhar.Web.Api.Migrations
{
    public partial class listingModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "LookupState");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LookupState");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LookupState");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "LookupCountry");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LookupCountry");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LookupCountry");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "LookupContinent");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LookupContinent");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LookupContinent");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "LookupCity");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LookupCity");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "LookupCity");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "FAQCategory");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FAQCategory");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "FAQCategory");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "FAQ");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FAQ");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "FAQ");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "UserLoginChannels",
                newName: "ModifiedAt");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 14, 23, 54, 156, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 3, 57, 4, 392, DateTimeKind.Local));

            migrationBuilder.CreateTable(
                name: "CurrencyType",
                columns: table => new
                {
                    CurrencyTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrencyDescription = table.Column<string>(nullable: true),
                    CurrencyName = table.Column<string>(nullable: true),
                    CurrencySymbol = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrencyType", x => x.CurrencyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "FacilitiesLookup",
                columns: table => new
                {
                    FacilityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FacilityDescription = table.Column<string>(nullable: true),
                    FacilityName = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilitiesLookup", x => x.FacilityID);
                });

            migrationBuilder.CreateTable(
                name: "ListingTypeCategory",
                columns: table => new
                {
                    ListingTypeCategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingTypeCategory", x => x.ListingTypeCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "LookupAvailibility",
                columns: table => new
                {
                    LookupAvailibilityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvailibilityDescription = table.Column<string>(nullable: true),
                    AvailibilityName = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupAvailibility", x => x.LookupAvailibilityID);
                });

            migrationBuilder.CreateTable(
                name: "LookupFurnishing",
                columns: table => new
                {
                    LookupFurnishingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FurnishingItemDescription = table.Column<string>(nullable: true),
                    FurnishingItemName = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupFurnishing", x => x.LookupFurnishingID);
                });

            migrationBuilder.CreateTable(
                name: "LookupLandmark",
                columns: table => new
                {
                    LookupLandmarkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvailibilityDescription = table.Column<string>(nullable: true),
                    AvailibilityName = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupLandmark", x => x.LookupLandmarkID);
                });

            migrationBuilder.CreateTable(
                name: "ListingFacilities",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false),
                    FacilitiesLookupID = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingFacilities", x => new { x.ListingID, x.FacilitiesLookupID });
                    table.ForeignKey(
                        name: "FK_ListingFacilities_FacilitiesLookup_FacilitiesLookupID",
                        column: x => x.FacilitiesLookupID,
                        principalTable: "FacilitiesLookup",
                        principalColumn: "FacilityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListingType",
                columns: table => new
                {
                    ListingTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ListingTypeCategoryID = table.Column<int>(nullable: false),
                    ListingTypeDescription = table.Column<string>(nullable: true),
                    ListingTypeName = table.Column<string>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingType", x => x.ListingTypeID);
                    table.ForeignKey(
                        name: "FK_ListingType_ListingTypeCategory_ListingTypeCategoryID",
                        column: x => x.ListingTypeCategoryID,
                        principalTable: "ListingTypeCategory",
                        principalColumn: "ListingTypeCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Listing",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrencyTypeID = table.Column<int>(nullable: false),
                    Discription = table.Column<string>(nullable: true),
                    IsNegotiable = table.Column<bool>(nullable: false),
                    ListingTypeID = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    SizeMeasurement = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listing", x => x.ListingID);
                    table.ForeignKey(
                        name: "FK_Listing_CurrencyType_CurrencyTypeID",
                        column: x => x.CurrencyTypeID,
                        principalTable: "CurrencyType",
                        principalColumn: "CurrencyTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Listing_ListingType_ListingTypeID",
                        column: x => x.ListingTypeID,
                        principalTable: "ListingType",
                        principalColumn: "ListingTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListingAvailability",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false),
                    LookupAvailibilityID = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingAvailability", x => new { x.ListingID, x.LookupAvailibilityID });
                    table.ForeignKey(
                        name: "FK_ListingAvailability_Listing_ListingID",
                        column: x => x.ListingID,
                        principalTable: "Listing",
                        principalColumn: "ListingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListingAvailability_LookupAvailibility_LookupAvailibilityID",
                        column: x => x.LookupAvailibilityID,
                        principalTable: "LookupAvailibility",
                        principalColumn: "LookupAvailibilityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListingFurnishing",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false),
                    LookupFurnishingID = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingFurnishing", x => new { x.ListingID, x.LookupFurnishingID });
                    table.ForeignKey(
                        name: "FK_ListingFurnishing_Listing_ListingID",
                        column: x => x.ListingID,
                        principalTable: "Listing",
                        principalColumn: "ListingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListingFurnishing_LookupFurnishing_LookupFurnishingID",
                        column: x => x.LookupFurnishingID,
                        principalTable: "LookupFurnishing",
                        principalColumn: "LookupFurnishingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListingLandmark",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false),
                    LookupLandmarkID = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingLandmark", x => new { x.ListingID, x.LookupLandmarkID });
                    table.ForeignKey(
                        name: "FK_ListingLandmark_Listing_ListingID",
                        column: x => x.ListingID,
                        principalTable: "Listing",
                        principalColumn: "ListingID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ListingLandmark_LookupLandmark_LookupLandmarkID",
                        column: x => x.LookupLandmarkID,
                        principalTable: "LookupLandmark",
                        principalColumn: "LookupLandmarkID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ListingSpecifications",
                columns: table => new
                {
                    ListingID = table.Column<int>(nullable: false),
                    SpecificationLookupID = table.Column<int>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListingSpecifications", x => new { x.ListingID, x.SpecificationLookupID });
                    table.ForeignKey(
                        name: "FK_ListingSpecifications_Listing_ListingID",
                        column: x => x.ListingID,
                        principalTable: "Listing",
                        principalColumn: "ListingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Listing_CurrencyTypeID",
                table: "Listing",
                column: "CurrencyTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Listing_ListingTypeID",
                table: "Listing",
                column: "ListingTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ListingAvailability_LookupAvailibilityID",
                table: "ListingAvailability",
                column: "LookupAvailibilityID");

            migrationBuilder.CreateIndex(
                name: "IX_ListingFacilities_FacilitiesLookupID",
                table: "ListingFacilities",
                column: "FacilitiesLookupID");

            migrationBuilder.CreateIndex(
                name: "IX_ListingFurnishing_LookupFurnishingID",
                table: "ListingFurnishing",
                column: "LookupFurnishingID");

            migrationBuilder.CreateIndex(
                name: "IX_ListingLandmark_LookupLandmarkID",
                table: "ListingLandmark",
                column: "LookupLandmarkID");

            migrationBuilder.CreateIndex(
                name: "IX_ListingType_ListingTypeCategoryID",
                table: "ListingType",
                column: "ListingTypeCategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListingAvailability");

            migrationBuilder.DropTable(
                name: "ListingFacilities");

            migrationBuilder.DropTable(
                name: "ListingFurnishing");

            migrationBuilder.DropTable(
                name: "ListingLandmark");

            migrationBuilder.DropTable(
                name: "ListingSpecifications");

            migrationBuilder.DropTable(
                name: "LookupAvailibility");

            migrationBuilder.DropTable(
                name: "FacilitiesLookup");

            migrationBuilder.DropTable(
                name: "LookupFurnishing");

            migrationBuilder.DropTable(
                name: "LookupLandmark");

            migrationBuilder.DropTable(
                name: "Listing");

            migrationBuilder.DropTable(
                name: "CurrencyType");

            migrationBuilder.DropTable(
                name: "ListingType");

            migrationBuilder.DropTable(
                name: "ListingTypeCategory");

            migrationBuilder.RenameColumn(
                name: "ModifiedAt",
                table: "UserLoginChannels",
                newName: "CreatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupState",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "LookupState",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "LookupState",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCountry",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "LookupCountry",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "LookupCountry",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "LookupContinent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 57, 4, 392, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2017, 12, 3, 14, 23, 54, 156, DateTimeKind.Local));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "LookupCity",
                nullable: false,
                defaultValue: new DateTime(2017, 12, 3, 3, 57, 4, 386, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "LookupCity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "LookupCity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "FAQCategory",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "FAQCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "FAQCategory",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "FAQ",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "FAQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "FAQ",
                nullable: false,
                defaultValue: 0);
        }
    }
}
