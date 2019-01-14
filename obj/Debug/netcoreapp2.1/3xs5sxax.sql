ALTER TABLE [UserCustomerAssociations] DROP CONSTRAINT [FK_UserCustomerAssociations_Customers_CustomerId];

GO

DROP INDEX [IX_UserCustomerAssociations_CustomerId] ON [UserCustomerAssociations];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181211201748_deltefk', N'2.1.4-rtm-31024');

GO

