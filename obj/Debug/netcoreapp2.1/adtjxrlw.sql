ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_UploadedFiles_Id];

GO

ALTER TABLE [Newsletters] DROP CONSTRAINT [FK_Newsletters_UploadedFiles_Id];

GO

ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_UploadedFiles_Id];

GO

DROP INDEX [IX_SaturnReports_Id] ON [SaturnReports];

GO

DROP INDEX [IX_Newsletters_Id] ON [Newsletters];

GO

DROP INDEX [IX_HoroscropeReadings_Id] ON [HoroscropeReadings];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181218103323_in2', N'2.1.4-rtm-31024');

GO

