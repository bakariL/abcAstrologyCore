EXEC sp_rename N'[UserCustomerAssociations].[UserId]', N'UserCustId', N'COLUMN';

GO

ALTER TABLE [UserCustomerAssociations] ADD [DOB] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [UserCustomerAssociations] ADD [DOBwithTime] datetime2 NULL;

GO

ALTER TABLE [UserCustomerAssociations] ADD [UCRoleId] int NOT NULL DEFAULT 0;

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
VALUES (N'20181107184842_backtoworking', N'2.1.4-rtm-31024');

GO

