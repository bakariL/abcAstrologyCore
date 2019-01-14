﻿DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[dbo].[tblUsers]') AND [c].[name] = N'PartnerId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [dbo].[tblUsers] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [dbo].[tblUsers] ALTER COLUMN [PartnerId] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181214155750_345', N'2.1.4-rtm-31024');

GO

