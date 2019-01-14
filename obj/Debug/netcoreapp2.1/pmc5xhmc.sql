EXEC sp_rename N'[Emails].[To]', N'Email', N'COLUMN';

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181218194830_texts', N'2.1.4-rtm-31024');

GO

