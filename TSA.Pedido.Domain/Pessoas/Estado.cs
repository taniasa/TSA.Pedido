using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Core.Entities;

namespace TSA.Pedido.Domain.Pessoas
{
    public class Estado : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

    }
}
