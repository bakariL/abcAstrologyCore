EXEC sp_rename N'[Customers].[Name]', N'UserName', N'COLUMN';

GO

ALTER TABLE [SaturnReports] ADD [CustomerId] int NULL;

GO

ALTER TABLE [Newsletters] ADD [CustomerId] int NULL;

GO

ALTER TABLE [HoroscropeReadings] ADD [CustomerId] int NULL;

GO

ALTER TABLE [Customers] ADD [DOB] datetime2 NOT NULL DEFAULT '0001-01-01T00:00:00.0000000';

GO

ALTER TABLE [Customers] ADD [DOBwithTime] datetime2 NULL;

GO

ALTER TABLE [Customers] ADD [FirstName] nvarchar(max) NULL;

GO

ALTER TABLE [Customers] ADD [IsActive] bit NOT NULL DEFAULT 0;

GO

ALTER TABLE [Customers] ADD [LastName] nvarchar(max) NULL;

GO

ALTER TABLE [Customers] ADD [UserTypeId] int NULL;

GO

CREATE INDEX [IX_SaturnReports_CustomerId] ON [SaturnReports] ([CustomerId]);

GO

CREATE INDEX [IX_Newsletters_CustomerId] ON [Newsletters] ([CustomerId]);

GO

CREATE INDEX [IX_HoroscropeReadings_CustomerId] ON [HoroscropeReadings] ([CustomerId]);

GO

CREATE INDEX [IX_Customers_UserTypeId] ON [Customers] ([UserTypeId]);

GO

ALTER TABLE [Customers] ADD CONSTRAINT [FK_Customers_UserTypes_UserTypeId] FOREIGN KEY ([UserTypeId]) REFERENCES [UserTypes] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [HoroscropeReadings] ADD CONSTRAINT [FK_HoroscropeReadings_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [Newsletters] ADD CONSTRAINT [FK_Newsletters_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

ALTER TABLE [SaturnReports] ADD CONSTRAINT [FK_SaturnReports_Customers_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customers] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181102165059_ok4-addedtoCustosterModel', N'2.1.4-rtm-31024');

GO

