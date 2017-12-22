using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Core.Entities;

namespace TSA.Pedido.Domain.Entities
{
    public class Municipio : Entity
    {
        public uint Codigo { get; set; }
        public string Nome { get; set; }
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
