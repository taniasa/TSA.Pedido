using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Entities;

namespace TSA.GestaoPedido.Domain.Itens
{
    public class ItemUnidadeMedia : Entity
    {
        public int ItemId { get; set; }
        public int UnidadeMedidaId { get; set; }
    }
}
