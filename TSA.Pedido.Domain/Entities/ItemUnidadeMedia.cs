using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Core.Entities;

namespace TSA.Pedido.Domain.Entities
{
    public class ItemUnidadeMedia : Entity
    {
        public int ItemId { get; set; }
        public int UnidadeMedidaId { get; set; }
    }
}
