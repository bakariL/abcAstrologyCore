ALTER TABLE [SaturnReports] DROP CONSTRAINT [PK_SaturnReports];

GO

DROP INDEX [IX_SaturnReports_Id] ON [SaturnReports];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [PK_Newsletters];

GO

DROP INDEX [IX_Newsletters_Id] ON [Newsletters];

GO

ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [PK_HoroscropeReadings];

GO

DROP INDEX [IX_HoroscropeReadings_Id] ON [HoroscropeReadings];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'SaturnReportId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [SaturnReports] ALTER COLUMN [SaturnReportId] nvarchar(max) NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Newsletters]') AND [c].[name] = N'NewsId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Newsletters] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Newsletters] ALTER COLUMN [NewsId] nvarchar(max) NULL;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'HorosopeId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [HoroscropeReadings] ALTER COLUMN [HorosopeId] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [PK_SaturnReports] PRIMARY KEY ([Id], [AdminId]);

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [PK_Newsletters] PRIMARY KEY ([Id], [UserId], [AdminId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [PK_HoroscropeReadings] PRIMARY KEY ([Id], [UserId], [AdminId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213104744_fkchange', N'2.1.4-rtm-31024');

GO

