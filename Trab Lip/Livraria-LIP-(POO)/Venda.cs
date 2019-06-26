using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_LIP__POO_
{
    class Venda
    {
        private string nome_Pessoa;
        private string nome_Livro;
        private int qtd_Livros;
        private double valor_Total;

        public Venda(string nome_Pessoa, string nome_Livro, int qtd_Livros, double valorTotal)
        {
            this.nome_Pessoa = nome_Pessoa;
            this.nome_Livro = nome_Livro;
            this.qtd_Livros = qtd_Livros;
            this.valor_Total = valorTotal;
        }

        public Venda()
        {

        }
        public string nomePessoa
        {
            get
            {
                return this.nome_Pessoa;
            }
            set
            {
                this.nome_Pessoa = value;
            }
        }

        public string nomeLivro
        {
            get
            {
                return this.nome_Livro;
            }
            set
            {
                this.nome_Livro = value;
            }
        }

        public double valorTotal
        {
            get
            {
                return this.valor_Total;
            }
            set
            {
                this.valor_Total = value;
            }
        }

        public int qtdLivro
        {
            get
            {
                return this.qtd_Livros;
            }
            set
            {
                this.qtd_Livros = value;
            }
        }





    }
}
