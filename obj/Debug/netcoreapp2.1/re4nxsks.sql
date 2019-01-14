ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [FK_UserCustomerAssociations_Partners_PartnerId1];

GO

ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [FK_UserCustomerAssociations_tblUsers_UserId];

GO

ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [PK_UserCustomerAssociations];

GO

EXEC sp_rename N'[UserCustomerAssociations]', N'UserPartnerAssociation';

GO

EXEC sp_rename N'[UserPartnerAssociation].[IX_UserCustomerAssociations_UserId]', N'IX_UserPartnerAssociation_UserId', N'INDEX';

GO

EXEC sp_rename N'[UserPartnerAssociation].[IX_UserCustomerAssociations_PartnerId1]', N'IX_UserPartnerAssociation_PartnerId1', N'INDEX';

GO

ALTER TABLE [UserPartnerAssociation] ADD CONSTRAINT [PK_UserPartnerAssociation] PRIMARY KEY ([PartnerId]);

GO

ALTER TABLE [UserPartnerAssociation] ADD CONSTRAINT [FK_UserPartnerAssociation_Partners_PartnerId1] FOREIGN KEY ([PartnerId1]) REFERENCES [Partners] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [UserPartnerAssociation] ADD CONSTRAINT [FK_UserPartnerAssociation_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181121201021_f', N'2.1.4-rtm-31024');

GO

