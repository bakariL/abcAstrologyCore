ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_Reports_Id];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [FK_Newsletters_Reports_Id];

GO

ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_Reports_Id];

GO

ALTER TABLE [ReportTypeAssocitaions] DROP CONSTRAINT [PK_ReportTypeAssocitaions];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'Id');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [SaturnReports] ALTER COLUMN [Id] smallint NOT NULL;

GO

ALTER TABLE [SaturnReports] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [ReportTypeAssocitaions] ADD [Id] smallint NOT NULL DEFAULT CAST(0 AS smallint);

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Newsletters]') AND [c].[name] = N'Id');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Newsletters] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Newsletters] ALTER COLUMN [Id] smallint NOT NULL;

GO

ALTER TABLE [Newsletters] ADD [ReportId] uniqueidentifier NULL;

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'Id');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [HoroscropeReadings] ALTER COLUMN [Id] smallint NOT NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [ReportTypeAssocitaions] ADD CONSTRAINT [PK_ReportTypeAssocitaions] PRIMARY KEY ([Id], [ReportTypeID]);

GO

CREATE INDEX [IX_SaturnReports_ReportId] ON [SaturnReports] ([ReportId]);

GO

CREATE INDEX [IX_Newsletters_ReportId] ON [Newsletters] ([ReportId]);

GO

CREATE INDEX [IX_HoroscropeReadings_ReportId] ON [HoroscropeReadings] ([ReportId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213105320_fkchanges', N'2.1.4-rtm-31024');

GO

