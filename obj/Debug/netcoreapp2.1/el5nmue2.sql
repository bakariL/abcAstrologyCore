ALTER TABLE [ReportTypeAssocitaions] DROP CONSTRAINT [PK_ReportTypeAssocitaions];

GO

ALTER TABLE [ReportTypeAssocitaions] ADD CONSTRAINT [PK_ReportTypeAssocitaions] PRIMARY KEY ([ReportID], [ReportTypeID], [Id]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181213105602_fkchangessss', N'2.1.4-rtm-31024');

GO

