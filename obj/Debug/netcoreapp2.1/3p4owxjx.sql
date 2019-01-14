ALTER TABLE [SaturnReports] ADD [AdminUserName] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD [AuthorFirstName] nvarchar(max) NULL;

GO

ALTER TABLE [SaturnReports] ADD [AuthorLastName] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181212180905_intailcreasdfsdf', N'2.1.4-rtm-31024');

GO

