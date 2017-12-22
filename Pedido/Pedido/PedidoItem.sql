CREATE TABLE [dbo].[PedidoItem]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemId] BIGINT NOT NULL, 
    [UnidadeMedidaId] BIGINT NOT NULL, 
    [Valor] DECIMAL(18, 2) NOT NULL, 
    [Quantidade] INT NOT NULL, 
    [Observacao] VARCHAR(120) NULL, 
    CONSTRAINT [FK_PedidoItem_Item] FOREIGN KEY ([ItemId]) REFERENCES [Item]([Id]), 
    CONSTRAINT [FK_PedidoItem_UnidadeMedida] FOREIGN KEY ([UnidadeMedidaId]) REFERENCES [UnidadeMedida]([Id])
)
