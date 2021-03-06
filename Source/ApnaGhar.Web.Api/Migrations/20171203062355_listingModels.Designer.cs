﻿// <auto-generated />
using ApnaGhar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ApnaGhar.Web.Api.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20171203062355_listingModels")]
    partial class listingModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApnaGhar.Models.FAQ", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<int>("FAQCategoryID");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("QuestionText");

                    b.HasKey("QuestionID");

                    b.HasIndex("FAQCategoryID");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("ApnaGhar.Models.FAQCategory", b =>
                {
                    b.Property<int>("FAQCategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FAQCategoryDescription");

                    b.Property<string>("FAQCategoryName");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("FAQCategoryID");

                    b.ToTable("FAQCategory");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.CurrencyType", b =>
                {
                    b.Property<int>("CurrencyTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CurrencyDescription");

                    b.Property<string>("CurrencyName");

                    b.Property<string>("CurrencySymbol");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("CurrencyTypeID");

                    b.ToTable("CurrencyType");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.FacilitiesLookup", b =>
                {
                    b.Property<int>("FacilityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FacilityDescription");

                    b.Property<string>("FacilityName");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("FacilityID");

                    b.ToTable("FacilitiesLookup");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.Listing", b =>
                {
                    b.Property<int>("ListingID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CurrencyTypeID");

                    b.Property<string>("Discription");

                    b.Property<bool>("IsNegotiable");

                    b.Property<int>("ListingTypeID");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<int>("Price");

                    b.Property<string>("SizeMeasurement");

                    b.Property<string>("Title");

                    b.HasKey("ListingID");

                    b.HasIndex("CurrencyTypeID");

                    b.HasIndex("ListingTypeID");

                    b.ToTable("Listing");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingAvailability", b =>
                {
                    b.Property<int>("ListingID");

                    b.Property<int>("LookupAvailibilityID");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("ListingID", "LookupAvailibilityID");

                    b.HasIndex("LookupAvailibilityID");

                    b.ToTable("ListingAvailability");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingFacilities", b =>
                {
                    b.Property<int>("ListingID");

                    b.Property<int>("FacilitiesLookupID");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("ListingID", "FacilitiesLookupID");

                    b.HasIndex("FacilitiesLookupID");

                    b.ToTable("ListingFacilities");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingFurnishing", b =>
                {
                    b.Property<int>("ListingID");

                    b.Property<int>("LookupFurnishingID");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("ListingID", "LookupFurnishingID");

                    b.HasIndex("LookupFurnishingID");

                    b.ToTable("ListingFurnishing");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingLandmark", b =>
                {
                    b.Property<int>("ListingID");

                    b.Property<int>("LookupLandmarkID");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("ListingID", "LookupLandmarkID");

                    b.HasIndex("LookupLandmarkID");

                    b.ToTable("ListingLandmark");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingSpecifications", b =>
                {
                    b.Property<int>("ListingID");

                    b.Property<int>("SpecificationLookupID");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("ListingID", "SpecificationLookupID");

                    b.ToTable("ListingSpecifications");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingType", b =>
                {
                    b.Property<int>("ListingTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ListingTypeCategoryID");

                    b.Property<string>("ListingTypeDescription");

                    b.Property<string>("ListingTypeName");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("ListingTypeID");

                    b.HasIndex("ListingTypeCategoryID");

                    b.ToTable("ListingType");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingTypeCategory", b =>
                {
                    b.Property<int>("ListingTypeCategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("ListingTypeCategoryID");

                    b.ToTable("ListingTypeCategory");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.LookupAvailibility", b =>
                {
                    b.Property<int>("LookupAvailibilityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvailibilityDescription");

                    b.Property<string>("AvailibilityName");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("LookupAvailibilityID");

                    b.ToTable("LookupAvailibility");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.LookupFurnishing", b =>
                {
                    b.Property<int>("LookupFurnishingID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FurnishingItemDescription");

                    b.Property<string>("FurnishingItemName");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("LookupFurnishingID");

                    b.ToTable("LookupFurnishing");
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.LookupLandmark", b =>
                {
                    b.Property<int>("LookupLandmarkID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvailibilityDescription");

                    b.Property<string>("AvailibilityName");

                    b.Property<DateTime>("ModifiedDate");

                    b.HasKey("LookupLandmarkID");

                    b.ToTable("LookupLandmark");
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupCity", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityDesc");

                    b.Property<string>("CityName");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2017, 12, 3, 14, 23, 54, 156, DateTimeKind.Local));

                    b.Property<int>("StateID");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("LookupCity");
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupContinent", b =>
                {
                    b.Property<int>("ContinentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CountryDesc");

                    b.Property<string>("CountryName");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("ContinentID");

                    b.ToTable("LookupContinent");
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupCountry", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContinentID");

                    b.Property<string>("CountryDesc");

                    b.Property<string>("CountryName");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("CountryID");

                    b.HasIndex("ContinentID");

                    b.ToTable("LookupCountry");
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupState", b =>
                {
                    b.Property<int>("StateID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryID");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("StateDesc");

                    b.Property<string>("StateName");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("LookupState");
                });

            modelBuilder.Entity("ApnaGhar.Models.Session.LookupLoginChannels", b =>
                {
                    b.Property<int>("LoginChannelID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ChannelDescription");

                    b.Property<string>("ChannelName");

                    b.HasKey("LoginChannelID");

                    b.ToTable("LookupLoginChannels");
                });

            modelBuilder.Entity("ApnaGhar.Models.Session.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMe");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<byte>("Gender");

                    b.Property<string>("HashedPassword");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<string>("Username");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ApnaGhar.Models.Session.UserLoginChannels", b =>
                {
                    b.Property<int>("LoginChannelID");

                    b.Property<int>("UserID");

                    b.Property<DateTime>("ModifiedAt");

                    b.HasKey("LoginChannelID", "UserID");

                    b.ToTable("UserLoginChannels");
                });

            modelBuilder.Entity("ApnaGhar.Models.FAQ", b =>
                {
                    b.HasOne("ApnaGhar.Models.FAQCategory")
                        .WithMany("FAQ")
                        .HasForeignKey("FAQCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.Listing", b =>
                {
                    b.HasOne("ApnaGhar.Models.Listings.CurrencyType")
                        .WithMany("Listings")
                        .HasForeignKey("CurrencyTypeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApnaGhar.Models.Listings.ListingType")
                        .WithMany("Listings")
                        .HasForeignKey("ListingTypeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingAvailability", b =>
                {
                    b.HasOne("ApnaGhar.Models.Listings.Listing")
                        .WithMany("ListingAvailability")
                        .HasForeignKey("ListingID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApnaGhar.Models.Listings.LookupAvailibility")
                        .WithMany("ListingAvailability")
                        .HasForeignKey("LookupAvailibilityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingFacilities", b =>
                {
                    b.HasOne("ApnaGhar.Models.Listings.FacilitiesLookup")
                        .WithMany("ListingFacilitiess")
                        .HasForeignKey("FacilitiesLookupID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingFurnishing", b =>
                {
                    b.HasOne("ApnaGhar.Models.Listings.Listing")
                        .WithMany("ListingFurnishing")
                        .HasForeignKey("ListingID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApnaGhar.Models.Listings.LookupFurnishing")
                        .WithMany("ListingFurnishing")
                        .HasForeignKey("LookupFurnishingID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingLandmark", b =>
                {
                    b.HasOne("ApnaGhar.Models.Listings.Listing")
                        .WithMany("ListingLandmarks")
                        .HasForeignKey("ListingID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ApnaGhar.Models.Listings.LookupLandmark")
                        .WithMany("ListingLandmark")
                        .HasForeignKey("LookupLandmarkID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingSpecifications", b =>
                {
                    b.HasOne("ApnaGhar.Models.Listings.Listing")
                        .WithMany("ListingSpecifications")
                        .HasForeignKey("ListingID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Listings.ListingType", b =>
                {
                    b.HasOne("ApnaGhar.Models.Listings.ListingTypeCategory")
                        .WithMany("ListingTypes")
                        .HasForeignKey("ListingTypeCategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupCity", b =>
                {
                    b.HasOne("ApnaGhar.Models.Lookups.LookupState")
                        .WithMany("LookupCity")
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupCountry", b =>
                {
                    b.HasOne("ApnaGhar.Models.Lookups.LookupContinent")
                        .WithMany("LookupCountry")
                        .HasForeignKey("ContinentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupState", b =>
                {
                    b.HasOne("ApnaGhar.Models.Lookups.LookupCountry")
                        .WithMany("LookupState")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
