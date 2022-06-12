namespace GeraEstoque;
using System;
public static class CadastrarProduto
{

  public static void Start()
  {

    Console.Clear();
    Console.WriteLine("Modo Cadastro de Produto");
    Console.WriteLine("=========================");
    Console.WriteLine("Digite o nome do produto:");
    string nomeProduto = Console.ReadLine();
    Console.WriteLine("Digite a quantidade em estoque:");
    int qtdEstoque = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de Compra do produto:");
    float valorCompra = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de venda do produto:");
    float valorVenda = float.Parse(Console.ReadLine());
    Guid id = Guid.NewGuid();
    Console.Clear();
    Console.WriteLine("Produto cadastrado com sucesso!");
    printInfProduto(id, nomeProduto, qtdEstoque, valorCompra, valorVenda);
    Console.WriteLine("Pressione qualquer tecla para retornar ao menu.");
    Console.ReadLine();
    Menu.Show();

  }

  public static void printInfProduto(Guid id, string nome, int qtd, float compra, float venda)
  {
    Console.WriteLine("ID:" + id);
    Console.WriteLine("Nome do Produto:" + nome);
    Console.WriteLine("Quantidade em Estoque:" + qtd);
    Console.WriteLine("Valor de Compra: R$" + compra);
    Console.WriteLine("Valor de Venda: R$" + venda);
  }

}