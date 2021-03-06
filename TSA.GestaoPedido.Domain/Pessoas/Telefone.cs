﻿using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Entities;

namespace TSA.GestaoPedido.Domain.Pessoas
{
    public enum TipoTelefone
    {
        Celular,
        Residencial,
        Trabalho
    }
    public class Telefone : Entity
    {
        public TipoTelefone Tipo { get; set; }
        public string Numero { get; set; }
        public bool Whats { get; set; }
        public long PessoaId { get; set; }
    }
}
