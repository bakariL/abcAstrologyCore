DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[UserCustomerAssociations]') AND [c].[name] = N'UserId');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [UserCustomerAssociations] ALTER COLUMN [UserId] uniqueidentifier NOT NULL;

GO

ALTER TABLE [UserCustomerAssociations] ADD [DOB] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [UserCustomerAssociations] ADD [DOBwithTime] datetime2 NULL;

GO

ALTER TABLE [UserCustomerAssociations] ADD [UCRoleId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

ALTER TABLE [SaturnReports] ADD [UserCustomerAssociationId] int NULL;

GO

ALTER TABLE [Newsletters] ADD [UserCustomerAssociationId] int NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [UserCustomerAssociationId] int NULL;

GO

CREATE INDEX [IX_SaturnReports_UserCustomerAssociationId] ON [SaturnReports] ([UserCustomerAssociationId]);

GO

CREATE INDEX [IX_Newsletters_UserCustomerAssociationId] ON [Newsletters] ([UserCustomerAssociationId]);

GO

CREATE INDEX [IX_HoroscropeReadings_UserCustomerAssociationId] ON [HoroscropeReadings] ([UserCustomerAssociationId]);

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_UserCustomerAssociations_UserCustomerAssociationId] FOREIGN KEY ([UserCustomerAssociationId]) REFERENCES [UserCustomerAssociations] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_UserCustomerAssociations_UserCustomerAssociationId] FOREIGN KEY ([UserCustomerAssociationId]) REFERENCES [UserCustomerAssociations] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_UserCustomerAssociations_UserCustomerAssociationId] FOREIGN KEY ([UserCustomerAssociationId]) REFERENCES [UserCustomerAssociations] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181107173625_userCustAssoc', N'2.1.4-rtm-31024');

GO

