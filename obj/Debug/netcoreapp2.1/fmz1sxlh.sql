ALTER TABLE [Reports] DROP CONSTRAINT [FK_Reports_HoroscropeReadings_HoroscropeReadingId];

GO

ALTER TABLE [Reports] DROP CONSTRAINT [FK_Reports_Newsletters_NewsletterId];

GO

ALTER TABLE [Reports] DROP CONSTRAINT [FK_Reports_SaturnReports_SaturnReportId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_Customers_CustomerId1];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_HoroscropeReadings_HoroscropeId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_Newsletters_NewsletterId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [FK_UserFileAssociations_SaturnReports_SaturnId];

GO

ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [PK_UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_CustomerId1] ON [UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_HoroscropeId] ON [UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_NewsletterId] ON [UserFileAssociations];

GO

DROP INDEX [IX_UserFileAssociations_SaturnId] ON [UserFileAssociations];

GO

ALTER TABLE [Reports] DROP CONSTRAINT [PK_Reports];

GO

DROP INDEX [IX_Reports_HoroscropeReadingId] ON [Reports];

GO

DROP INDEX [IX_Reports_NewsletterId] ON [Reports];

GO

DROP INDEX [IX_Reports_SaturnReportId] ON [Reports];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'CustomerId1');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [CustomerId1];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'HoroscropeId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [HoroscropeId];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'NewsletterId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [NewsletterId];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'SaturnId');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [SaturnId];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'Id');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Reports] DROP COLUMN [Id];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'CreatedBy');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Reports] DROP COLUMN [CreatedBy];

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'CreatedReportID');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Reports] DROP COLUMN [CreatedReportID];

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'HOrescopeID');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Reports] DROP COLUMN [HOrescopeID];

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'HoroscropeReadingId');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Reports] DROP COLUMN [HoroscropeReadingId];

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'NewsID');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Reports] DROP COLUMN [NewsID];

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'NewsletterId');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Reports] DROP COLUMN [NewsletterId];

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'SatrunID');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Reports] DROP COLUMN [SatrunID];

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'SaturnReportId');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Reports] DROP COLUMN [SaturnReportId];

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'FileId');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [UserFileAssociations] ALTER COLUMN [FileId] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [SaturnReports] ADD [ReportTypeId] nvarchar(450) NULL;

GO

ALTER TABLE [ReportTypes] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [ReportTypes] ADD [ReportTypeId] nvarchar(450) NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Reports]') AND [c].[name] = N'ReportId');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Reports] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [Reports] ALTER COLUMN [ReportId] uniqueidentifier NOT NULL;

GO

ALTER TABLE [Reports] ADD [ReportTypeId] nvarchar(450) NOT NULL DEFAULT N'';

GO

ALTER TABLE [Newsletters] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [Newsletters] ADD [ReportTypeId] nvarchar(450) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportID] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportId] uniqueidentifier NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ReportTypeId] nvarchar(450) NULL;

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [PK_UserFileAssociations] PRIMARY KEY ([AdminId], [CustomerId]);

GO

ALTER TABLE [Reports] ADD CONSTRAINT [PK_Reports] PRIMARY KEY ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_SaturnReports_ReportId_ReportTypeId] ON [SaturnReports] ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_ReportTypes_ReportId_ReportTypeId] ON [ReportTypes] ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_Newsletters_ReportId_ReportTypeId] ON [Newsletters] ([ReportId], [ReportTypeId]);

GO

CREATE INDEX [IX_HoroscropeReadings_ReportId_ReportTypeId] ON [HoroscropeReadings] ([ReportId], [ReportTypeId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

ALTER TABLE [ReportTypes] ADD CONSTRAINT [FK_ReportTypes_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Reports_ReportId_ReportTypeId] FOREIGN KEY ([ReportId], [ReportTypeId]) REFERENCES [Reports] ([ReportId], [ReportTypeId]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213085848_idddd', N'2.1.4-rtm-31024');

GO

