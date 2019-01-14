IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [dbo].[tblRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_tblRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [dbo].[tblUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [CustomerId] int NOT NULL,
    [Partnertype] nvarchar(max) NULL,
    [UserId] smallint NOT NULL,
    [UserNameId] nvarchar(max) NULL,
    [StartDate] datetime2 NULL,
    [IsTerminated] bit NOT NULL,
    CONSTRAINT [PK_tblUsers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [dbo].[tblRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_tblRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_tblRoleClaims_tblRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[tblRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(max) NULL,
    [CustomerId] int NOT NULL,
    [SaturnId] int NOT NULL,
    [HorescopeId] int NOT NULL,
    [NewsLetterId] int NOT NULL,
    [UserName] nvarchar(max) NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [CustomerBio] nvarchar(max) NULL,
    [StreetAddress] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [State] nvarchar(max) NULL,
    [ZipCode] int NOT NULL,
    [CellPhoneNumber] int NOT NULL,
    [OtherPhoneNumber] int NOT NULL,
    [Image] nvarchar(max) NULL,
    [ImageFileName] nvarchar(max) NULL,
    [ImageData] varbinary(max) NULL,
    [IsActive] bit NOT NULL,
    [DOB] datetime2 NOT NULL,
    [DOBwithTime] datetime2 NULL,
    [HasFamily] bit NOT NULL,
    [FileID] nvarchar(max) NULL,
    [ForMe] bit NOT NULL,
    [NumberOfChildren] int NOT NULL,
    [TitleinFamily] nvarchar(max) NULL,
    [UserId1] nvarchar(450) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Customers_tblUsers_UserId1] FOREIGN KEY ([UserId1]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [UploadedFiles] (
    [Id] uniqueidentifier NOT NULL,
    [UploadedId] int NOT NULL,
    [Order] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [CustomerId] nvarchar(max) NULL,
    [CustId] int NOT NULL,
    [UserId] nvarchar(450) NULL,
    [Description] nvarchar(max) NULL,
    [Data] varbinary(max) NULL,
    [DocumentLinkName] nvarchar(max) NULL,
    [DocumentLink] nvarchar(max) NULL,
    CONSTRAINT [PK_UploadedFiles] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UploadedFiles_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [UserCustomerAssociations] (
    [Id] int NOT NULL,
    [PartnerId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NOT NULL,
    [CustomerId] int NOT NULL,
    [Email] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [CompeltedOnBoarding] bit NOT NULL,
    CONSTRAINT [PK_UserCustomerAssociations] PRIMARY KEY ([PartnerId], [UserId]),
    CONSTRAINT [FK_UserCustomerAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [dbo].[tblUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_tblUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_tblUserClaims_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [dbo].[tblUserLogins] (
    [LoginProvider] nvarchar(128) NOT NULL,
    [ProviderKey] nvarchar(128) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_tblUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_tblUserLogins_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [dbo].[tblUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_tblUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_tblUserRoles_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_tblUserRoles_tblRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[tblRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_tblUserRoles_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [dbo].[tblUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(128) NOT NULL,
    [Name] nvarchar(128) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_tblUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_tblUserTokens_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Partners] (
    [Id] uniqueidentifier NOT NULL,
    [PartnerIntId] int NOT NULL,
    [TypeId] uniqueidentifier NOT NULL,
    [CustomerId] int NOT NULL,
    [UserId] nvarchar(450) NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [PartnerId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Partners] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Partners_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Partners_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [SaturnReports] (
    [Id] smallint NOT NULL IDENTITY,
    [SaturnReportId] int NOT NULL,
    [Title] nvarchar(max) NULL,
    [CustomerId] int NOT NULL,
    [UserId] nvarchar(max) NULL,
    [FileId] uniqueidentifier NOT NULL,
    [UserIntId] int NOT NULL,
    [UserName] nvarchar(max) NULL,
    [Desciption] nvarchar(max) NULL,
    [BodyText] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_SaturnReports] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SaturnReports_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SaturnReports_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [HoroscropeReadings] (
    [Id] smallint NOT NULL IDENTITY,
    [HorosopeId] int NOT NULL,
    [Title] nvarchar(max) NULL,
    [CustomerId] int NOT NULL,
    [UserId] nvarchar(max) NULL,
    [UserName] nvarchar(max) NULL,
    [AdminId] nvarchar(max) NULL,
    [PartnerId] int NOT NULL,
    [Desciption] nvarchar(max) NULL,
    [BodyText] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    [PartnerId1] uniqueidentifier NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_HoroscropeReadings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_HoroscropeReadings_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_HoroscropeReadings_Partners_PartnerId1] FOREIGN KEY ([PartnerId1]) REFERENCES [Partners] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Newsletters] (
    [Id] smallint NOT NULL IDENTITY,
    [CustomerId] nvarchar(max) NULL,
    [AdminId] nvarchar(max) NULL,
    [UserId] nvarchar(max) NULL,
    [UserName] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    [Desciption] nvarchar(max) NULL,
    [BodyText] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    [AuthorFirstName] nvarchar(max) NULL,
    [AuthorLastName] nvarchar(max) NULL,
    [Created] datetime2 NOT NULL,
    [CustomerId1] int NULL,
    [PartnerId] uniqueidentifier NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_Newsletters] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Newsletters_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Newsletters_Customers_CustomerId1] FOREIGN KEY ([CustomerId1]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Newsletters_Partners_PartnerId] FOREIGN KEY ([PartnerId]) REFERENCES [Partners] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [UserFileAssociations] (
    [Id] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NULL,
    [FileId] nvarchar(450) NOT NULL,
    [CustomerId] nvarchar(450) NOT NULL,
    [AdminId] nvarchar(450) NOT NULL,
    [UserName] nvarchar(max) NULL,
    [CustId] int NOT NULL,
    [SaturnId] smallint NULL,
    [HoroscropeId] smallint NULL,
    [NewsletterId] smallint NULL,
    [CustomerId1] int NULL,
    CONSTRAINT [PK_UserFileAssociations] PRIMARY KEY ([AdminId], [CustomerId], [FileId]),
    CONSTRAINT [FK_UserFileAssociations_Customers_CustomerId1] FOREIGN KEY ([CustomerId1]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserFileAssociations_HoroscropeReadings_HoroscropeId] FOREIGN KEY ([HoroscropeId]) REFERENCES [HoroscropeReadings] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserFileAssociations_Newsletters_NewsletterId] FOREIGN KEY ([NewsletterId]) REFERENCES [Newsletters] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserFileAssociations_SaturnReports_SaturnId] FOREIGN KEY ([SaturnId]) REFERENCES [SaturnReports] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserFileAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Customers_UserId1] ON [Customers] ([UserId1]);

GO

CREATE INDEX [IX_HoroscropeReadings_ApplicationUserId] ON [HoroscropeReadings] ([ApplicationUserId]);

GO

CREATE INDEX [IX_HoroscropeReadings_CustomerId] ON [HoroscropeReadings] ([CustomerId]);

GO

CREATE INDEX [IX_HoroscropeReadings_PartnerId1] ON [HoroscropeReadings] ([PartnerId1]);

GO

CREATE INDEX [IX_Newsletters_ApplicationUserId] ON [Newsletters] ([ApplicationUserId]);

GO

CREATE INDEX [IX_Newsletters_CustomerId1] ON [Newsletters] ([CustomerId1]);

GO

CREATE INDEX [IX_Newsletters_PartnerId] ON [Newsletters] ([PartnerId]);

GO

CREATE UNIQUE INDEX [IX_Partners_CustomerId] ON [Partners] ([CustomerId]);

GO

CREATE INDEX [IX_Partners_UserId] ON [Partners] ([UserId]);

GO

CREATE INDEX [IX_SaturnReports_ApplicationUserId] ON [SaturnReports] ([ApplicationUserId]);

GO

CREATE INDEX [IX_SaturnReports_CustomerId] ON [SaturnReports] ([CustomerId]);

GO

CREATE INDEX [IX_UploadedFiles_UserId] ON [UploadedFiles] ([UserId]);

GO

CREATE INDEX [IX_UserCustomerAssociations_UserId] ON [UserCustomerAssociations] ([UserId]);

GO

CREATE INDEX [IX_UserFileAssociations_CustomerId1] ON [UserFileAssociations] ([CustomerId1]);

GO

CREATE INDEX [IX_UserFileAssociations_HoroscropeId] ON [UserFileAssociations] ([HoroscropeId]);

GO

CREATE INDEX [IX_UserFileAssociations_NewsletterId] ON [UserFileAssociations] ([NewsletterId]);

GO

CREATE INDEX [IX_UserFileAssociations_SaturnId] ON [UserFileAssociations] ([SaturnId]);

GO

CREATE INDEX [IX_UserFileAssociations_UserId] ON [UserFileAssociations] ([UserId]);

GO

CREATE INDEX [IX_tblRoleClaims_RoleId] ON [dbo].[tblRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [dbo].[tblRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_tblUserClaims_UserId] ON [dbo].[tblUserClaims] ([UserId]);

GO

CREATE INDEX [IX_tblUserLogins_UserId] ON [dbo].[tblUserLogins] ([UserId]);

GO

CREATE INDEX [IX_tblUserRoles_ApplicationUserId] ON [dbo].[tblUserRoles] ([ApplicationUserId]);

GO

CREATE INDEX [IX_tblUserRoles_RoleId] ON [dbo].[tblUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [dbo].[tblUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [dbo].[tblUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181212203201_InitialCreate', N'2.1.4-rtm-31024');

GO

CREATE TABLE [Reports] (
    [Id] uniqueidentifier NOT NULL,
    [ReportId] nvarchar(max) NULL,
    [NewsID] nvarchar(max) NULL,
    [SatrunID] nvarchar(max) NULL,
    [HOrescopeID] nvarchar(max) NULL,
    [CreatedReportID] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    [CreatedBy] nvarchar(max) NULL,
    [UserId] nvarchar(450) NULL,
    [NewsletterId] smallint NULL,
    [HoroscropeReadingId] smallint NULL,
    [SaturnReportId] smallint NULL,
    CONSTRAINT [PK_Reports] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Reports_HoroscropeReadings_HoroscropeReadingId] FOREIGN KEY ([HoroscropeReadingId]) REFERENCES [HoroscropeReadings] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_Newsletters_NewsletterId] FOREIGN KEY ([NewsletterId]) REFERENCES [Newsletters] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_SaturnReports_SaturnReportId] FOREIGN KEY ([SaturnReportId]) REFERENCES [SaturnReports] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ReportTypes] (
    [Id] uniqueidentifier NOT NULL,
    [TypeOfReport] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    CONSTRAINT [PK_ReportTypes] PRIMARY KEY ([Id])
);

GO

CREATE INDEX [IX_Reports_HoroscropeReadingId] ON [Reports] ([HoroscropeReadingId]);

GO

CREATE INDEX [IX_Reports_NewsletterId] ON [Reports] ([NewsletterId]);

GO

CREATE INDEX [IX_Reports_SaturnReportId] ON [Reports] ([SaturnReportId]);

GO

CREATE INDEX [IX_Reports_UserId] ON [Reports] ([UserId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213082155_idk', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Reports] DROP CONSTRAINT [FK_Reports_HoroscropeReadings_HoroscropeReadingId];

GO

ALTER TABLE [Reports] DROP CONSTRAINT [FK_Reports_Newsletters_NewsletterId];

GO

ALTER TABLE [Reports] DROP CONSTRAINT [FK_Reports_SaturnReports_SaturnReportId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_Customers_CustomerId1];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_HoroscropeReadings_HoroscropeId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_Newsletters_NewsletterId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_SaturnReports_SaturnId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [PK_UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_CustomerId1] ON [UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_HoroscropeId] ON [UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_NewsletterId] ON [UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_SaturnId] ON [UserFileAssociations];

GO

ALTER TABLE [Reports] DROP CONSTRAINT [PK_Reports];

GO

DROP INDEX [IX_Reports_HoroscropeReadingId] ON [Reports];

GO

DROP INDEX [IX_Reports_NewsletterId] ON [Reports];

GO

DROP INDEX [IX_Reports_SaturnReportId] ON [Reports];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'CustomerId1');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [CustomerId1];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'HoroscropeId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [HoroscropeId];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'NewsletterId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [NewsletterId];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'SaturnId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [SaturnId];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'Id');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Reports] DROP COLUMN [Id];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'CreatedBy');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Reports] DROP COLUMN [CreatedBy];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'CreatedReportID');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Reports] DROP COLUMN [CreatedReportID];

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'HOrescopeID');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Reports] DROP COLUMN [HOrescopeID];

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'HoroscropeReadingId');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Reports] DROP COLUMN [HoroscropeReadingId];

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'NewsID');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Reports] DROP COLUMN [NewsID];

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'NewsletterId');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Reports] DROP COLUMN [NewsletterId];

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'SatrunID');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Reports] DROP COLUMN [SatrunID];

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'SaturnReportId');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Reports] DROP COLUMN [SaturnReportId];

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'FileId');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [UserFileAssociations] ALTER COLUMN [FileId] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [SaturnReports] ADD [ReportTypeId] nvarchar(450) NULL;

