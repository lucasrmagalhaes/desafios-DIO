using System;
using System.Collections.Generic;
using System.Linq;

class ComprasNoSupermercado
{
  public static void Main(string[] args)
  {
    int numeroDeTestes = int.Parse(Console.ReadLine());
  
    for (int i = 0; i < numeroDeTestes; i++) {
      List<string> listDeCompras = new List<String>(Console.ReadLine().Split(' '));
      List<string> listaSemDuplicados = listDeCompras.Distinct().ToList();

      listaSemDuplicados.Sort();
  
      foreach (string item in listaSemDuplicados) {
        Console.Write($"{item} ");
      }
      
      Console.WriteLine(" ");
    }
  }
}