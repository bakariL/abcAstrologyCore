ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_UserCustomerAssociations_UserCustomerAssociationId];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [FK_Newsletters_UserCustomerAssociations_UserCustomerAssociationId];

GO

ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_UserCustomerAssociations_UserCustomerAssociationId];

GO

DROP INDEX [IX_SaturnReports_UserCustomerAssociationId] ON [SaturnReports];

GO

DROP INDEX [IX_Newsletters_UserCustomerAssociationId] ON [Newsletters];

GO

DROP INDEX [IX_HoroscropeReadings_UserCustomerAssociationId] ON [HoroscropeReadings];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'CustomerId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [CustomerId];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'DOB');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [DOB];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'DOBwithTime');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [DOBwithTime];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'FirstName');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [FirstName];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'LastName');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [LastName];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'PhoneNumber');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [PhoneNumber];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'UCRoleId');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [UCRoleId];

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'UserCustId');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [UserCustId];

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'UserCustomerAssociationId');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [SaturnReports] DROP COLUMN [UserCustomerAssociationId];

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Newsletters]') AND [c].[name] = N'UserCustomerAssociationId');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Newsletters] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Newsletters] DROP COLUMN [UserCustomerAssociationId];

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'UserCustomerAssociationId');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [HoroscropeReadings] DROP COLUMN [UserCustomerAssociationId];

GO

EXEC sp_rename N'[UserCustomerAssociations].[UserName]', N'UserId', N'COLUMN';

GO

ALTER TABLE [UserFileAssociations] ADD [PartnerId] uniqueidentifier NULL;

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'UserId');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [UserCustomerAssociations] ALTER COLUMN [UserId] nvarchar(450) NULL;

GO

ALTER TABLE [UserCustomerAssociations] ADD [CompeltedOnBoarding] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [UserCustomerAssociations] ADD [PartnerId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

ALTER TABLE [UserCustomerAssociations] ADD [UseriId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

CREATE TABLE [PartnerType] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_PartnerType] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Partners] (
    [Id] uniqueidentifier NOT NULL,
    [TypeId] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [RequireOnboarding] bit NOT NULL,
    CONSTRAINT [PK_Partners] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Partners_PartnerType_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [PartnerType] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_UserFileAssociations_PartnerId] ON [UserFileAssociations] ([PartnerId]);

GO

CREATE INDEX [IX_UserCustomerAssociations_PartnerId] ON [UserCustomerAssociations] ([PartnerId]);

GO

CREATE INDEX [IX_UserCustomerAssociations_UserId] ON [UserCustomerAssociations] ([UserId]);

GO

CREATE INDEX [IX_Partners_TypeId] ON [Partners] ([TypeId]);

GO

ALTER TABLE [UserCustomerAssociations] ADD CONSTRAINT [FK_UserCustomerAssociations_Partners_PartnerId] FOREIGN KEY ([PartnerId]) REFERENCES [Partners] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [UserCustomerAssociations] ADD CONSTRAINT [FK_UserCustomerAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_Partners_PartnerId] FOREIGN KEY ([PartnerId]) REFERENCES [Partners] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181120215604_addedUserconnect', N'2.1.4-rtm-31024');

GO

