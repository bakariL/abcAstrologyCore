ALTER TABLE [Emails] DROP CONSTRAINT [PK_Emails];

GO

EXEC sp_rename N'[Emails]', N'Message';

GO

ALTER TABLE [Message] ADD CONSTRAINT [PK_Message] PRIMARY KEY ([Id]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181221191106_34', N'2.1.4-rtm-31024');

GO

