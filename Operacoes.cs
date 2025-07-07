using System;
using System.Collections.Generic;
 public static class Operacoes
 {
   public static void CadastrarProduto()
{
    Console.WriteLine("===Cadastrando novo Produto===");
    Console.WriteLine("Codigo:");
    int codigo = int.Parse(Console.ReadLine());

    Console.WriteLine("Nome:");
    string nome = Console.ReadLine();

    Console.WriteLine("Preço:");
    decimal preco = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Quantidade:");   
    int quantidade = int.Parse(Console.ReadLine());

    Produto p1 = new Produto(codigo, nome, preco, quantidade);
    produtos.Add(p1); //Revisar//
}
     public static void ListarProduto()
    {
        Console.WriteLine("====Lista de Produtos====");
        foreach (Produto p in produtos)
        {
            p.Exibir();
        }
    }
    public static void EditarProduto()
    {
        Console.WriteLine("+++Editar Produto+++");
        Console.WriteLine("Digite o codigo a editar :");
        int codigo = int.Parse(Console.ReadLine());

        Produto produto = produtos.Find(p => p.Codigo == codigo);

        if (produto != null)
        {
            Console.WriteLine("Novo Nome:");
            produto.Nome = Console.ReadLine();

            Console.WriteLine("Novo Preço:");
            produto.Preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Nova Quantidade em Estoque:");
            produto.QuantidadeEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Produto Atualizdo com sucesso");
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
        }
    }
    public static void RemoverProduto()
    {
        Console.WriteLine("+++REMOVER PRODUTO+++");

        Console.WriteLine("Digite o codigo do produto a remover:");
        int codigo = int.Parse(Console.ReadLine());

        Produto produto = produtos.Find(p => p.Codigo == codigo);

        if (produto != null)
        {
            produtos.Remove(produto);
            Console.WriteLine("Produto removido com sucesso");
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
        }


    }
    public static void AtualizarEstoque()
{
    Console.WriteLine("+++Atualizar Estoque+++");

    Console.WriteLine("Digite o codigo do produto a ser atulizado");
    int codigo = int.Parse(Console.ReadLine());

    Produto produto = produtos.Find(p => p.Codigo == codigo);

    if (produto != null)
    {
        Console.WriteLine("Nova Quantidade para adicionar (ou negativo para remover):");
        int quantidade = int.Parse(Console.ReadLine());

        produto.QuantidadeEstoque += quantidade;
        Console.WriteLine($"Estoque atualizado com sucesso.Produto {produto.Nome} tem {produto.QuantidadeEstoque} unidades .");
    }
    else
    {
        Console.WriteLine("Produto não encontrado ");
    }
}

}
 
