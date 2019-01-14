ALTER TABLE [SaturnReports] ADD [UserGuid] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

ALTER TABLE [SaturnReports] ADD [UserIntId] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181120153040_addedIdtoSaturnreport', N'2.1.4-rtm-31024');

GO

