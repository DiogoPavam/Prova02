using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova02
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public string Fornecedor { get; set; }

        public Produto(int id, string nome, string descricao, int quantidade, string categoria, string fornecedor)
        {
            ID = id;
            Nome = nome;
            Descricao = descricao;
            Quantidade = quantidade;
            Categoria = categoria;
            Fornecedor = fornecedor;
        }
    }

    }
