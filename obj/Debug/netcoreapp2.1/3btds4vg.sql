EXEC sp_rename N'[Request].[email]', N'Email', N'COLUMN';

GO

ALTER TABLE [Request] ADD [UserId] nvarchar(450) NULL;

GO

CREATE INDEX [IX_Request_UserId] ON [Request] ([UserId]);

GO

ALTER TABLE [Request] ADD CONSTRAINT [FK_Request_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181226205249_radsds', N'2.1.4-rtm-31024');

GO

