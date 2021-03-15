using System;

class HelloWorld
{
  static void Main()
  {
      string resposta;
      string resposta2;
      double total_points;
      double your_points;
      double rest_points;
      double total_hours;
      
      Console.WriteLine("         _|_|_|                _|      _|              _|_|_|                _|_|_|_|_|                _|_|_|  ");
      Console.WriteLine("         _|    _|              _|      _|              _|    _|                  _|                  _|        ");
      Console.WriteLine("         _|_|_|                _|      _|              _|_|_|                    _|                  _|        ");
      Console.WriteLine("         _|    _|                _|  _|                _|    _|                  _|                  _|        ");
      Console.WriteLine("         _|_|_|        _|          _|          _|      _|    _|      _|          _|          _|        _|_|_|  ");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Começar - 1");
      Console.WriteLine("Sair - 2");
      Console.WriteLine("");
      resposta = Console.ReadLine();
      Console.Clear();
      if (resposta == "1")
      {
        Console.WriteLine("Quantos pontos precisam para você pegar todos os prêmios?");
        total_points = Convert.ToDouble(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Quantos pontos voce ja tem?");
        your_points = Convert.ToDouble(Console.ReadLine());
        rest_points = total_points - your_points;
        total_hours = rest_points / 60;
        Console.Clear();
        Console.WriteLine("Ok eu analisei tudo e");
        Console.WriteLine("Ainda faltam " + rest_points + " pontos");
        Console.WriteLine("Ainda faltam " + total_hours + " horas");
        Console.WriteLine("voltar para o menu - 1");
        Console.WriteLine("Sair - 2");
        resposta2 = Console.ReadLine();
        Console.Clear();
        if (resposta2 == "1")
        {
          Main();
        }
      }
      else if (resposta == "2")
      {
        Console.Clear();
      }
      else
      {
        Main();    
      }
  }
}
