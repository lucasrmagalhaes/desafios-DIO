/**
 * Desafio 2/3 - Álbum da Copa
 *      Rubens quer calcular e mostrar a quantidade de litros de combustível gastos 
 * em uma viagem de carro, sendo que seu carro faz 12 KM/L. Como ele não sabe fazer 
 * um programa que o auxilie nessa missão, ele te pede ajuda. Para efetuar o cálculo, 
 * deve-se fornecer o tempo gasto em horas na viagem e a velocidade média durante a 
 * mesma em km/h. Assim, você conseguirá passar para Rubens qual a distância percorrida 
 * e, em seguida, calcular quantos litros serão necessários para a viagem que ele quer 
 * fazer. Mostre o valor com 3 casas decimais após o ponto.
 *
 * Entrada
 *      O arquivo de entrada contém dois inteiros. O primeiro é o tempo gasto na viagem em 
 * horas e o segundo é a velocidade média durante a mesma em km/h.
 *
 * Saída
 *      Imprima a quantidade de litros necessária para realizar a viagem, com três dígitos 
 * após o ponto decimal.
 */

using System;

class Program 
{
    static void Main(string[] args) 
    {
        int numeroDeFigurinhas = int.Parse(Console.ReadLine());
        int numeroDeFigurinhasCompradas = int.Parse(Console.ReadLine());
        int totalDeFigurinhas = 0;

        int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];

        for (int i = 0; i < numeroDeFigurinhasCompradas; i++) 
        {
            string entrada = Console.ReadLine();
            
            if (entrada != null) 
            {
                albumDeFigurinha[i] = int.Parse(entrada);
            }
        }

        for (int i = 0; i < numeroDeFigurinhasCompradas; i++) 
        {
            int figurinha = albumDeFigurinha[i];
            int repetida = 0;

            for (int j = 0; j < numeroDeFigurinhasCompradas; j++) 
            {
                if (albumDeFigurinha[j] == figurinha) 
                {
                    repetida++;
                } 
            }

            if (repetida >= 2) 
            {    
                for (int j = 0; j < numeroDeFigurinhasCompradas; j++) {
                    if (figurinha == albumDeFigurinha[j]) { 
                        albumDeFigurinha[j] = -1;
                        break;
                    }
                }
            }
        }

        int figuras = 0;

        for (int i = 0; i < numeroDeFigurinhasCompradas; i++) 
        {    
            if (albumDeFigurinha[i] != -1) 
            {
                figuras++;
            }
        }
        totalDeFigurinhas = numeroDeFigurinhas - figuras;
        Console.Write(totalDeFigurinhas);
    }
}