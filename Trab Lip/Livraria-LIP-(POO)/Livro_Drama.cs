using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_LIP__POO_
{
    class Livro_Drama: Livro
    {
        private bool _capa_Dura;
        
        //Construtor com os paramentros
        public Livro_Drama(string nome, double valor,int qtdEstoque,bool capa) : base(nome, valor, qtdEstoque)
        {
            this._capa_Dura = capa;
        }

        //Construtor Vazio
        
        //Get's e Set's
        public bool capa_brochura
        {
            get
            {
                return this._capa_Dura;
            }
            set
            {
                this._capa_Dura = value;
            }
        }
    }
}
