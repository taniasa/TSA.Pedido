using System;
using System.Collections.Generic;
using System.Text;
using TSA.GestaoPedido.Core.Entities;

namespace TSA.GestaoPedido.Domain.Pedidos
{
    public class Pedido : Entity
    {
        public Pedido(int numero, DateTime dataLancamento, long usuarioIdLancamento, string descricao, int situacao, long usuarioIdCancelamento, long usuarioIdUltimaAlteracao, int dataFechamento, decimal valorTotalPedido)
        {
            Numero = numero;
            DataLancamento = dataLancamento;
            UsuarioIdLancamento = usuarioIdLancamento;
            Descricao = descricao;
            Situacao = situacao;
            UsuarioIdCancelamento = usuarioIdCancelamento;
            UsuarioIdUltimaAlteracao = usuarioIdUltimaAlteracao;
            DataFechamento = dataFechamento;
            ValorTotalPedido = valorTotalPedido;
        }

        public int Numero { get; private set; }
        public DateTime DataLancamento { get; private set; }
        public long UsuarioIdLancamento { get; private set; }
        public string Descricao { get; private set; }
        public int Situacao { get; private set; }
        public long UsuarioIdCancelamento { get; private set; }
        public long UsuarioIdUltimaAlteracao { get; private set; }
        public int DataFechamento { get; private set; }
        public decimal ValorTotalPedido { get; private set; }
    }
}
