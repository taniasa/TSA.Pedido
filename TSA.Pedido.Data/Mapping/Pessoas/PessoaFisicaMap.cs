using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Domain.Pessoas;

namespace TSA.Pedido.Data.Mapping.Pessoas
{
     public class PessoaFisicaMap : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("PessoaFisica");
        }
    }
}
