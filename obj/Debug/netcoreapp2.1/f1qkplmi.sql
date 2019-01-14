ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [FK_UserCustomerAssociations_Partners_PartnerId];

GO

ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [PK_UserCustomerAssociations];

GO

DROP INDEX [IX_UserCustomerAssociations_PartnerId] ON [UserCustomerAssociations];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'Id');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [Id];

GO

EXEC sp_rename N'[Partners].[UserId]', N'Name', N'COLUMN';

GO

ALTER TABLE [UserCustomerAssociations] ADD [PartnerId1] uniqueidentifier NULL;

GO

ALTER TABLE [UserCustomerAssociations] ADD CONSTRAINT [PK_UserCustomerAssociations] PRIMARY KEY ([PartnerId]);

GO

CREATE INDEX [IX_UserCustomerAssociations_PartnerId1] ON [UserCustomerAssociations] ([PartnerId1]);

GO

ALTER TABLE [UserCustomerAssociations] ADD CONSTRAINT [FK_UserCustomerAssociations_Partners_PartnerId1] FOREIGN KEY ([PartnerId1]) REFERENCES [Partners] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181121200345_updatedIds', N'2.1.4-rtm-31024');

GO

