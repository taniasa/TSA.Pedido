using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Entities;

namespace TSA.GestaoPedido.Domain.Pessoas
{
    public enum TipoPessoa
    {
        Fisica,
        Juridica
    }
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public DateTime DataNascimentoConstituicao { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public string Documento { get; set; }
        public long EnderecoId { get; set; }
        public ICollection<Telefone> Telefones { get; set; }
        public Pessoa()
        {
            Telefones = new List<Telefone>();
        }
    }
}
