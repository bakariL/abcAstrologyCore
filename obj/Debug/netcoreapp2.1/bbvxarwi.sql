INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181226202130_request', N'2.1.4-rtm-31024');

GO

CREATE TABLE [Request] (
    [Id] int NOT NULL IDENTITY,
    [UserFirstName] nvarchar(max) NULL,
    [UserLastName] nvarchar(max) NULL,
    [UserDOB] datetime2 NOT NULL,
    [Gender] nvarchar(max) NULL,
    [email] nvarchar(max) NULL,
    [Type] nvarchar(max) NULL,
    [UserName] nvarchar(max) NULL,
    [DateRequested] datetime2 NOT NULL,
    [IsUser] bit NOT NULL,
    CONSTRAINT [PK_Request] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181226202534_rer', N'2.1.4-rtm-31024');

GO

