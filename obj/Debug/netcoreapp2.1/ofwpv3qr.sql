ALTER TABLE [Admins] ADD [CustomerId] int NULL;

GO

CREATE INDEX [IX_Admins_CustomerId] ON [Admins] ([CustomerId]);

GO

ALTER TABLE [Admins] ADD CONSTRAINT [FK_Admins_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104011741_ok11', N'2.1.4-rtm-31024');

GO

