ALTER TABLE [Customers] ADD [HorescopeId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

ALTER TABLE [Customers] ADD [SaturnId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181120194620_ok14', N'2.1.4-rtm-31024');

GO

