ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_Partners_PartnerId1];

GO

DROP INDEX [IX_HoroscropeReadings_PartnerId1] ON [HoroscropeReadings];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'PartnerId1');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [HoroscropeReadings] DROP COLUMN [PartnerId1];

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportID] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213091025_3', N'2.1.4-rtm-31024');

GO

