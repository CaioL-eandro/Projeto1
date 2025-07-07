using System;
using System.Collections.Generic;

namespace ProjetoFinal2;

 class programa
{
    static List<Produto> produtos = new List<Produto>();// revisar//
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("+++GERENCIADOR DE PRODUTOS+++");
            Console.WriteLine("1) cadastrar produto");
            Console.WriteLine("2) Listar produtos ");
            Console.WriteLine("3) Sair");
            Console.WriteLine("4)Editar Produto");
            Console.WriteLine("5)Remover  produto")
            Console.WriteLine("6)Atualizar Estoque")
            Console.WriteLine("Escolha uma opção:");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": CadastrarProduto(); break;
                case "2": ListarProduto(); break;
                case "3": continuar = false; Console.WriteLine("Encerraddo ..."); break;
                case "4": EditarProduto(); break;
                case "5": RemoverProduto(); break;
                case "6": AtualizarEstoque(); break;
                default:
                    Console.WriteLine("Opção invalida,tente novamente.");
                    break;
            }
        }
    }
}