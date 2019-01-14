ALTER TABLE [SaturnReports] DROP CONSTRAINT [FK_SaturnReports_tblUsers_ApplicationUserId];

GO

EXEC sp_rename N'[SaturnReports].[ApplicationUserId]', N'UserId', N'COLUMN';

GO

EXEC sp_rename N'[SaturnReports].[IX_SaturnReports_ApplicationUserId]', N'IX_SaturnReports_UserId', N'INDEX';

GO

CREATE TABLE [ToDo] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Priority] int NOT NULL,
    [IsDone] bit NOT NULL,
    CONSTRAINT [PK_ToDo] PRIMARY KEY ([Id])
);

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181115172438_SaturnReport', N'2.1.4-rtm-31024');

GO

