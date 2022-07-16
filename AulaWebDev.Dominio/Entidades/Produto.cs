using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaWebDev.Dominio.Entidades
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public int Codigo { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeEstoque { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public Produto(Guid id, string descricao, int codigo, decimal valor, int quantidadeEstoque)
        {
            Id = id;
            Descricao = descricao;
            Codigo = codigo;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public Produto(string descricao, int codigo, decimal valor, int quantidadeEstoque)
        {
            Descricao = descricao;
            Codigo = codigo;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }
}
