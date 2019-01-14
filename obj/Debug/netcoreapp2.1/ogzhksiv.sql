DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[tblUsers]') AND [c].[name] = N'SaturnId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[tblUsers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [dbo].[tblUsers] DROP COLUMN [SaturnId];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[tblUsers]') AND [c].[name] = N'SaturnTitle');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[tblUsers] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [dbo].[tblUsers] DROP COLUMN [SaturnTitle];

GO

ALTER TABLE [SaturnReports] ADD [FileId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

ALTER TABLE [Customers] ADD [CustomerId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181120173634_ok13', N'2.1.4-rtm-31024');

GO

