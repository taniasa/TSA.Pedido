using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Data.Mapping.Itens;
using TSA.Pedido.Data.Mapping.Pedidos;
using TSA.Pedido.Data.Mapping.Pessoas;

namespace TSA.Pedido.Data.Mapping
{
     public class PedidoContext : DbContext
    {
        public PedidoContext()
        {
            //this.Configuration.AutoDetectChangesEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TANIA-DELL;Database=Pedido;user id=sa; password=SYSTEM_AGILI;", options => options.MaxBatchSize(1000));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ItemMap());
            modelBuilder.ApplyConfiguration(new ItemUnidadeMediaMap());
            modelBuilder.ApplyConfiguration(new UnidadeMedidaMap());

            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new PedidoItemMap());

            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new EstadoMap());
            modelBuilder.ApplyConfiguration(new MunicipioMap());
            modelBuilder.ApplyConfiguration(new PaisMap());
            modelBuilder.ApplyConfiguration(new PessoaFisicaMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new PessoaJuridicaMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
