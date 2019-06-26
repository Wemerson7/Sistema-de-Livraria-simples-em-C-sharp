using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_LIP__POO_
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando uns livros simulando o banco de dados
            Livraria livraria = new Livraria();
            Livro l = new Livro_Comedia("50 tons",20,30,true);
            Livro l1 = new Livro_Drama("HIMYM", 20,20, false);
            Livro l2 = new Livro_Aventura("Fogo e Gelo", 30,15,true);
            Livro l3 = new Livro_Comedia("Mogliloide", 10,55,true);
            Livro l4 = new Livro_Comedia("Ultima temporada de GOT", 0.99, 100, true);
            Livro l5 = new Livro_Comedia("HIMYM", 15,20,false);
            Livro l6 = new Livro_Comedia("Oh cabrunco", 20,15,true);
            Livro livro = new Livro_Aventura("Hari Porta",20,30,true);
            //adicionando
            livraria.livros.Add(l1);
            livraria.livros.Add(livro);
            livraria.livros.Add(l);
            livraria.livros.Add(l1);
            livraria.livros.Add(l2);
            livraria.livros.Add(l3);
            livraria.livros.Add(l4);
            livraria.livros.Add(l5);
            livraria.livros.Add(l6);
            //guardando umas vendas...
            Venda venda = new Venda();
            venda.nomePessoa = "Jucão";
            venda.nomeLivro = "A volta dos que não foram";
            venda.qtdLivro = 15;
            venda.valorTotal = 30 * 15 ;
            //segunda venda...
            Venda v = new Venda();
            v.nomePessoa = "Lucas";
            v.nomeLivro = "Poeira em alto mar";
            v.qtdLivro = 50;
            v.valorTotal = 15 * 15;
            //adicionando
            livraria.vendas.Add(venda);
            livraria.vendas.Add(v);
            //menu
            string op ="";
            do {
                Console.Clear();
                Console.WriteLine("###############################################################");
                Console.WriteLine("##                 Livraria do Yoda             ###############");
                Console.WriteLine("###############################################################");
                Console.WriteLine("###############################################################");
                Console.WriteLine("## 1) Adicionar Livro   ####   3) Consultar Livro  ############");
                Console.WriteLine("###############################################################");
                Console.WriteLine("###############################################################");
                Console.WriteLine("## 2) Vender Livro      ####    4) Mostrar Todos os livros  ###");
                Console.WriteLine("###############################################################");
                Console.WriteLine("## 6) Sair              ####     5) Mostrar Livros Alugados ###");
                Console.WriteLine("###############################################################");          
                op = Console.ReadLine();
                if (op.Equals("1"))
                {
                    livraria.addLivro();
                }
                else if (op.Equals("2")){ 
                   livraria.alugar_Livro();
                }
                else if (op.Equals("3"))
                {
                    Console.WriteLine("Digite o nome do livro: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine(livraria.qtdLivroTitulo(nome));
                }
                else if (op.Equals("4"))
                {
                    livraria.mostrar_Livros();
                    Console.WriteLine("Pressione qualquer tecla para voltar...");
                    Console.ReadKey();
                }
                else if (op.Equals("5"))
                {
                    livraria.mostrarVendas();
                    Console.WriteLine("Pressione qualquer tecla para voltar...");
                    Console.ReadKey();
                }

                else if (op.Equals("6"))
                {
                    Console.WriteLine("Até logo <3 ");
                }
                else
                {
                    Console.WriteLine("Erro | Opcao Nao Encontrada");
                    Console.WriteLine("Pressione qualquer tecla para voltar!");
                    Console.ReadKey();
                }
            }while (!op.Equals("6"));
            Console.WriteLine("Pressione qualquer tecla para sair!");
            Console.ReadKey();
        }
    }
}
