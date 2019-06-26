using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_LIP__POO_
{
    class Livro_Comedia:Livro
    {
        private bool _capa_brochura;
        //Construtor com os parametros
        public Livro_Comedia(string nome, double valor, int qtdEstoque, bool capa) : base(nome, valor, qtdEstoque)
        {
            this._capa_brochura = capa;
        }
        //Construtor Vazio
        public Livro_Comedia() : base()
        {

        }
        //Gets e Sets
        public bool capa_brochura
        {
            get
            {
                return this._capa_brochura;
            }
            set
            {
                this._capa_brochura = value;
            }
        }
    }
}
