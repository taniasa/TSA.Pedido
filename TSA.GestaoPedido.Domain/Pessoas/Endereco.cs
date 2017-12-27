using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Entities;

namespace TSA.GestaoPedido.Domain.Pessoas
{
    public class Endereco : Entity
    {
        protected Endereco() { }

        public Endereco(string nome, string cep, string numero, int municipioId, string bairro, string complemento)
        {
            Logradouro = nome;
            Numero = numero;
            MunicipioId = municipioId;
            Bairro = bairro;
            Complemento = complemento;
            CEP = cep;
        }

        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Numero { get; private set; }
        public int MunicipioId { get; private set; }
        public Municipio Municipio { get; set; }
        public string Bairro { get; private set; }
        public string Complemento { get; set; }
    }
}
