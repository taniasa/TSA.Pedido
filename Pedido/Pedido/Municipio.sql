CREATE TABLE [dbo].[Municipio]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(120) NOT NULL, 
    [EstadoId] BIGINT NOT NULL, 
    [Codigo] INT NOT NULL, 
    CONSTRAINT [FK_Municipio_Estado] FOREIGN KEY ([EstadoId]) REFERENCES [Estado]([Id])
)
