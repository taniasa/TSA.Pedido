using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Core.Entities;

namespace TSA.Pedido.Domain.Itens
{
    public class UnidadeMedida : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
