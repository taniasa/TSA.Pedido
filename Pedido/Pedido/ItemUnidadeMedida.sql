CREATE TABLE [dbo].[ItemUnidadeMedida]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [ItemId] BIGINT NOT NULL, 
    [UnidadeMedidaId] BIGINT NOT NULL, 
    CONSTRAINT [FK_ItemUnidadeMedida_Item] FOREIGN KEY ([ItemId]) REFERENCES [Item]([Id]), 
    CONSTRAINT [FK_ItemUnidadeMedida_UnidadeMedida] FOREIGN KEY ([UnidadeMedidaId]) REFERENCES [UnidadeMedida]([Id])
)
