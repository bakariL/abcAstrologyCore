ALTER TABLE [Customers] DROP CONSTRAINT [FK_Customers_UserTypes_UserTypeId];

GO

ALTER TABLE [ReportUserAssociations] DROP CONSTRAINT [FK_ReportUserAssociations_UserPartners_UserPartnerId];

GO

DROP TABLE [UserPartnerAssociations];

GO

DROP TABLE [UserPartners];

GO

DROP TABLE [UserTypes];

GO

DROP INDEX [IX_ReportUserAssociations_UserPartnerId] ON [ReportUserAssociations];

GO

DROP INDEX [IX_Customers_UserTypeId] ON [Customers];

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ReportUserAssociations]') AND [c].[name] = N'UserPartnerId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [ReportUserAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [ReportUserAssociations] DROP COLUMN [UserPartnerId];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Customers]') AND [c].[name] = N'UserTypeId');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Customers] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Customers] DROP COLUMN [UserTypeId];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181106133058_reomvedDBs', N'2.1.4-rtm-31024');

GO

