using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Entities;

namespace TSA.GestaoPedido.Domain.Itens
{
    public class Item : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