GO

ALTER TABLE [ReportTypes] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [ReportTypes] ADD [ReportTypeId] nvarchar(450) NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'ReportId');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [Reports] ALTER COLUMN [ReportId] uniqueidentifier NOT NULL;

GO

ALTER TABLE [Reports] ADD [ReportTypeId] nvarchar(450) NOT NULL DEFAULT N'';

GO

ALTER TABLE [Newsletters] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [Newsletters] ADD [ReportTypeId] nvarchar(450) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportID] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportTypeId] nvarchar(450) NULL;

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [PK_UserFileAssociations] PRIMARY KEY ([AdminId], [CustomerId]);

GO

ALTER TABLE [Reports] ADD CONSTRAINT [PK_Reports] PRIMARY KEY ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_SaturnReports_ReportId_ReportTypeId] ON [SaturnReports] ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_ReportTypes_ReportId_ReportTypeId] ON [ReportTypes] ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_Newsletters_ReportId_ReportTypeId] ON [Newsletters] ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_HoroscropeReadings_ReportId_ReportTypeId] ON [HoroscropeReadings] ([ReportId], [ReportTypeId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

ALTER TABLE [ReportTypes] ADD CONSTRAINT [FK_ReportTypes_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213085848_idddd', N'2.1.4-rtm-31024');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213090203_s', N'2.1.4-rtm-31024');

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'ReportID');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [HoroscropeReadings] DROP COLUMN [ReportID];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213090532_l', N'2.1.4-rtm-31024');

GO

