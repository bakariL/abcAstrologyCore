DROP TABLE [UserPartnerAssociation];

GO

EXEC sp_rename N'[Partners].[UserName]', N'Name', N'COLUMN';

GO

CREATE TABLE [UserCustomerAssociations] (
    [PartnerId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NULL,
    [CustomerId] int NOT NULL,
    [Email] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [CompeltedOnBoarding] bit NOT NULL,
    CONSTRAINT [PK_UserCustomerAssociations] PRIMARY KEY ([PartnerId]),
    CONSTRAINT [FK_UserCustomerAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_UserCustomerAssociations_UserId] ON [UserCustomerAssociations] ([UserId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181203200538_ok1', N'2.1.4-rtm-31024');

GO

