ALTER TABLE [Request] ADD [DobDate] nvarchar(max) NULL;

GO

ALTER TABLE [Request] ADD [DobDay] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Request] ADD [DobMonthnum] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Request] ADD [DobYear] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190207152042_addedFeildsToRequest', N'2.1.4-rtm-31024');

GO

