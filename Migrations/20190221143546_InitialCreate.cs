using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ckl.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Email = table.Column<string>(nullable: true),
                    From = table.Column<string>(nullable: true),
                    cc = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    htmlMessage = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PartnerTypeAssociations",
                columns: table => new
                {
                    PartnerTypeId = table.Column<Guid>(nullable: false),
                    PartnerId = table.Column<string>(nullable: false),
                    TypeId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerTypeAssociations", x => new { x.PartnerTypeId, x.PartnerId });
                });

            migrationBuilder.CreateTable(
                name: "PartnerTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Partnertype = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartnerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportTypeAssocitaions",
                columns: table => new
                {
                    ReportID = table.Column<Guid>(nullable: false),
                    ReportTypeID = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ParnterId = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTypeAssocitaions", x => new { x.ReportID, x.ReportTypeID });
                });

            migrationBuilder.CreateTable(
                name: "ReportTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TypeOfReport = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextMsg",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    To = table.Column<int>(nullable: false),
                    From = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextMsg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblRoles",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblUsers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PartnerId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    IsTerminated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblRoleClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblRoleClaims_tblRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "tblRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    ConnectionID = table.Column<string>(nullable: false),
                    UserAgent = table.Column<string>(nullable: true),
                    Connected = table.Column<bool>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.ConnectionID);
                    table.ForeignKey(
                        name: "FK_Connections_tblUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PartnerIntId = table.Column<int>(nullable: false),
                    TypeId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PartnerId = table.Column<string>(nullable: true),
                    SaturnReportCount = table.Column<int>(nullable: false),
                    SaturnReportsRequested = table.Column<int>(nullable: false),
                    SaturnReportsSent = table.Column<int>(nullable: false),
                    ReadingsCount = table.Column<int>(nullable: false),
                    ReadingSent = table.Column<int>(nullable: false),
                    RedaingsRequest = table.Column<int>(nullable: false),
                    SaturnReportsCount = table.Column<int>(nullable: false),
                    NewsletterSubscribersCount = table.Column<int>(nullable: false),
                    NewslettersCreated = table.Column<int>(nullable: false),
                    NewslettersSent = table.Column<int>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partners_tblUsers_UserId1",
                        column: x => x.UserId1,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Count = table.Column<int>(nullable: false),
                    UniqueId = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    UserFirstName = table.Column<string>(nullable: true),
                    UserLastName = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    UserDOB = table.Column<DateTime>(nullable: false),
                    DobYear = table.Column<int>(nullable: false),
                    DobDay = table.Column<int>(nullable: false),
                    DobMonthnum = table.Column<int>(nullable: false),
                    DobDate = table.Column<string>(nullable: true),
                    UserZip = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    DateRequested = table.Column<DateTime>(nullable: false),
                    IsUser = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_tblUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UploadedFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UploadedId = table.Column<string>(nullable: true),
                    FileSize = table.Column<string>(nullable: true),
                    Size = table.Column<byte>(nullable: false),
                    Order = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CustomerId = table.Column<string>(nullable: true),
                    PartnerId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    MyProperty = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true),
                    DocumentLinkName = table.Column<string>(nullable: true),
                    DocumentLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadedFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadedFiles_tblUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tblUserClaims",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblUserClaims_tblUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblUserLogins",
                schema: "dbo",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_tblUserLogins_tblUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblUserRoles",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_tblUserRoles_tblUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblUserRoles_tblRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "dbo",
                        principalTable: "tblRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblUserRoles_tblUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblUserTokens",
                schema: "dbo",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_tblUserTokens_tblUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UserId = table.Column<string>(nullable: true),
                    PartnerId = table.Column<string>(nullable: true),
                    IsSubscribed = table.Column<bool>(nullable: false),
                    SaturnId = table.Column<int>(nullable: false),
                    HorescopeId = table.Column<int>(nullable: false),
                    NewsLetterId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CustomerBio = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false),
                    CellPhoneNumber = table.Column<int>(nullable: false),
                    OtherPhoneNumber = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    ImageFileName = table.Column<string>(nullable: true),
                    ImageData = table.Column<byte[]>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    DOB = table.Column<DateTime>(nullable: false),
                    DOBwithTime = table.Column<DateTime>(nullable: true),
                    HasFamily = table.Column<bool>(nullable: false),
                    FileID = table.Column<string>(nullable: true),
                    ForMe = table.Column<bool>(nullable: false),
                    NumberOfChildren = table.Column<int>(nullable: false),
                    TitleinFamily = table.Column<string>(nullable: true),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    PartnerId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Partners_PartnerId1",
                        column: x => x.PartnerId1,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_tblUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoroscropeReadings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    HorosopeId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    TypeId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    BaseCost = table.Column<decimal>(nullable: false),
                    IsSubscribed = table.Column<bool>(nullable: false),
                    UserEmail = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserZip = table.Column<int>(nullable: false),
                    BirthCity = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    BirthZipCode = table.Column<int>(nullable: false),
                    TimeOfBirth = table.Column<DateTime>(nullable: false),
                    MothersFullName = table.Column<string>(nullable: true),
                    FatherFullName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false),
                    MiddleName = table.Column<string>(nullable: true),
                    MiddleNametwo = table.Column<string>(nullable: true),
                    SecondFirstName = table.Column<string>(nullable: true),
                    AdminId = table.Column<string>(nullable: true),
                    PartnerId = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    BodyText = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    PartnerId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoroscropeReadings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoroscropeReadings_tblUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoroscropeReadings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoroscropeReadings_Partners_PartnerId1",
                        column: x => x.PartnerId1,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Newsletters",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NewsletterId = table.Column<int>(nullable: false),
                    NewsId = table.Column<string>(nullable: true),
                    PartnerId = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    BodyText = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    BaseCost = table.Column<decimal>(nullable: false),
                    IsSubscribed = table.Column<bool>(nullable: false),
                    AuthorFirstName = table.Column<string>(nullable: true),
                    AuthorLastName = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    PartnerId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Newsletters_tblUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Newsletters_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Newsletters_Partners_PartnerId1",
                        column: x => x.PartnerId1,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaturnReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    SaturnReportId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    PartnerId = table.Column<string>(nullable: true),
                    FileId = table.Column<string>(nullable: true),
                    UserIntId = table.Column<int>(nullable: false),
                    BaseCost = table.Column<decimal>(nullable: false),
                    RequestNumber = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    DateofBirth = table.Column<DateTime>(nullable: false),
                    BeginningDateofBirth = table.Column<DateTime>(nullable: false),
                    EndingDateofBirth = table.Column<DateTime>(nullable: false),
                    DOB = table.Column<string>(nullable: true),
                    UserFirstName = table.Column<string>(nullable: true),
                    UserLastName = table.Column<string>(nullable: true),
                    UserGender = table.Column<string>(nullable: true),
                    UserEmail = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    BodyText = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    IsSubscribed = table.Column<bool>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true),
                    PartnerId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaturnReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SaturnReports_tblUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalSchema: "dbo",
                        principalTable: "tblUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaturnReports_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaturnReports_Partners_PartnerId1",
                        column: x => x.PartnerId1,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Connections_ApplicationUserId",
                table: "Connections",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PartnerId1",
                table: "Customers",
                column: "PartnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HoroscropeReadings_ApplicationUserId",
                table: "HoroscropeReadings",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HoroscropeReadings_CustomerId",
                table: "HoroscropeReadings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_HoroscropeReadings_PartnerId1",
                table: "HoroscropeReadings",
                column: "PartnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletters_ApplicationUserId",
                table: "Newsletters",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletters_CustomerId",
                table: "Newsletters",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletters_PartnerId1",
                table: "Newsletters",
                column: "PartnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Partners_UserId1",
                table: "Partners",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Request_UserId",
                table: "Request",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaturnReports_ApplicationUserId",
                table: "SaturnReports",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaturnReports_CustomerId",
                table: "SaturnReports",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SaturnReports_PartnerId1",
                table: "SaturnReports",
                column: "PartnerId1");

            migrationBuilder.CreateIndex(
                name: "IX_UploadedFiles_UserId",
                table: "UploadedFiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblRoleClaims_RoleId",
                schema: "dbo",
                table: "tblRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "dbo",
                table: "tblRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblUserClaims_UserId",
                schema: "dbo",
                table: "tblUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblUserLogins_UserId",
                schema: "dbo",
                table: "tblUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblUserRoles_ApplicationUserId",
                schema: "dbo",
                table: "tblUserRoles",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_tblUserRoles_RoleId",
                schema: "dbo",
                table: "tblUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "dbo",
                table: "tblUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "dbo",
                table: "tblUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "HoroscropeReadings");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "Newsletters");

            migrationBuilder.DropTable(
                name: "PartnerTypeAssociations");

            migrationBuilder.DropTable(
                name: "PartnerTypes");

            migrationBuilder.DropTable(
                name: "ReportTypeAssocitaions");

            migrationBuilder.DropTable(
                name: "ReportTypes");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "SaturnReports");

            migrationBuilder.DropTable(
                name: "TextMsg");

            migrationBuilder.DropTable(
                name: "UploadedFiles");

            migrationBuilder.DropTable(
                name: "tblRoleClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblUserClaims",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblUserLogins",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblUserRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "tblUserTokens",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "tblRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "tblUsers",
                schema: "dbo");
        }
    }
}
