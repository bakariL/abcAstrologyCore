CREATE TABLE [Customers] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Customers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [HoroscropeReadings] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Desciption] nvarchar(max) NULL,
    [BodyText] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    CONSTRAINT [PK_HoroscropeReadings] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Newsletters] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Desciption] nvarchar(max) NULL,
    [BodyText] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    CONSTRAINT [PK_Newsletters] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [SaturnReports] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Desciption] nvarchar(max) NULL,
    [BodyText] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    CONSTRAINT [PK_SaturnReports] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181026192328_ok1', N'2.1.4-rtm-31024');

GO

