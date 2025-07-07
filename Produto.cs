public class Produto //Deus abencoe nosso estudo e nosso programa
{
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public int QuantidadeEstoque { get; set; }

    public Produto(int codigo, string nome, decimal preco, int quantidadeEstoque)
    {
        Codigo = codigo;
        Nome = nome;
        Preco = preco;
        QuantidadeEstoque = quantidadeEstoque;
    }
    public void Exibir()
    {
        Console.WriteLine($"Codigo:{Codigo},Nome:{Nome},Preço:{Preco},Quantidade:{QuantidadeEstoque}");
    }
    






}