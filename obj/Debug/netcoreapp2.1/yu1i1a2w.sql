﻿ALTER TABLE [SaturnReports] DROP CONSTRAINT [PK_SaturnReports];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[SaturnReports]') AND [c].[name] = N'UserId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [SaturnReports] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [SaturnReports] ALTER COLUMN [UserId] nvarchar(450) NOT NULL;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [PK_SaturnReports] PRIMARY KEY ([Id], [AdminId], [UserId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213113443_2', N'2.1.4-rtm-31024');

GO

