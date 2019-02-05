INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190201173123_requ', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Request] ADD [UserZip] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [HoroscropeReadings] ADD [BirthCity] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [BirthZipCode] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [HoroscropeReadings] ADD [Dob] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [HoroscropeReadings] ADD [FatherFullName] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [Gender] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [MiddleName] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [MiddleNametwo] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [MothersFullName] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [SecondFirstName] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [State] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [TimeOfBirth] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [HoroscropeReadings] ADD [UserZip] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190204173812_new32', N'2.1.4-rtm-31024');

GO

