ALTER TABLE [dbo].[Customers] ADD [IsSubscribed] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [SaturnReports] ADD [BaseCost] decimal(18, 2) NOT NULL DEFAULT 0.0;

GO

ALTER TABLE [SaturnReports] ADD [IsSubscribed] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [SaturnReports] ADD [UserEmail] nvarchar(max) NULL;

GO

ALTER TABLE [Newsletters] ADD [BaseCost] decimal(18, 2) NOT NULL DEFAULT 0.0;

GO

ALTER TABLE [Newsletters] ADD [IsSubscribed] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [Newsletters] ADD [UserEmail] nvarchar(max) NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [BaseCost] decimal(18, 2) NOT NULL DEFAULT 0.0;

GO

ALTER TABLE [HoroscropeReadings] ADD [IsSubscribed] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [HoroscropeReadings] ADD [UserEmail] nvarchar(max) NULL;

GO

ALTER TABLE [Emails] ADD [Context] nvarchar(max) NULL;

GO

ALTER TABLE [Emails] ADD [htmlMessage] nvarchar(max) NULL;

GO

CREATE TABLE [TextMsg] (
    [Id] int NOT NULL IDENTITY,
    [To] int NOT NULL,
    [From] int NOT NULL,
    [Message] nvarchar(max) NULL,
    CONSTRAINT [PK_TextMsg] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181218193946_text', N'2.1.4-rtm-31024');

GO

