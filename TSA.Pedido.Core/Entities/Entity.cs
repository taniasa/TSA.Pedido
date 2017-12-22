using System;
using System.Collections.Generic;
using System.Text;
using TSA.Pedido.Core.Interfaces;

namespace TSA.Pedido.Core.Entities
{
    public class Entity : IEntityId
    {
        public long Id { get; set; }
    }
}
