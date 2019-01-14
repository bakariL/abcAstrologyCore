CREATE TABLE [Reports] (
    [Id] uniqueidentifier NOT NULL,
    [ReportId] nvarchar(max) NULL,
    [NewsID] nvarchar(max) NULL,
    [SatrunID] nvarchar(max) NULL,
    [HOrescopeID] nvarchar(max) NULL,
    [CreatedReportID] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    [CreatedBy] nvarchar(max) NULL,
    [UserId] nvarchar(450) NULL,
    [NewsletterId] smallint NULL,
    [HoroscropeReadingId] smallint NULL,
    [SaturnReportId] smallint NULL,
    CONSTRAINT [PK_Reports] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Reports_HoroscropeReadings_HoroscropeReadingId] FOREIGN KEY ([HoroscropeReadingId]) REFERENCES [HoroscropeReadings] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_Newsletters_NewsletterId] FOREIGN KEY ([NewsletterId]) REFERENCES [Newsletters] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_SaturnReports_SaturnReportId] FOREIGN KEY ([SaturnReportId]) REFERENCES [SaturnReports] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ReportTypes] (
    [Id] uniqueidentifier NOT NULL,
    [TypeOfReport] nvarchar(max) NULL,
    [Title] nvarchar(max) NULL,
    CONSTRAINT [PK_ReportTypes] PRIMARY KEY ([Id])
);

GO

CREATE INDEX [IX_Reports_HoroscropeReadingId] ON [Reports] ([HoroscropeReadingId]);

GO

CREATE INDEX [IX_Reports_NewsletterId] ON [Reports] ([NewsletterId]);

GO

CREATE INDEX [IX_Reports_SaturnReportId] ON [Reports] ([SaturnReportId]);

GO

CREATE INDEX [IX_Reports_UserId] ON [Reports] ([UserId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213082155_idk', N'2.1.4-rtm-31024');

GO

