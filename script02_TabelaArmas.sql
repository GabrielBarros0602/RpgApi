BEGIN TRANSACTION;
GO

CREATE TABLE [TB_ARMAS] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Dano] int NOT NULL,
    [Classe] int NOT NULL,
    CONSTRAINT [PK_TB_ARMAS] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] ON;
INSERT INTO [TB_ARMAS] ([Id], [Classe], [Dano], [Nome])
VALUES (1, 0, 50, 'Espada'),
(2, 0, 25, 'Adaga'),
(3, 0, 5, 'Escudo'),
(4, 0, 35, 'Clava'),
(5, 0, 1000, 'Estrelança da Aurora Dracônica!!!!!!'),
(6, 0, 60, 'Machado'),
(7, 0, 30, 'Arco');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Classe', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240410003857_MigracaoArma', N'8.0.3');
GO

COMMIT;
GO

