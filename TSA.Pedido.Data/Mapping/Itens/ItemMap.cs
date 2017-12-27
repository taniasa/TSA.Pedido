using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Domain.Itens;

namespace TSA.Pedido.Data.Mapping.Itens
{
    public class ItemMap : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("Item");
        }
    }
}
