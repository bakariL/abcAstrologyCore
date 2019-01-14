ALTER TABLE [Partners] ADD [CustomerCount] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [NewsletterSubscribersCount] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [NewslettersCreated] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [NewslettersSent] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [ReadingSent] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [ReadingsCount] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [RedaingsRequest] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [SaturnReportCount] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [SaturnReportsCount] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [SaturnReportsRequested] int NOT NULL DEFAULT 0;

GO

ALTER TABLE [Partners] ADD [SaturnReportsSent] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181226181230_morefeilds', N'2.1.4-rtm-31024');

GO

