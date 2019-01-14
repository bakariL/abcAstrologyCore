ALTER TABLE [SaturnReports] ADD [BeginningDateofBirth] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [SaturnReports] ADD [DOB] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD [DateofBirth] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [SaturnReports] ADD [EndingDateofBirth] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [SaturnReports] ADD [UserFirstName] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD [UserGender] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD [UserLastName] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181226193358_98', N'2.1.4-rtm-31024');

GO

