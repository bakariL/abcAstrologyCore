EXEC sp_rename N'[Partners].[Name]', N'UserName', N'COLUMN';

GO

ALTER TABLE [UserPartnerAssociation] ADD [CustomerId] nvarchar(max) NULL;

GO

ALTER TABLE [Partners] ADD [Email] nvarchar(max) NULL;

GO

ALTER TABLE [Partners] ADD [FirstName] nvarchar(max) NULL;

GO

ALTER TABLE [Partners] ADD [LastName] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181126153144_changedCustId', N'2.1.4-rtm-31024');

GO

