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
    [Migration("20171202191735_faqModification2")]
    partial class faqModification2
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

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<int>("FAQCategoryID");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<int>("ModifiedBy");

                    b.Property<string>("QuestionText");

                    b.HasKey("QuestionID");

                    b.HasIndex("FAQCategoryID");

                    b.ToTable("FAQ");
                });

            modelBuilder.Entity("ApnaGhar.Models.FAQCategory", b =>
                {
                    b.Property<int>("FAQCategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<string>("FAQCategoryDescription");

                    b.Property<string>("FAQCategoryName");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<int>("ModifiedBy");

                    b.HasKey("FAQCategoryID");

                    b.ToTable("FAQCategory");
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupCity", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityDesc");

                    b.Property<string>("CityName");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2017, 12, 3, 3, 17, 34, 703, DateTimeKind.Local));

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("ModifiedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2017, 12, 3, 3, 17, 34, 710, DateTimeKind.Local));

                    b.Property<int>("ModifiedBy");

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

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<int>("ModifiedBy");

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

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<int>("ModifiedBy");

                    b.HasKey("CountryID");

                    b.HasIndex("ContinentID");

                    b.ToTable("LookupCountry");
                });

            modelBuilder.Entity("ApnaGhar.Models.Lookups.LookupState", b =>
                {
                    b.Property<int>("StateID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryID");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<int>("ModifiedBy");

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

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedBy");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<byte>("Gender");

                    b.Property<string>("HashedPassword");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("ModifiedAt");

                    b.Property<int>("ModifiedBy");

                    b.Property<string>("Username");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ApnaGhar.Models.Session.UserLoginChannels", b =>
                {
                    b.Property<int>("LoginChannelID");

                    b.Property<int>("UserID");

                    b.Property<DateTime>("CreatedAt");

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
