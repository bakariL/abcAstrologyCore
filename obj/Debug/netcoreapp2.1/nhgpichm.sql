ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_Reports_Id];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'Id');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [SaturnReports] ALTER COLUMN [Id] uniqueidentifier NOT NULL;

GO

ALTER TABLE [SaturnReports] ADD [ReportId] smallint NULL;

GO

CREATE INDEX [IX_SaturnReports_ReportId] ON [SaturnReports] ([ReportId]);

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213115835_7', N'2.1.4-rtm-31024');

GO

