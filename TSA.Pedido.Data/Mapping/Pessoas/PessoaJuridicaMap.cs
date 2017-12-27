using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Domain.Pessoas;

namespace TSA.Pedido.Data.Mapping.Pessoas
{
     public class PessoaJuridicaMap : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("PessoaJuridica");
        }
    }
}
