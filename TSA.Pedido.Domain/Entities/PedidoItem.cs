using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Core.Entities;

namespace TSA.Pedido.Domain.Entities
{
    public class PedidoItem : Entity
    {
        public PedidoItem(int pedidoId, int itemId, long unidadeMedidaId, decimal valor, int quantidade, string observacao)
        {
            PedidoId = pedidoId;
            ItemId = itemId;
            UnidadeMedidaId = unidadeMedidaId;
            Valor = valor;
            Quantidade = quantidade;
            Observacao = observacao;
        }

        public int PedidoId { get; private set; }
        public int ItemId { get; private set; }
        public long UnidadeMedidaId { get; set; }
        public decimal Valor { get; private set; }
        public int Quantidade { get; private set; }
        public string Observacao { get; private set; }
    }
}
