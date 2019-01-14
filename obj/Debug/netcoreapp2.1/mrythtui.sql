DROP TABLE [Admins];

GO

ALTER TABLE [dbo].[tblUsers] ADD [CustomerId] int NOT NULL DEFAULT 0;

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'CustomerId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Customers] ALTER COLUMN [CustomerId] int NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181203175435_ok1', N'2.1.4-rtm-31024');

GO

ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerId];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [FK_Newsletters_Customers_CustomerId];

GO

ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_Customers_CustomerId];

GO

DROP INDEX [IX_SaturnReports_CustomerId] ON [SaturnReports];

GO

DROP INDEX [IX_Newsletters_CustomerId] ON [Newsletters];

GO

DROP INDEX [IX_HoroscropeReadings_CustomerId] ON [HoroscropeReadings];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserPartnerAssociation]') AND [c].[name] = N'CustomerId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [UserPartnerAssociation] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [UserPartnerAssociation] ALTER COLUMN [CustomerId] int NOT NULL;

GO

ALTER TABLE [UserFileAssociations] ADD [CustomerId] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [UploadedFiles] ADD [CustomerId] int NOT NULL DEFAULT 0;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'CustomerId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [SaturnReports] ALTER COLUMN [CustomerId] int NOT NULL;

GO

ALTER TABLE [SaturnReports] ADD [CustomerId1] uniqueidentifier NULL;

GO

ALTER TABLE [Reports] ADD [CustomerId] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [CustomerId] int NOT NULL DEFAULT 0;

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Newsletters]') AND [c].[name] = N'CustomerId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Newsletters] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Newsletters] ALTER COLUMN [CustomerId] int NOT NULL;

GO

ALTER TABLE [Newsletters] ADD [CustomerId1] uniqueidentifier NULL;

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'CustomerId');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [HoroscropeReadings] ALTER COLUMN [CustomerId] int NOT NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [CustomerId1] uniqueidentifier NULL;

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'CustomerId');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Customers] ALTER COLUMN [CustomerId] nvarchar(max) NULL;

GO

ALTER TABLE [Customers] ADD [CId] int NOT NULL DEFAULT 0;

GO

CREATE INDEX [IX_SaturnReports_CustomerId1] ON [SaturnReports] ([CustomerId1]);

GO

CREATE INDEX [IX_Newsletters_CustomerId1] ON [Newsletters] ([CustomerId1]);

GO

CREATE INDEX [IX_HoroscropeReadings_CustomerId1] ON [HoroscropeReadings] ([CustomerId1]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerId1] FOREIGN KEY ([CustomerId1]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Customers_CustomerId1] FOREIGN KEY ([CustomerId1]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Customers_CustomerId1] FOREIGN KEY ([CustomerId1]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181203180310_ok3', N'2.1.4-rtm-31024');

GO

