using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteRevisao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de linhas da matriz:");
            int linha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de coluna da matriz:");
            int coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.WriteLine($"Digite o valor para a posição [{i},{j}]:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz informada:");
            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }

            int soma = 0;
            foreach (int num in matriz)
            {
                soma += num;
            }
            Console.WriteLine($"\n\nSoma de todos os elementos da matriz == {soma}");

            // Calculando a média dos valores na matriz
            double media = (double)soma / (linha * coluna);
            Console.WriteLine($"\n\nMédia dos valores na matriz == {media}");
        }
    }
}
