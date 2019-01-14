ALTER TABLE [dbo].[tblUserRoles] DROP CONSTRAINT [FK_tblUserRoles_tblUsers_AppUserId];

GO

EXEC sp_rename N'[dbo].[tblUserRoles].[AppUserId]', N'ApplicationUserId', N'COLUMN';

GO

EXEC sp_rename N'[dbo].[tblUserRoles].[IX_tblUserRoles_AppUserId]', N'IX_tblUserRoles_ApplicationUserId', N'INDEX';

GO

ALTER TABLE [dbo].[tblUserRoles] ADD CONSTRAINT [FK_tblUserRoles_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181106135748_stilltrying18', N'2.1.4-rtm-31024');

GO

