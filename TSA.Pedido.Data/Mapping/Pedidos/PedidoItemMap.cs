using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Domain.Pedidos;

namespace TSA.Pedido.Data.Mapping.Pedidos
{
    public class PedidoItemMap : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("PedidoItem");
        }
    }
}
