using System;
using System.Globalization;

namespace Coordenadas_De_Um_Ponto
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] s = Console.ReadLine().Split(' ');
      double X, Y;
      
      X = double.Parse(s[0], CultureInfo.InvariantCulture);
      Y = double.Parse(s[1], CultureInfo.InvariantCulture);
      
      if ( X == 0.0 && Y == 0.0 ) { 
        Console.WriteLine("Origem"); 
      } else if ( X == 0.0 ) { 
        Console.WriteLine("Eixo Y"); 
      } else if ( Y == 0.0 ) { 
        Console.WriteLine("Eixo X"); 
      } else if ( X > 0.0 && Y > 0.0 ) { 
        Console.WriteLine("Q1"); 
      } else if ( X < 0.0 && Y > 0.0 ) { 
        Console.WriteLine("Q2"); 
      } else if ( X < 0.0 && Y < 0.0 ) { 
        Console.WriteLine("Q3"); 
      } else if ( X > 0.0 && Y < 0.0 ) { 
        Console.WriteLine("Q4"); 
      }
    }
  }
}