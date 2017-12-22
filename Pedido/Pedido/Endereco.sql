CREATE TABLE [dbo].[Endereco]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [CEP] VARCHAR(10) NULL, 
    [MunicipioId] BIGINT NOT NULL, 
    [Bairro] VARCHAR(120) NULL, 
    [Logradouro] VARCHAR(120) NOT NULL, 
    [Numero] VARCHAR(15) NULL, 
    [Complemento] VARCHAR(120) NULL
)
