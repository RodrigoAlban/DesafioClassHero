using System;

class ProdutoEstoque
{
    static void Main()
    {
        string nomeProduto = "Notebook Asus TUF A16 Gaming";
        int quantidade = 2;
        double precoUnitario = 4600.00;
        bool ativoParaVenda = true;

        Console.WriteLine("Nome do produto: " + nomeProduto);
        Console.WriteLine("Quantidade em estoque: " + quantidade);
        Console.WriteLine("Preço unitário: R$" + precoUnitario);
        if (ativoParaVenda)
            Console.WriteLine("Ativo para venda: Sim");
        else
            Console.WriteLine("Ativo para venda: Não");
    }
};