ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerId];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[HoroscropeReadings]') AND [c].[name] = N'CustomerId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [HoroscropeReadings] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [HoroscropeReadings] ALTER COLUMN [CustomerId] int NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190111145406_takewacycsutDI', N'2.1.4-rtm-31024');

GO

