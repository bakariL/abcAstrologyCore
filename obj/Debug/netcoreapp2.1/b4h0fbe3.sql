CREATE TABLE [UserCustomerAssociations] (
    [Id] int NOT NULL IDENTITY,
    [UserId] int NOT NULL,
    [CustomerId] int NOT NULL,
    [Email] nvarchar(max) NULL,
    [UserName] nvarchar(max) NULL,
    [PhoneNumber] int NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    CONSTRAINT [PK_UserCustomerAssociations] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181106220335_addedCustomerUserAssociationTable', N'2.1.4-rtm-31024');

GO

