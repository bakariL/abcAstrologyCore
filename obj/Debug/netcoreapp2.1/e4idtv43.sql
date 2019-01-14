EXEC sp_rename N'[Partners].[Name]', N'UserId', N'COLUMN';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181121194624_22332', N'2.1.4-rtm-31024');

GO

