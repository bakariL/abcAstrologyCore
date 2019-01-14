ALTER TABLE [dbo].[tblUsers] ADD [SaturnId] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [dbo].[tblUsers] ADD [SaturnTitle] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181120153533_addedIdUser', N'2.1.4-rtm-31024');

GO

