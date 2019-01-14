ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerUserId_CustomerId1];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [FK_Newsletters_Customers_UserId_CustomerId];

GO

ALTER TABLE [Partners] DROP CONSTRAINT [FK_Partners_tblUsers_UserId];

GO

ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_Customers_CustomerUserId_CustomerId];

GO

DROP INDEX [IX_SaturnReports_CustomerUserId_CustomerId] ON [SaturnReports];

GO

DROP INDEX [IX_Partners_UserId] ON [Partners];

GO

DROP INDEX [IX_Newsletters_UserId_CustomerId] ON [Newsletters];

GO

ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [PK_HoroscropeReadings];

GO

DROP INDEX [IX_HoroscropeReadings_CustomerUserId_CustomerId1] ON [HoroscropeReadings];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[tblUsers]') AND [c].[name] = N'CustomerId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[tblUsers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [dbo].[tblUsers] DROP COLUMN [CustomerId];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'CustomerId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [SaturnReports] DROP COLUMN [CustomerId];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'CustomerUserId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [SaturnReports] DROP COLUMN [CustomerUserId];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Partners]') AND [c].[name] = N'CustomerId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Partners] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [Partners] DROP COLUMN [CustomerId];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'CustomerId1');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [HoroscropeReadings] DROP COLUMN [CustomerId1];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'CustomerUserId');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [HoroscropeReadings] DROP COLUMN [CustomerUserId];

GO

EXEC sp_rename N'[dbo].[tblUsers].[Partnertype]', N'PartnerId', N'COLUMN';

GO

EXEC sp_rename N'[SaturnReports].[AdminId]', N'PartnerId', N'COLUMN';

GO

EXEC sp_rename N'[Newsletters].[AdminId]', N'PartnerId', N'COLUMN';

GO

EXEC sp_rename N'[Customers].[CustomerId]', N'PartnerId', N'COLUMN';

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Partners]') AND [c].[name] = N'UserId');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Partners] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Partners] ALTER COLUMN [UserId] nvarchar(max) NULL;

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Partners]') AND [c].[name] = N'TypeId');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Partners] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Partners] ALTER COLUMN [TypeId] nvarchar(max) NULL;

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Partners]') AND [c].[name] = N'PartnerId');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Partners] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Partners] ALTER COLUMN [PartnerId] nvarchar(max) NULL;

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Newsletters]') AND [c].[name] = N'CustomerId');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Newsletters] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Newsletters] ALTER COLUMN [CustomerId] nvarchar(max) NULL;

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'PartnerId');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [HoroscropeReadings] ALTER COLUMN [PartnerId] nvarchar(450) NOT NULL;

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'AdminId');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [HoroscropeReadings] ALTER COLUMN [AdminId] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [PK_HoroscropeReadings] PRIMARY KEY ([Id], [UserId], [PartnerId]);

GO

CREATE INDEX [IX_SaturnReports_UserId_PartnerId] ON [SaturnReports] ([UserId], [PartnerId]);

GO

CREATE INDEX [IX_Newsletters_UserId_PartnerId] ON [Newsletters] ([UserId], [PartnerId]);

GO

CREATE INDEX [IX_HoroscropeReadings_UserId_PartnerId] ON [HoroscropeReadings] ([UserId], [PartnerId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Customers_UserId_PartnerId] FOREIGN KEY ([UserId], [PartnerId]) REFERENCES [Customers] ([UserId], [PartnerId]) ON DELETE CASCADE;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Customers_UserId_PartnerId] FOREIGN KEY ([UserId], [PartnerId]) REFERENCES [Customers] ([UserId], [PartnerId]) ON DELETE CASCADE;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Customers_UserId_PartnerId] FOREIGN KEY ([UserId], [PartnerId]) REFERENCES [Customers] ([UserId], [PartnerId]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213164904_5', N'2.1.4-rtm-31024');

GO

