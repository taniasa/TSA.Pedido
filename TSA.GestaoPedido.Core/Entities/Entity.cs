using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Interfaces;

namespace TSA.GestaoPedido.Core.Entities
{
    public class Entity : IEntityId
    {
        public long Id { get; set; }
    }
}
