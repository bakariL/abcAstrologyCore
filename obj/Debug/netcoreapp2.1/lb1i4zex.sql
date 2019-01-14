CREATE TABLE [PartnerTypeAssociations] (
    [PartnerTypeId] uniqueidentifier NOT NULL,
    [PartnerId] nvarchar(450) NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_PartnerTypeAssociations] PRIMARY KEY ([PartnerTypeId], [PartnerId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181214115808_u', N'2.1.4-rtm-31024');

GO

