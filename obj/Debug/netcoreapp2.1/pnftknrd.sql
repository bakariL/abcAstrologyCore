ALTER TABLE [Customers] ADD [AppUserId] nvarchar(450) NULL;

GO

ALTER TABLE [Customers] ADD [CustomerId] uniqueidentifier NOT NULL DEFAULT '00000000-0000-0000-0000-000000000000';

GO

CREATE INDEX [IX_Customers_AppUserId] ON [Customers] ([AppUserId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_tblUsers_AppUserId] FOREIGN KEY ([AppUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181102170253_ok5-addedtoCustosterModel', N'2.1.4-rtm-31024');

GO

