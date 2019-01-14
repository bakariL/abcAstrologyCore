DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Message]') AND [c].[name] = N'Context');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Message] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Message] DROP COLUMN [Context];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190113020400_sdf', N'2.1.4-rtm-31024');

GO

