namespace GeraEstoque;

public static class Menu

{
  const short col = 35;
  const short row = 12;
  public static void Show()
  {
    Console.Clear();
    DrawCanvas();
    ShowOptions();
    var option = short.Parse(Console.ReadLine());
    switch (option)
    {
      case 1: break;
      case 2: break;
      case 0:
        {
          Console.Clear();
          Environment.Exit(0);
          break;
        }

      default: Show(); break;
    }
    Console.ReadLine();
  }
  static void ShowOptions()
  {
    Console.SetCursorPosition(3, 2);
    Console.WriteLine("Seja bem-vindo ao GeraEstoque 1.0");
    Console.SetCursorPosition(2, 3);
    Console.WriteLine("==================================");
    Console.SetCursorPosition(2, 5);
    Console.WriteLine("1 - Cadastrar produto");
    Console.SetCursorPosition(2, 6);
    Console.WriteLine("2 - Consultar produto");
    Console.SetCursorPosition(2, 7);
    Console.WriteLine("3 - Modificar produto");
    Console.SetCursorPosition(2, 8);
    Console.WriteLine("4 - Excluir produto");
    Console.SetCursorPosition(2, 9);
    Console.WriteLine("0 - Sair");
    Console.SetCursorPosition(2, 11);
    Console.Write("Digite a Opção: ");



  }
  static void DrawCanvas()
  {
    Console.ForegroundColor = ConsoleColor.DarkGreen;

    Printhline();
    for (int i = 0; i < row; i++)
    {
      Console.Write("|");

      for (int line = 0; line <= col; line++)
        Console.Write(" ");

      Console.Write("|");
      Console.Write(Environment.NewLine);
    }
    Printhline();
  }
  static void Printhline()
  {
    System.Console.Write("+");
    for (int i = 0; i <= col; i++)
    {
      System.Console.Write("-", Console.ForegroundColor);
    }
    System.Console.Write("+");
    Console.Write(Environment.NewLine);

  }


}