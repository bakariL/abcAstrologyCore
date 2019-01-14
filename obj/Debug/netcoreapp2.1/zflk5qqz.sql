ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_tblUsers_ApplicationUserId];

GO

EXEC sp_rename N'[HoroscropeReadings].[ApplicationUserId]', N'UserId', N'COLUMN';

GO

EXEC sp_rename N'[HoroscropeReadings].[IX_HoroscropeReadings_ApplicationUserId]', N'IX_HoroscropeReadings_UserId', N'INDEX';

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181115173915_addHorescopeUser', N'2.1.4-rtm-31024');

GO

