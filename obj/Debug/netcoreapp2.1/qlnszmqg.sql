ALTER TABLE [Customers] ADD [AdminId] int NULL;

GO

CREATE TABLE [Admins] (
    [Id] int NOT NULL IDENTITY,
    [AdminUserId] uniqueidentifier NOT NULL,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    CONSTRAINT [PK_Admins] PRIMARY KEY ([Id])
);

GO

CREATE INDEX [IX_Customers_AdminId] ON [Customers] ([AdminId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_Admins_AdminId] FOREIGN KEY ([AdminId]) REFERENCES [Admins] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104011430_ok10', N'2.1.4-rtm-31024');

GO

ALTER TABLE [Admins] ADD [CustomerId] int NULL;

GO

CREATE INDEX [IX_Admins_CustomerId] ON [Admins] ([CustomerId]);

GO

ALTER TABLE [Admins] ADD CONSTRAINT [FK_Admins_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181104011741_ok11', N'2.1.4-rtm-31024');

GO

