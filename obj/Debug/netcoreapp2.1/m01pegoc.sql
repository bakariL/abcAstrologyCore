ALTER TABLE [dbo].[tblUserRoles] ADD [AppUserId] nvarchar(450) NULL;

GO

ALTER TABLE [SaturnReports] ADD [CreatedByUserId] nvarchar(450) NULL;

GO

CREATE TABLE [UploadFile] (
    [Id] uniqueidentifier NOT NULL,
    [Order] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Data] varbinary(max) NULL,
    [DocumentLinkName] nvarchar(max) NULL,
    [DocumentLink] nvarchar(max) NULL,
    CONSTRAINT [PK_UploadFile] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [UserFileAssociation] (
    [Id] int NOT NULL IDENTITY,
    [FileId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NULL,
    [ReadDate] datetime2 NULL,
    [IsAccepted] bit NULL,
    CONSTRAINT [PK_UserFileAssociation] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserFileAssociation_UploadFile_FileId] FOREIGN KEY ([FileId]) REFERENCES [UploadFile] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserFileAssociation_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_tblUserRoles_AppUserId] ON [dbo].[tblUserRoles] ([AppUserId]);

GO

CREATE INDEX [IX_SaturnReports_CreatedByUserId] ON [SaturnReports] ([CreatedByUserId]);

GO

CREATE INDEX [IX_UserFileAssociation_FileId] ON [UserFileAssociation] ([FileId]);

GO

