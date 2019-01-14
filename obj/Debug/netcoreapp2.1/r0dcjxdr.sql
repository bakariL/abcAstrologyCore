ALTER TABLE [Admins] DROP CONSTRAINT [FK_Admins_Customers_CustomerId];

GO

ALTER TABLE [UserPartners] DROP CONSTRAINT [FK_UserPartners_UserTypes_TypeId1];

GO

DROP INDEX [IX_UserPartners_TypeId1] ON [UserPartners];

GO

DROP INDEX [IX_Admins_CustomerId] ON [Admins];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserPartners]') AND [c].[name] = N'TypeId1');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserPartners] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserPartners] DROP COLUMN [TypeId1];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Admins]') AND [c].[name] = N'CustomerId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Admins] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Admins] DROP COLUMN [CustomerId];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserPartners]') AND [c].[name] = N'TypeId');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [UserPartners] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [UserPartners] ALTER COLUMN [TypeId] int NULL;

GO

CREATE INDEX [IX_UserPartners_TypeId] ON [UserPartners] ([TypeId]);

GO

ALTER TABLE [UserPartners] ADD CONSTRAINT [FK_UserPartners_UserTypes_TypeId] FOREIGN KEY ([TypeId]) REFERENCES [UserTypes] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181106131801_hopingthisWOrks', N'2.1.4-rtm-31024');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181106132252_hopingthisWOrkss', N'2.1.4-rtm-31024');

GO

