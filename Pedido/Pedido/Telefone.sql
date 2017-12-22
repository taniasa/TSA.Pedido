CREATE TABLE [dbo].[Telefone]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Tipo] INT NOT NULL, 
    [Numero] VARCHAR(50) NOT NULL, 
    [Whats] BIT NOT NULL, 
    [PessoaId] BIGINT NOT NULL, 
    CONSTRAINT [FK_Telefone_Pessoa] FOREIGN KEY ([PessoaId]) REFERENCES [Pessoa]([Id])
)
