CREATE TABLE [Connections] (
    [ConnectionID] nvarchar(450) NOT NULL,
    [UserAgent] nvarchar(max) NULL,
    [Connected] bit NOT NULL,
    [ApplicationUserId] nvarchar(450) NULL,
    CONSTRAINT [PK_Connections] PRIMARY KEY ([ConnectionID]),
    CONSTRAINT [FK_Connections_tblUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [dbo].[tblUsers] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Connections_ApplicationUserId] ON [Connections] ([ApplicationUserId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190114190727_kjf', N'2.1.4-rtm-31024');

GO

