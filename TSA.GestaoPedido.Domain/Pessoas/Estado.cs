using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Entities;

namespace TSA.GestaoPedido.Domain.Pessoas
{
    public class Estado : Entity
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }

    }
}
