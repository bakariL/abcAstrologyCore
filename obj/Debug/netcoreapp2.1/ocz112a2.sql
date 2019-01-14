ALTER TABLE [Customers] DROP CONSTRAINT [FK_Customers_tblUsers_AppUserId];

GO

DROP INDEX [IX_Customers_AppUserId] ON [Customers];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'AppUserId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Customers] ALTER COLUMN [AppUserId] int NOT NULL;

GO

ALTER TABLE [Customers] ADD [AppUserId1] nvarchar(450) NULL;

GO

CREATE INDEX [IX_Customers_AppUserId1] ON [Customers] ([AppUserId1]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_tblUsers_AppUserId1] FOREIGN KEY ([AppUserId1]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181103143621_ok7', N'2.1.4-rtm-31024');

GO

ALTER TABLE [dbo].[tblUsers] ADD [AppUserId] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181103143800_ok8', N'2.1.4-rtm-31024');

GO

