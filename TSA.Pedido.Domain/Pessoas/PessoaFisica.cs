using System;
using System.Collections.Generic;
using System.Text;

namespace TSA.Pedido.Domain.Pessoas
{
    public enum Sexo
    {
        Nenhum,
        Feminino,
        Masculino
    }

    public class PessoaFisica : Pessoa
    {
        public string RG { get; set; }
        public Sexo Sexo { get; set; }
    }
}
