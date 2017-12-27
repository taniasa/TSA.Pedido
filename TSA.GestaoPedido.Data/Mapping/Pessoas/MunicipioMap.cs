using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Domain.Pessoas;

namespace TSA.GestaoPedido.Data.Mapping.Pessoas
{
    public class MunicipioMap : IEntityTypeConfiguration<Municipio>
    {
        public void Configure(EntityTypeBuilder<Municipio> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable("Municipio");
        }
    }
}
