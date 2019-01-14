﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ckl.Data;

namespace ckl.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190114190727_kjf")]
    partial class kjf
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ckl.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsTerminated");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<Guid>("PartnerId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<DateTime?>("StartDate");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("tblUsers","dbo");
                });

            modelBuilder.Entity("ckl.Models.Connection", b =>
                {
                    b.Property<string>("ConnectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<bool>("Connected");

                    b.Property<string>("UserAgent");

                    b.HasKey("ConnectionID");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("ckl.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CellPhoneNumber");

                    b.Property<string>("City");

                    b.Property<string>("CustomerBio");

                    b.Property<DateTime>("DOB");

                    b.Property<DateTime?>("DOBwithTime");

                    b.Property<DateTime>("DateRegistered");

                    b.Property<string>("Email");

                    b.Property<string>("FileID");

                    b.Property<string>("FirstName");

                    b.Property<bool>("ForMe");

                    b.Property<bool>("HasFamily");

                    b.Property<int>("HorescopeId");

                    b.Property<string>("Image");

                    b.Property<byte[]>("ImageData");

                    b.Property<string>("ImageFileName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsSubscribed");

                    b.Property<string>("LastName");

                    b.Property<int>("NewsLetterId");

                    b.Property<int>("NumberOfChildren");

                    b.Property<int>("OtherPhoneNumber");

                    b.Property<string>("PartnerId");

                    b.Property<Guid?>("PartnerId1");

                    b.Property<int>("SaturnId");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("TitleinFamily");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName");

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("PartnerId1");

                    b.HasIndex("UserId");

                    b.ToTable("Customers","dbo");
                });

            modelBuilder.Entity("ckl.Models.HoroscropeReading", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdminId");

                    b.Property<string>("ApplicationUserId");

                    b.Property<decimal>("BaseCost");

                    b.Property<string>("BodyText");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Desciption");

                    b.Property<int>("HorosopeId");

                    b.Property<string>("Image");

                    b.Property<bool>("IsSubscribed");

                    b.Property<string>("PartnerId");

                    b.Property<Guid?>("PartnerId1");

                    b.Property<string>("Title");

                    b.Property<string>("TypeId");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId1");

                    b.ToTable("HoroscropeReadings");
                });

            modelBuilder.Entity("ckl.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Email");

                    b.Property<string>("From");

                    b.Property<string>("Subject");

                    b.Property<string>("cc");

                    b.Property<string>("htmlMessage");

                    b.HasKey("Id");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("ckl.Models.Newsletter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("AuthorFirstName");

                    b.Property<string>("AuthorLastName");

                    b.Property<decimal>("BaseCost");

                    b.Property<string>("BodyText");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("Desciption");

                    b.Property<string>("Image");

                    b.Property<bool>("IsSubscribed");

                    b.Property<string>("NewsId");

                    b.Property<int>("NewsletterId");

                    b.Property<string>("PartnerId");

                    b.Property<Guid?>("PartnerId1");

                    b.Property<string>("Title");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId1");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("ckl.Models.Partner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerCount");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<int>("NewsletterSubscribersCount");

                    b.Property<int>("NewslettersCreated");

                    b.Property<int>("NewslettersSent");

                    b.Property<string>("PartnerId");

                    b.Property<int>("PartnerIntId");

                    b.Property<Guid?>("PartnerTypeId");

                    b.Property<int>("ReadingSent");

                    b.Property<int>("ReadingsCount");

                    b.Property<int>("RedaingsRequest");

                    b.Property<int>("SaturnReportCount");

                    b.Property<int>("SaturnReportsCount");

                    b.Property<int>("SaturnReportsRequested");

                    b.Property<int>("SaturnReportsSent");

                    b.Property<string>("TypeId");

                    b.Property<string>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("PartnerTypeId");

                    b.HasIndex("UserId1");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("ckl.Models.PartnerType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Partnertype");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PartnerTypes");
                });

            modelBuilder.Entity("ckl.Models.PartnerTypeAssociation", b =>
                {
                    b.Property<Guid>("PartnerTypeId");

                    b.Property<string>("PartnerId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PartnerTypeId", "PartnerId");

                    b.ToTable("PartnerTypeAssociations");
                });

            modelBuilder.Entity("ckl.Models.ReadingReportTypeAssociation", b =>
                {
                    b.Property<Guid>("ReportID");

                    b.Property<string>("ReportTypeID");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<string>("ParnterId");

                    b.Property<string>("Title");

                    b.Property<string>("UserId");

                    b.HasKey("ReportID", "ReportTypeID");

                    b.ToTable("ReportTypeAssocitaions");
                });

            modelBuilder.Entity("ckl.Models.ReportType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.Property<string>("TypeOfReport");

                    b.HasKey("Id");

                    b.ToTable("ReportTypes");
                });

            modelBuilder.Entity("ckl.Models.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<DateTime>("DateRequested");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Gender");

                    b.Property<bool>("IsUser");

                    b.Property<string>("Title");

                    b.Property<string>("Type");

                    b.Property<string>("UniqueId");

                    b.Property<DateTime>("UserDOB");

                    b.Property<string>("UserFirstName");

                    b.Property<string>("UserId");

                    b.Property<string>("UserLastName");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Request");
                });

            modelBuilder.Entity("ckl.Models.SaturnReport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<decimal>("BaseCost");

                    b.Property<DateTime>("BeginningDateofBirth");

                    b.Property<string>("BodyText");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("CustomerId");

                    b.Property<string>("DOB");

                    b.Property<DateTime>("DateofBirth");

                    b.Property<string>("Desciption");

                    b.Property<DateTime>("EndingDateofBirth");

                    b.Property<string>("FileId");

                    b.Property<string>("Image");

                    b.Property<bool>("IsSubscribed");

                    b.Property<string>("PartnerId");

                    b.Property<Guid?>("PartnerId1");

                    b.Property<int>("SaturnReportId");

                    b.Property<string>("Title");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserFirstName");

                    b.Property<string>("UserGender");

                    b.Property<string>("UserId");

                    b.Property<int>("UserIntId");

                    b.Property<string>("UserLastName");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PartnerId1");

                    b.ToTable("SaturnReports");
                });

            modelBuilder.Entity("ckl.Models.TextMsg", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("From");

                    b.Property<string>("Message");

                    b.Property<int>("To");

                    b.HasKey("Id");

                    b.ToTable("TextMsg");
                });

            modelBuilder.Entity("ckl.Models.UploadFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId");

                    b.Property<byte[]>("Data");

                    b.Property<string>("Description");

                    b.Property<string>("DocumentLink");

                    b.Property<string>("DocumentLinkName");

                    b.Property<string>("FileSize");

                    b.Property<DateTime>("MyProperty");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<string>("PartnerId");

                    b.Property<byte>("Size");

                    b.Property<string>("Type");

                    b.Property<string>("UploadedId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UploadedFiles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("tblRoles","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("tblRoleClaims","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("tblUserClaims","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("tblUserLogins","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("tblUserRoles","dbo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("tblUserTokens","dbo");
                });

            modelBuilder.Entity("ckl.Models.Connection", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany("Connections")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("ckl.Models.Customer", b =>
                {
                    b.HasOne("ckl.Models.Partner", "Partner")
                        .WithMany()
                        .HasForeignKey("PartnerId1");

                    b.HasOne("ckl.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ckl.Models.HoroscropeReading", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany("HoroscropeReadings")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ckl.Models.Customer")
                        .WithMany("HoroscropeReadings")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ckl.Models.Partner")
                        .WithMany("HoroscropeReadings")
                        .HasForeignKey("PartnerId1");
                });

            modelBuilder.Entity("ckl.Models.Newsletter", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany("Newsletters")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ckl.Models.Customer")
                        .WithMany("Newsletters")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ckl.Models.Partner")
                        .WithMany("Newsletters")
                        .HasForeignKey("PartnerId1");
                });

            modelBuilder.Entity("ckl.Models.Partner", b =>
                {
                    b.HasOne("ckl.Models.PartnerType")
                        .WithMany("Partners")
                        .HasForeignKey("PartnerTypeId");

                    b.HasOne("ckl.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("ckl.Models.Request", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ckl.Models.SaturnReport", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany("SaturnReports")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("ckl.Models.Customer")
                        .WithMany("SaturnReports")
                        .HasForeignKey("CustomerId");

                    b.HasOne("ckl.Models.Partner")
                        .WithMany("SaturnReports")
                        .HasForeignKey("PartnerId1");
                });

            modelBuilder.Entity("ckl.Models.UploadFile", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ckl.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
