ALTER TABLE [dbo].[tblUsers] ADD [IsTerminated] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [dbo].[tblUsers] ADD [StartDate] datetime2 NULL;

GO

ALTER TABLE [SaturnReports] ADD [ApplicationUserId] nvarchar(450) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [ApplicationUserId] nvarchar(450) NULL;

GO

CREATE INDEX [IX_SaturnReports_ApplicationUserId] ON [SaturnReports] ([ApplicationUserId]);

GO

CREATE INDEX [IX_HoroscropeReadings_ApplicationUserId] ON [HoroscropeReadings] ([ApplicationUserId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181112192602_addedUserandCustomerRelationship', N'2.1.4-rtm-31024');

GO

