ALTER TABLE [Customers] ADD [UserId] nvarchar(450) NULL;

GO

CREATE INDEX [IX_Customers_UserId] ON [Customers] ([UserId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_tblUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181115173159_addCustomerSaturn', N'2.1.4-rtm-31024');

GO

