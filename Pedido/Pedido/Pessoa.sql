CREATE TABLE [dbo].[Pessoa]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(120) NOT NULL, 
    [DataNascimentoConstituicao] DATE NOT NULL, 
    [TipoPessoa] INT NOT NULL, 
    [CPFCNPJ] VARCHAR(18) NOT NULL, 
    [RG] VARCHAR(50) NULL, 
    [EnderecoId] BIGINT NULL, 
    [Sexo] INT NULL, 
    CONSTRAINT [FK_Pessoa_Endereco] FOREIGN KEY ([EnderecoId]) REFERENCES [Endereco]([Id])
)
