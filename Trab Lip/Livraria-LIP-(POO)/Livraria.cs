using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_LIP__POO_
{
    class Livraria
    {
        //Guardar os livros aqui
        public List<Livro> livros = new List<Livro>();
        //guardar as vendas aqui
        public List<Venda> vendas = new List<Venda>();

        //Alugar Livro.
        public void alugar_Livro()
        {
            //limpar o console
            Console.Clear();
            //mostra todos os livros antes
            mostrar_Livros();
            //escrever no console
            Console.WriteLine("Digite o nome do Livro para alugar:");
            //receber a entrada do usuario
            string nome = Console.ReadLine();
            Console.Clear();
            string opcao1;

            Livro l = buscarLivroTitulo(nome);
            if (l == null)
            {
                Console.WriteLine("Erro | Esse livro não está cadastrado!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                //espera que o usuario digite uma tecla para continuar
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Voce Deseja Alugar o Livro: "+nome+"\nPreco: "+l.valor+" Quantidade em estoque: "+l.qtdEstoqueTitulo+"\n 1) SIM     2) NÃO");
                opcao1 = Console.ReadLine();
                if (opcao1.Equals("1"))
                {
                    Venda venda = new Venda();
                    Console.WriteLine("Digite seu nome: ");
                    string nomePessoa = Console.ReadLine();
                    //saber a quantidade de livros para comprar
                    Console.WriteLine("Digite a quantidade de livros que deseja comprar: ");
                    string qtd1 = Console.ReadLine();
                    int qtd = Convert.ToInt32(qtd1); //converter string para inteiro;
                    //comparando se tem livros suficientes
                    while (qtd > l.qtdEstoqueTitulo)
                    {
                        Console.WriteLine("Erro | Quantidade de livros superior a quantidade em estoque");
                        Console.WriteLine("Dica: Escolha uma quantidade menor que " + l.qtdEstoqueTitulo);
                        qtd1 = Console.ReadLine();
                        qtd = Convert.ToInt32(qtd1);
                        
                    }
                    //guardar as vendas
                    venda.nomePessoa = nomePessoa;
                    venda.nomeLivro = nome;
                    venda.qtdLivro = qtd;
                    double valortotal = l.valor * qtd;
                    Console.WriteLine("Preco total é: " + valortotal);
                    venda.valorTotal = valortotal;
                    vendas.Add(venda);

                    l.qtdEstoqueTitulo = l.qtdEstoqueTitulo - qtd;
                    
                   
                    Console.WriteLine("Sucesso | Livro alugado com sucesso");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                    
            }
            
        }//fim

        //consultar livro
        public void consultarqtdLivros()
        {
            Console.WriteLine("Digite o titulo do filme: ");
            string nome = Console.ReadLine();
            qtdLivroTitulo(nome);
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }


        //retornar a qtd de livros daquele TITULO
        public int qtdLivroTitulo(string nome)
        {
            Livro l = buscarLivroTitulo(nome);
            if (l != null) {
                Console.WriteLine("Existem " + l.qtdEstoqueTitulo + " exemplares do livro: " + l.nome);
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return l.qtdEstoqueTitulo;
            }
            Console.WriteLine("Erro | Esse livro ainda nao esta cadastrado!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            return l.qtdEstoqueTitulo;
        }
        //adicionar livro
        public bool addLivro()
        {
            Console.Clear();
            Console.WriteLine("              Qual livro voce quer adicionar? \n");
            //menu com tipos de livros atualmente
            tipos_Livros();
            string op = Console.ReadLine();
            if (op.Equals("4"))
            {
                return false;
            }
            Console.WriteLine("Digite o nome do livro: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do livro: ");
            string valor1 = Console.ReadLine();
            double valor = Convert.ToDouble(valor1);
            Console.WriteLine("Digite a quantidade de livros: ");
            string qtd = Console.ReadLine();
            int qtdLivros = Convert.ToInt32(qtd);
            bool capa;
            if (op.Equals("1"))
            {
                Console.WriteLine("Possui capa brochura?");
                Console.WriteLine("1) SIM       2) NÃO");
                op = Console.ReadLine();
                if (op.Equals("1"))
                {
                    capa = true;
                }
                else
                {
                    capa = false;
                }

                //criando o livro
                Livro livro = new Livro_Comedia(nome,valor,qtdLivros,capa);
                livros.Add(livro);
                Console.WriteLine("Sucesso | Livro Adicionado com Sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            }
            else if (op.Equals("2"))
            {
                Console.WriteLine("Possui capa dura?");
                Console.WriteLine("1) SIM       2) NÃO");
                op = Console.ReadLine();
                if (op.Equals("1"))
                {
                    capa = true;
                }
                else
                {
                    capa = false;
                }
                //criando o livro
                Livro livro = new Livro_Comedia(nome,valor,qtdLivros,capa);
                livros.Add(livro);
                Console.WriteLine("Sucesso | Livro Adicionado com Sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            } 
            else if (op.Equals("3"))
            {
                Console.WriteLine("Possui ilustruções ?");
                Console.WriteLine("1) SIM       2) NÃO");
                op = Console.ReadLine();
                bool ilustracoes = false;
                if (op.Equals("1"))
                {
                    ilustracoes = true;
                }
                else
                {
                    ilustracoes = false;
                }
                //criando o livro
                Livro livro = new Livro_Aventura(nome,valor,qtdLivros,ilustracoes);
                livros.Add(livro);
                Console.WriteLine("Sucesso | Livro Adicionado com Sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                return true;
            }else if (op.Equals("4"))
            {
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Erro | Opcao nao encontrada!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }


            return false;
        }



      
        //buscar livro por nome
        public Livro buscarLivroTitulo(string nome)
        {
            foreach (Livro livro in livros)
            {
                if(livro != null) { 
                    if (livro.nome.Equals(nome))
                    {
                        return livro;
                    }
                }
            }
            return null;
        }






        //Menuzim do aluguel
        public void tipos_Livros()
        {

            Console.WriteLine("###############################################################");
            Console.WriteLine("##############  1) Livro de Comedia   #########################");
            Console.WriteLine("###############################################################");
            Console.WriteLine("##############  2) Livro de Drama     #########################");
            Console.WriteLine("###############################################################");
            Console.WriteLine("##############  3) Livro de Aventura  #########################");
            Console.WriteLine("###############################################################");
            Console.WriteLine("##############  4) Voltar             #########################");
            Console.WriteLine("###############################################################");

        }

        //mostrar livros
        public void mostrar_Livros()
        {
            foreach(Livro livro in livros)
            {
                Console.WriteLine("Codigo: " + livro.codigo);
                Console.WriteLine("Nome: "+livro.nome+"\nValor: "+livro.valor);
                Console.WriteLine("Quantidade de livros: "+livro.qtdEstoqueTitulo+"\n");
            }
        }

        //mostrar todas as vendas
        public void mostrarVendas()
        {
            if(vendas.Count <= 0)
            {
                Console.WriteLine("Ainda não foram alugados livros");
            }
            foreach(Venda venda in vendas){
                Console.WriteLine("\nNome da pessoa: " + venda.nomePessoa);
                Console.WriteLine("Nome do livro: " + venda.nomeLivro);
                Console.WriteLine("Quantidade de livros comprados: " + venda.qtdLivro);
                Console.WriteLine("Valor total da venda: " + venda.valorTotal);
            }
            //soma de todas as vendas
            double somaTotal = 0;
            foreach(Venda venda in vendas)
            {
                somaTotal = venda.valorTotal + somaTotal;
            }
            Console.WriteLine("\n###################################################");
            Console.WriteLine("##     Soma total de todas as vendas: R$ " + somaTotal+"   ####");
            Console.WriteLine("###################################################");

        }


















    }
}

