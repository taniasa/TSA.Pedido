using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Domain.Pessoas;

namespace TSA.Pedido.Data.Mapping.Pessoas
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("Endereco");
        }
    }
}
