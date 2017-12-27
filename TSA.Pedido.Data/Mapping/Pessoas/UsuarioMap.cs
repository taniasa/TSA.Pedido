using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Domain.Pessoas;

namespace TSA.Pedido.Data.Mapping.Pessoas
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("Usuario");
        }
    }
}
