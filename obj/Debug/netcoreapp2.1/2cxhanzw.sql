ALTER TABLE [SaturnReports] DROP CONSTRAINT [PK_SaturnReports];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [PK_Newsletters];

GO

ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [PK_HoroscropeReadings];

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [PK_SaturnReports] PRIMARY KEY ([Id]);

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [PK_Newsletters] PRIMARY KEY ([Id]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [PK_HoroscropeReadings] PRIMARY KEY ([Id]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181221153437_r', N'2.1.4-rtm-31024');

GO

