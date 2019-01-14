ALTER TABLE [dbo].[tblUserRoles] ADD [AppUserId] nvarchar(450) NULL;

GO

ALTER TABLE [SaturnReports] ADD [CreatedByUserId] nvarchar(450) NULL;

GO

CREATE TABLE [UploadFile] (
    [Id] uniqueidentifier NOT NULL,
    [Order] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [Data] varbinary(max) NULL,
    [DocumentLinkName] nvarchar(max) NULL,
    [DocumentLink] nvarchar(max) NULL,
    CONSTRAINT [PK_UploadFile] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [UserFileAssociation] (
    [Id] int NOT NULL IDENTITY,
    [FileId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NULL,
    [ReadDate] datetime2 NULL,
    [IsAccepted] bit NULL,
    CONSTRAINT [PK_UserFileAssociation] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserFileAssociation_UploadFile_FileId] FOREIGN KEY ([FileId]) REFERENCES [UploadFile] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_UserFileAssociation_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_tblUserRoles_AppUserId] ON [dbo].[tblUserRoles] ([AppUserId]);

GO

CREATE INDEX [IX_SaturnReports_CreatedByUserId] ON [SaturnReports] ([CreatedByUserId]);

GO

CREATE INDEX [IX_UserFileAssociation_FileId] ON [UserFileAssociation] ([FileId]);

GO

CREATE INDEX [IX_UserFileAssociation_UserId] ON [UserFileAssociation] ([UserId]);

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_tblUsers_CreatedByUserId] FOREIGN KEY ([CreatedByUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [dbo].[tblUserRoles] ADD CONSTRAINT [FK_tblUserRoles_tblUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181027113542_ok2-addedUploadfIleUserFileAssociation-ViewModelsToo', N'2.1.4-rtm-31024');

GO

