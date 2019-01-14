ALTER TABLE [UserFileAssociations] ADD [ReportId] uniqueidentifier NULL;

GO

CREATE TABLE [ReportTypes] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_ReportTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Reports] (
    [Id] uniqueidentifier NOT NULL,
    [TypeId] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [ReportCreatedBy] nvarchar(max) NULL,
    [DateCreated] datetime2 NOT NULL,
    [HostUser] nvarchar(max) NULL,
    [MyProperty] int NOT NULL,
    [ImageFileName] nvarchar(max) NULL,
    [ImageFileData] varbinary(max) NULL,
    [IsDeleted] bit NOT NULL,
    [ReportTypeId] uniqueidentifier NULL,
    [CreatedByUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_Reports] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Reports_tblUsers_CreatedByUserId] FOREIGN KEY ([CreatedByUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Reports_ReportTypes_ReportTypeId] FOREIGN KEY ([ReportTypeId]) REFERENCES [ReportTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_UserFileAssociations_ReportId] ON [UserFileAssociations] ([ReportId]);

GO

CREATE INDEX [IX_Reports_CreatedByUserId] ON [Reports] ([CreatedByUserId]);

GO

CREATE INDEX [IX_Reports_ReportTypeId] ON [Reports] ([ReportTypeId]);

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_Reports_ReportId] FOREIGN KEY ([ReportId]) REFERENCES [Reports] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181115204115_addeddbreport', N'2.1.4-rtm-31024');

GO

