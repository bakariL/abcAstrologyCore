ALTER TABLE [UserFileAssociation] DROP CONSTRAINT [FK_UserFileAssociation_UploadFile_FileId];

GO

ALTER TABLE [UserFileAssociation] DROP CONSTRAINT [FK_UserFileAssociation_tblUsers_UserId];

GO

ALTER TABLE [UserFileAssociation] DROP CONSTRAINT [PK_UserFileAssociation];

GO

ALTER TABLE [UploadFile] DROP CONSTRAINT [PK_UploadFile];

GO

EXEC sp_rename N'[UserFileAssociation]', N'UserFileAssociations';

GO

EXEC sp_rename N'[UploadFile]', N'UploadedFiles';

GO

EXEC sp_rename N'[UserFileAssociations].[IX_UserFileAssociation_UserId]', N'IX_UserFileAssociations_UserId', N'INDEX';

GO

EXEC sp_rename N'[UserFileAssociations].[IX_UserFileAssociation_FileId]', N'IX_UserFileAssociations_FileId', N'INDEX';

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [PK_UserFileAssociations] PRIMARY KEY ([Id]);

GO

ALTER TABLE [UploadedFiles] ADD CONSTRAINT [PK_UploadedFiles] PRIMARY KEY ([Id]);

GO

CREATE TABLE [UserTypes] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    CONSTRAINT [PK_UserTypes] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [UserPartners] (
    [Id] int NOT NULL IDENTITY,
    [TypeId] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [RequireOnboarding] bit NOT NULL,
    [TypeId1] int NULL,
    CONSTRAINT [PK_UserPartners] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserPartners_UserTypes_TypeId1] FOREIGN KEY ([TypeId1]) REFERENCES [UserTypes] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [ReportUserAssociations] (
    [Id] int NOT NULL IDENTITY,
    [ReportId] uniqueidentifier NOT NULL,
    [PartnerId] uniqueidentifier NOT NULL,
    [SaturnReportId] int NULL,
    [UserPartnerId] int NULL,
    CONSTRAINT [PK_ReportUserAssociations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_ReportUserAssociations_SaturnReports_SaturnReportId] FOREIGN KEY ([SaturnReportId]) REFERENCES [SaturnReports] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ReportUserAssociations_UserPartners_UserPartnerId] FOREIGN KEY ([UserPartnerId]) REFERENCES [UserPartners] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_ReportUserAssociations_SaturnReportId] ON [ReportUserAssociations] ([SaturnReportId]);

GO

CREATE INDEX [IX_ReportUserAssociations_UserPartnerId] ON [ReportUserAssociations] ([UserPartnerId]);

GO

CREATE INDEX [IX_UserPartners_TypeId1] ON [UserPartners] ([TypeId1]);

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_UploadedFiles_FileId] FOREIGN KEY ([FileId]) REFERENCES [UploadedFiles] ([Id]) ON DELETE CASCADE;

GO

ALTER TABLE [UserFileAssociations] ADD CONSTRAINT [FK_UserFileAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181027124133_ok3-addedReportUserAssoc-UploadFile-USerFileAccs-UserParter-UserType-RegistterViewModel', N'2.1.4-rtm-31024');

GO

