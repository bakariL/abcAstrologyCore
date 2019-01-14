ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_Reports_ReportId_ReportTypeId];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [FK_Newsletters_Reports_ReportId_ReportTypeId];

GO

ALTER TABLE [ReportTypes] DROP CONSTRAINT [FK_ReportTypes_Reports_ReportId_ReportTypeId];

GO

ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_Reports_ReportId_ReportTypeId];

GO

DROP TABLE [UserCustomerAssociations];

GO

DROP INDEX [IX_SaturnReports_ReportId_ReportTypeId] ON [SaturnReports];

GO

DROP INDEX [IX_ReportTypes_ReportId_ReportTypeId] ON [ReportTypes];

GO

ALTER TABLE [Reports] DROP CONSTRAINT [PK_Reports];

GO

DROP INDEX [IX_Newsletters_ReportId_ReportTypeId] ON [Newsletters];

GO

DROP INDEX [IX_HoroscropeReadings_ReportId_ReportTypeId] ON [HoroscropeReadings];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'ReportTypeId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [SaturnReports] DROP COLUMN [ReportTypeId];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ReportTypes]') AND [c].[name] = N'ReportTypeId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [ReportTypes] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [ReportTypes] DROP COLUMN [ReportTypeId];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Newsletters]') AND [c].[name] = N'ReportTypeId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Newsletters] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [Newsletters] DROP COLUMN [ReportTypeId];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'ReportTypeId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [HoroscropeReadings] DROP COLUMN [ReportTypeId];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'ReportTypeId');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Reports] ALTER COLUMN [ReportTypeId] nvarchar(max) NULL;

GO

ALTER TABLE [Reports] ADD CONSTRAINT [PK_Reports] PRIMARY KEY ([ReportId]);

GO

CREATE TABLE [ReportTypeAssocitaions] (
    [Id] int NOT NULL,
    [ReportID] nvarchar(450) NOT NULL,
    [ReportTypeID] nvarchar(450) NOT NULL,
    [UserId] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_ReportTypeAssocitaions] PRIMARY KEY ([ReportID], [ReportTypeID])
);

GO

CREATE INDEX [IX_SaturnReports_ReportId] ON [SaturnReports] ([ReportId]);

GO

CREATE INDEX [IX_ReportTypes_ReportId] ON [ReportTypes] ([ReportId]);

GO

CREATE INDEX [IX_Newsletters_ReportId] ON [Newsletters] ([ReportId]);

GO

CREATE INDEX [IX_HoroscropeReadings_ReportId] ON [HoroscropeReadings] ([ReportId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

ALTER TABLE [ReportTypes] ADD CONSTRAINT [FK_ReportTypes_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([ReportId]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213092208_6', N'2.1.4-rtm-31024');

GO

