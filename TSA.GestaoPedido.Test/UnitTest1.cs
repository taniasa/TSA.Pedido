using System;
using TSA.GestaoPedido.Data.Mapping;
using TSA.GestaoPedido.Domain.Itens;
using Xunit;

namespace TSA.GestaoPedido.Test
{
    public class UnitTest1
    {
        [Fact]
        public void InsertItem()
        {
            using (var con = new PedidoContext())
            {
                var item = new Item() { Nome = "Item 1", Descricao = "Descrição 1"};
                con.Set<Item>().Add(item);
                con.SaveChanges();
            }
        }
    }
}
