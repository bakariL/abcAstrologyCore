ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [FK_UserCustomerAssociations_tblUsers_UserId];

GO

ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [PK_UserCustomerAssociations];

GO

DROP INDEX [IX_UserCustomerAssociations_UserId] ON [UserCustomerAssociations];
DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'UserId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserCustomerAssociations] ALTER COLUMN [UserId] nvarchar(450) NOT NULL;
CREATE INDEX [IX_UserCustomerAssociations_UserId] ON [UserCustomerAssociations] ([UserId]);

GO

ALTER TABLE [UserCustomerAssociations] ADD CONSTRAINT [AK_UserCustomerAssociations_PartnerId] UNIQUE ([PartnerId]);

GO

ALTER TABLE [UserCustomerAssociations] ADD CONSTRAINT [PK_UserCustomerAssociations] PRIMARY KEY ([PartnerId], [UserId]);

GO

ALTER TABLE [UserCustomerAssociations] ADD CONSTRAINT [FK_UserCustomerAssociations_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE CASCADE;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181210161311_addKeys', N'2.1.4-rtm-31024');

GO

