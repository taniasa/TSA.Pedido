CREATE TABLE [dbo].[Pedido]
(
	[Id] BIGINT NOT NULL PRIMARY KEY, 
    [Numero] INT NOT NULL IDENTITY, 
    [DataLancamento] DATETIME NOT NULL, 
    [UsuarioIdLancamento] BIGINT NOT NULL, 
    [Descricao] VARCHAR(300) NULL, 
    [Situacao] INT NOT NULL, 
    [UsuarioIdCancelamento] BIGINT NULL, 
    [UsuarioIdUltimaAlteracao] BIGINT NULL, 
    [DataFechamento] DATETIME NULL, 
    [ValorTotalPedido] DECIMAL(18, 2) NULL
)