CREATE INDEX [IX_UserFileAssociation_UserId] ON [UserFileAssociation] ([UserId]);

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_tblUsers_CreatedByUserId] FOREIGN KEY ([CreatedByUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [dbo].[tblUserRoles] ADD CONSTRAINT [FK_tblUserRoles_tblUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181027113542_ok2-addedUploadfIleUserFileAssociation-ViewModelsToo', N'2.1.4-rtm-31024');

GO

ALTER TABLE [UserFileAssociation] DROP CONSTRAINT [FK_UserFileAssociation_UploadFile_FileId];

GO

ALTER TABLE [UserFileAssociation] DROP CONSTRAINT [FK_UserFileAssociation_tblUsers_UserId];

GO

ALTER TABLE [UserFileAssociation] DROP CONSTRAINT [PK_UserFileAssociation];

GO

ALTER TABLE [UploadFile] DROP CONSTRAINT [PK_UploadFile];

GO

EXEC sp_rename N'[UserFileAssociation]', N'UserFileAssociations';

GO

EXEC sp_rename N'[UploadFile]', N'UploadedFiles';

GO

EXEC sp_rename N'[UserFileAssociations].[IX_UserFileAssociation_UserId]', N'IX_UserFileAssociations_UserId', N'INDEX';

GO

EXEC sp_rename N'[UserFileAssociations].[IX_UserFileAssociation_FileId]', N'IX_UserFileAssociations_FileId', N'INDEX';

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [PK_UserFileAssociations] PRIMARY KEY ([Id]);

GO

ALTER TABLE [UploadedFiles] ADD CONSTRAINT [PK_UploadedFiles] PRIMARY KEY ([Id]);

GO

CREATE TABLE [UserTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_UserTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [UserPartners] (
    [Id] int NOT NULL IDENTITY,
    [TypeId] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [RequireOnboarding] bit NOT NULL,
    [TypeId1] int NULL,
    CONSTRAINT [PK_UserPartners] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserPartners_UserTypes_TypeId1] FOREIGN KEY ([TypeId1]) REFERENCES [UserTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ReportUserAssociations] (
    [Id] int NOT NULL IDENTITY,
    [ReportId] uniqueidentifier NOT NULL,
    [PartnerId] uniqueidentifier NOT NULL,
    [SaturnReportId] int NULL,
    [UserPartnerId] int NULL,
    CONSTRAINT [PK_ReportUserAssociations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ReportUserAssociations_SaturnReports_SaturnReportId] FOREIGN KEY ([SaturnReportId]) REFERENCES [SaturnReports] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ReportUserAssociations_UserPartners_UserPartnerId] FOREIGN KEY ([UserPartnerId]) REFERENCES [UserPartners] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_ReportUserAssociations_SaturnReportId] ON [ReportUserAssociations] ([SaturnReportId]);

GO

CREATE INDEX [IX_ReportUserAssociations_UserPartnerId] ON [ReportUserAssociations] ([UserPartnerId]);

GO

CREATE INDEX [IX_UserPartners_TypeId1] ON [UserPartners] ([TypeId1]);

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_UploadedFiles_FileId] FOREIGN KEY ([FileId]) REFERENCES [UploadedFiles] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181027124133_ok3-addedReportUserAssoc-UploadFile-USerFileAccs-UserParter-UserType-RegistterViewModel', N'2.1.4-rtm-31024');

GO

CREATE TABLE [UserPartnerAssociations] (
    [Id] int NOT NULL IDENTITY,
    [UserPartnerId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NULL,
    [CompletedOnboarding] bit NOT NULL,
    [UerPartnerId] int NULL,
    CONSTRAINT [PK_UserPartnerAssociations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserPartnerAssociations_UserPartners_UerPartnerId] FOREIGN KEY ([UerPartnerId]) REFERENCES [UserPartners] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserPartnerAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_UserPartnerAssociations_UerPartnerId] ON [UserPartnerAssociations] ([UerPartnerId]);

GO

CREATE INDEX [IX_UserPartnerAssociations_UserId] ON [UserPartnerAssociations] ([UserId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181101200945_ok4-addedUserRoleToRegisterView', N'2.1.4-rtm-31024');

GO

EXEC sp_rename N'[Customers].[Name]', N'UserName', N'COLUMN';

GO

ALTER TABLE [SaturnReports] ADD [CustomerId] int NULL;

GO

ALTER TABLE [Newsletters] ADD [CustomerId] int NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [CustomerId] int NULL;

GO

ALTER TABLE [Customers] ADD [DOB] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [Customers] ADD [DOBwithTime] datetime2 NULL;

GO

ALTER TABLE [Customers] ADD [FirstName] nvarchar(max) NULL;

GO

ALTER TABLE [Customers] ADD [IsActive] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [Customers] ADD [LastName] nvarchar(max) NULL;

GO

ALTER TABLE [Customers] ADD [UserTypeId] int NULL;

GO

CREATE INDEX [IX_SaturnReports_CustomerId] ON [SaturnReports] ([CustomerId]);

GO

CREATE INDEX [IX_Newsletters_CustomerId] ON [Newsletters] ([CustomerId]);

GO

CREATE INDEX [IX_HoroscropeReadings_CustomerId] ON [HoroscropeReadings] ([CustomerId]);

GO

CREATE INDEX [IX_Customers_UserTypeId] ON [Customers] ([UserTypeId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_UserTypes_UserTypeId] FOREIGN KEY ([UserTypeId]) REFERENCES [UserTypes] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181102165059_ok4-addedtoCustosterModel', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Customers] ADD [AppUserId] nvarchar(450) NULL;

GO

ALTER TABLE [Customers] ADD [CustomerId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

CREATE INDEX [IX_Customers_AppUserId] ON [Customers] ([AppUserId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_tblUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181102170253_ok5-addedtoCustosterModel', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Customers] ADD [Text] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181103141802_ok6TestingOUtGrid', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Customers] DROP CONSTRAINT [FK_Customers_tblUsers_AppUserId];

GO

DROP INDEX [IX_Customers_AppUserId] ON [Customers];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'AppUserId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Customers] ALTER COLUMN [AppUserId] int NOT NULL;

GO

ALTER TABLE [Customers] ADD [AppUserId1] nvarchar(450) NULL;

GO

CREATE INDEX [IX_Customers_AppUserId1] ON [Customers] ([AppUserId1]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_tblUsers_AppUserId1] FOREIGN KEY ([AppUserId1]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181103143621_ok7', N'2.1.4-rtm-31024');

GO

ALTER TABLE [dbo].[tblUsers] ADD [AppUserId] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181103143800_ok8', N'2.1.4-rtm-31024');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104010800_ok7AddedAdminModel', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Customers] DROP CONSTRAINT [FK_Customers_tblUsers_AppUserId1];

GO

DROP INDEX [IX_Customers_AppUserId1] ON [Customers];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'AppUserId1');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Customers] DROP COLUMN [AppUserId1];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'AppUserId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Customers] ALTER COLUMN [AppUserId] nvarchar(450) NULL;

GO

CREATE TABLE [Admins] (
    [Id] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [CustomerId] int NULL,
    CONSTRAINT [PK_Admins] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Admins_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Customers_AppUserId] ON [Customers] ([AppUserId]);

GO

CREATE INDEX [IX_Admins_CustomerId] ON [Admins] ([CustomerId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_tblUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104172155_16TyringtoGetITBackWorking', N'2.1.4-rtm-31024');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181105201239_0knotsook10', N'2.1.4-rtm-31024');

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'CustomerId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Customers] DROP COLUMN [CustomerId];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181105201905_ok12cusotmerchange', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Customers] DROP CONSTRAINT [FK_Customers_tblUsers_AppUserId];

GO

DROP INDEX [IX_Customers_AppUserId] ON [Customers];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'AppUserId');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Customers] DROP COLUMN [AppUserId];

GO

EXEC sp_rename N'[dbo].[tblUsers].[AppUserId]', N'CustomerId', N'COLUMN';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181105205358_ok14', N'2.1.4-rtm-31024');

GO

