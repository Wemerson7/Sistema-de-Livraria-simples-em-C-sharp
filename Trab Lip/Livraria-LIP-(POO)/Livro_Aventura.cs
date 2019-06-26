using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_LIP__POO_
{
    class Livro_Aventura:Livro
    {
        private bool _ilustracoes;

        //construtor da classe
        public Livro_Aventura(string nome, double valor, int qtdEstoque, bool ilustracoes) : base(nome, valor, qtdEstoque)
        {
            this._ilustracoes = ilustracoes;
        }
        //construtor vazio;
        public Livro_Aventura() : base()
        {
        }
        //get e set
        public bool ilustracoes
        {
            get
            {
                return this._ilustracoes;
            }
            set
            {
                this._ilustracoes = value;
            }
        }
    }
}
