using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Domain.Itens;

namespace TSA.Pedido.Data.Mapping.Itens
{
    public class ItemUnidadeMediaMap : IEntityTypeConfiguration<ItemUnidadeMedia>
    {
        public void Configure(EntityTypeBuilder<ItemUnidadeMedia> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("ItemUnidadeMedia");
        }
    }
}
