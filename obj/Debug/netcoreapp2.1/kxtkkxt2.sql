CREATE TABLE [UserPartnerAssociations] (
    [Id] int NOT NULL IDENTITY,
    [UserPartnerId] uniqueidentifier NOT NULL,
    [UserId] nvarchar(450) NULL,
    [CompletedOnboarding] bit NOT NULL,
    [UerPartnerId] int NULL,
    CONSTRAINT [PK_UserPartnerAssociations] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_UserPartnerAssociations_UserPartners_UerPartnerId] FOREIGN KEY ([UerPartnerId]) REFERENCES [UserPartners] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_UserPartnerAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_UserPartnerAssociations_UerPartnerId] ON [UserPartnerAssociations] ([UerPartnerId]);

GO

CREATE INDEX [IX_UserPartnerAssociations_UserId] ON [UserPartnerAssociations] ([UserId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181101200945_ok4-addedUserRoleToRegisterView', N'2.1.4-rtm-31024');

GO

