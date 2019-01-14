ALTER TABLE [Admins] ADD [CustomerId] int NULL;

GO

CREATE INDEX [IX_Admins_CustomerId] ON [Admins] ([CustomerId]);

GO

ALTER TABLE [Admins] ADD CONSTRAINT [FK_Admins_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104011741_ok11', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Customers] DROP CONSTRAINT [FK_Customers_Admins_AdminId];

GO

DROP INDEX [IX_Customers_AdminId] ON [Customers];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'AdminId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Customers] DROP COLUMN [AdminId];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104012248_ok12', N'2.1.4-rtm-31024');

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

CREATE INDEX [IX_Customers_AppUserId] ON [Customers] ([AppUserId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_tblUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104170907_ok114', N'2.1.4-rtm-31024');

GO

