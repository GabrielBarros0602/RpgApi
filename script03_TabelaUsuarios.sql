BEGIN TRANSACTION;
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_ARMAS]') AND [c].[name] = N'Classe');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [TB_ARMAS] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [TB_ARMAS] DROP COLUMN [Classe];
GO

ALTER TABLE [TB_PERSONAGENS] ADD [FotoPersonagem] varbinary(max) NULL;
GO

ALTER TABLE [TB_PERSONAGENS] ADD [UsuarioId] int NULL;
GO

CREATE TABLE [TB_USUARIOS] (
    [Id] int NOT NULL IDENTITY,
    [Username] varchar(200) NOT NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitude] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] varchar(200) NOT NULL DEFAULT 'Jogador',
    [Email] varchar(200) NOT NULL,
    CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY ([Id])
);
GO

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 2;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 3;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 4;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 5;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 6;
SELECT @@ROWCOUNT;

GO

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 7;
SELECT @@ROWCOUNT;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] ON;
INSERT INTO [TB_USUARIOS] ([Id], [DataAcesso], [Email], [Foto], [Latitude], [Longitude], [PasswordHash], [PasswordSalt], [Perfil], [Username])
VALUES (1, NULL, 'seuEmail@gmail.com', NULL, -23.520024100000001E0, -46.596497999999997E0, 0x0A1B19D7E11256A6E6D81CE5D9B231A637D9AE748FB7E0539D26CB011CCFE63939AAA551AE4E440083A7F927F858FA9ED8A1A7C9E4BB2C4802D34F25342CB5B9, 0x4CCFE3ADE9148A3C2B4CE2B231817F2C7FC208E65DCF1ECE7FA255FE56B8008034E00BAE6CE5E186069E4DA1CE36260BB86B61385843DC9AB7A33BD7CFD9F7ECF2B2FDA6AD4B45D582FE3F84B16C73C9BB3F179EEB0A03C48086E0C991EA2A38B86862353A763EB23B220C69D0F54B0A62ECE281C1A560474C16279F941568F6, 'Admin', 'UsuarioAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIOS]'))
    SET IDENTITY_INSERT [TB_USUARIOS] OFF;
GO

CREATE INDEX [IX_TB_PERSONAGENS_UsuarioId] ON [TB_PERSONAGENS] ([UsuarioId]);
GO

ALTER TABLE [TB_PERSONAGENS] ADD CONSTRAINT [FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_USUARIOS] ([Id]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240417003400_MigracaoUsuario', N'8.0.3');
GO

COMMIT;
GO

