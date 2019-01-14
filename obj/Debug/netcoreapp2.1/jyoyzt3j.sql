DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'UseriId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserCustomerAssociations] DROP COLUMN [UseriId];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181121194416_2134', N'2.1.4-rtm-31024');

GO

