ALTER TABLE [SaturnReports] ADD [HostUser] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181115235339_ok12', N'2.1.4-rtm-31024');

GO

