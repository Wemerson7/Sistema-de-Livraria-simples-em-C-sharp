using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_LIP__POO_
{
    abstract class Livro
    {
        protected string _nome;
        protected double _valor;
        private static int incremento = 0;
        protected int _codigo;
        protected int _qtdEstoqueTitulo;

        //construtor com auto incremento para o codigo do livro
        public Livro(string nome, double valor, int qtdEstoque)
        {
            this._qtdEstoqueTitulo = qtdEstoque;
            this._codigo = incremento++;
            this._nome = nome;
            this._valor = valor;
        }
        //construtor vazio
        public Livro()
        {

        }

        //gets e sets
        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }
        public double valor
        {
            get
            {
                return this._valor;
            }

            set
            {
                this._valor = value;
            }
        }
        public int codigo
        {
            get
            {
                return this._codigo;
            }
        }
        public int qtdEstoqueTitulo
        {
            get
            {
                return _qtdEstoqueTitulo;
            }
            set
            {
                this._qtdEstoqueTitulo = value;
            }
        }

    }
}
