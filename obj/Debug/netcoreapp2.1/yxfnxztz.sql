DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'IsAccepted');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [IsAccepted];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'ReadDate');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [UserFileAssociations] DROP COLUMN [ReadDate];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserFileAssociations]') AND [c].[name] = N'UserId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [UserFileAssociations] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [UserFileAssociations] ALTER COLUMN [UserId] uniqueidentifier NOT NULL;

GO

ALTER TABLE [UserFileAssociations] ADD [FileGuidId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

ALTER TABLE [UserFileAssociations] ADD [HoroscropeId] int NULL;

GO

ALTER TABLE [UserFileAssociations] ADD [NewsletterId] int NULL;

GO

ALTER TABLE [UserFileAssociations] ADD [SaturnId] int NULL;

GO

CREATE INDEX [IX_UserFileAssociations_HoroscropeId] ON [UserFileAssociations] ([HoroscropeId]);

GO

CREATE INDEX [IX_UserFileAssociations_NewsletterId] ON [UserFileAssociations] ([NewsletterId]);

GO

CREATE INDEX [IX_UserFileAssociations_SaturnId] ON [UserFileAssociations] ([SaturnId]);

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_HoroscropeReadings_HoroscropeId] FOREIGN KEY ([HoroscropeId]) REFERENCES [HoroscropeReadings] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_Newsletters_NewsletterId] FOREIGN KEY ([NewsletterId]) REFERENCES [Newsletters] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_SaturnReports_SaturnId] FOREIGN KEY ([SaturnId]) REFERENCES [SaturnReports] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181115203551_addedALOT', N'2.1.4-rtm-31024');

GO

