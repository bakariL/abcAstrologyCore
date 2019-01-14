ALTER TABLE [dbo].[Customers] ADD [DateRegistered] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181226171726_4', N'2.1.4-rtm-31024');

GO

