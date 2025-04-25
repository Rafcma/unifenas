using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTrab
{ 
    internal class Program
    {
        static void Main()
        {
            int[] numeros = new int[10];

            Console.WriteLine("PROJETO TRABALHO");
            Console.WriteLine("\n\nMENU DE OPÇÕES:");
            Console.WriteLine("\n\n1. Organizar uma sequência de 10 números em 5 algoritmos diferentes");
            Console.WriteLine("\n2. Ordenar uma string em ordem crescente");
            Console.WriteLine("\n3. Ordenar nomes pelo tamanho");
            Console.WriteLine("\n\nEscolha uma opção: ");

            int opcao;
            if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
            {
                Console.WriteLine("Opção inválida");
                return;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nDigite os 10 números:");
                    for (int i = 0; i < 10; i++)
                    {
                        if (!int.TryParse(Console.ReadLine(), out numeros[i]))
                        {
                            Console.WriteLine("Valor inválido");
                            return;
                        }
                    }
                    Console.WriteLine("::Escolha um algoritmo para realizar a ordenação::\n\n// 1. Bubble Sort // 2. Selection Sort // 3. Insertion Sort // 4. Merge Sort // 5. Quick Sort //");
                    if (!int.TryParse(Console.ReadLine(), out int opcaoOrdenacao) || opcaoOrdenacao < 1 || opcaoOrdenacao > 5)
                    {
                        Console.WriteLine("Opção de ordenação inválida");
                        return;
                    }
                    OrdenarNumeros(numeros, opcaoOrdenacao);
                    Console.WriteLine("\n\nArray ordenado:");
                    foreach (int num in numeros)
                    {
                        Console.Write(num + " ");
                    }
                    Console.WriteLine($"\n\nNúmero de trocas realizadas: {trocas}\n");
                    break;
                case 2:
                    Console.WriteLine("\nDigite uma string:");
                    string aux = Console.ReadLine();

                    int trocasString = 0;
                    string stringOrdenada = OrdenarStringBubbleSort(aux, out trocasString);

                    Console.WriteLine($"\nString ordenada em ordem crescente de letras: {stringOrdenada}");
                    Console.WriteLine("\nNúmero de trocas realizadas: " + trocasString);
                    break;
                case 3:
                    Console.WriteLine("\nDigite a quantidade de nomes:");
                    if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
                    {
                        Console.WriteLine("Valor inválido");
                        return;
                    }
                    string[] nomes = new string[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine($"\nDigite o {i+1}° nome: ");
                        nomes[i] = Console.ReadLine();
                    }
                    SelectionSortString(nomes);
                    Console.WriteLine("\nNomes ordenados pelo tamanho:");
                    foreach (string nome in nomes)
                    {
                        Console.WriteLine(nome);
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static int trocas = 0;

        static void OrdenarNumeros(int[] array, int opcao)
        {
            switch (opcao)
            {
                case 1:
                    BubbleSort(array);
                    break;
                case 2:
                    SelectionSort(array);
                    break;
                case 3:
                    InsertionSort(array);
                    break;
                case 4:
                    MergeSort(array, 0, array.Length - 1);
                    break;
                case 5:
                    QuickSort(array, 0, array.Length - 1);
                    break;
                default:
                    Console.WriteLine("Opção de ordenação inválida.");
                    break;
            }
        }

        static void QuickSort(int[] array, int baixo, int alto)
        {
            if (baixo < alto)
            {
                int pivo = Particao(array, baixo, alto);
                QuickSort(array, baixo, pivo - 1);
                QuickSort(array, pivo + 1, alto);
            }
        }

        static int Particao(int[] array, int baixo, int alto)
        {
            int pivo = array[alto];
            int i = baixo - 1;

            for (int j = baixo; j < alto; j++)
            {
                if (array[j] < pivo)
                {
                    i++;
                    Trocar(array, i, j);
                    trocas++;
                }
            }

            Trocar(array, i + 1, alto);
            trocas++;
            return i + 1;
        }

        static void Trocar(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        trocas++;
                    }
                }
            }
        }

        static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indiceMenor = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[indiceMenor])
                    {
                        indiceMenor = j;
                    }
                }
                if (indiceMenor != i)
                {
                    int temp = array[i];
                    array[i] = array[indiceMenor];
                    array[indiceMenor] = temp;
                    trocas++;
                }
            }
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int chave = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > chave)
                {
                    array[j + 1] = array[j];
                    j--;
                    trocas++;
                }
                array[j + 1] = chave;
            }
        }

        static void MergeSort(int[] array, int baixo, int alto)
        {
            if (baixo < alto)
            {
                int meio = (baixo + alto) / 2;
                MergeSort(array, baixo, meio);
                MergeSort(array, meio + 1, alto);
                Mesclar(array, baixo, meio, alto);
            }
        }

        static void Mesclar(int[] array, int baixo, int meio, int alto)
        {
            int n1 = meio - baixo + 1;
            int n2 = alto - meio;

            int[] arrayEsquerda = new int[n1];
            int[] arrayDireita = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                arrayEsquerda[i] = array[baixo + i];
            }
            for (int j = 0; j < n2; j++)
            {
                arrayDireita[j] = array[meio + 1 + j];
            }

            int k = baixo;
            int l = 0;
            int r = 0;

            while (l < n1 && r < n2)
            {
                if (arrayEsquerda[l] <= arrayDireita[r])
                {
                    array[k] = arrayEsquerda[l];
                    l++;
                }
                else
                {
                    array[k] = arrayDireita[r];
                    r++;
                    trocas++;
                }
                k++;
            }
            while (l < n1)
            {
                array[k] = arrayEsquerda[l];
                l++;
                k++;
            }
            while (r < n2)
            {
                array[k] = arrayDireita[r];
                r++;
                k++;
                trocas++;
            }
        }

        static string OrdenarStringBubbleSort(string entrada, out int trocas)
        {
            char[] letras = entrada.ToCharArray();
            trocas = 0;

            for (int i = 0; i < letras.Length - 1; i++)
            {
                for (int j = 0; j < letras.Length - 1 - i; j++)
                {
                    if (letras[j] > letras[j + 1])
                    {
                        char temp = letras[j];
                        letras[j] = letras[j + 1];
                        letras[j + 1] = temp;
                        trocas++;
                    }
                }
            }
            return new string(letras);
        }

        static void SelectionSortString(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indiceMenor = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].Length < array[indiceMenor].Length)
                    {
                        indiceMenor = j;
                    }
                }
                if (indiceMenor != i)
                {
                    string temp = array[i];
                    array[i] = array[indiceMenor];
                    array[indiceMenor] = temp;
                    trocas++;
                }
            }
            Console.WriteLine("\nNúmero de trocas realizadas (SelectionSort): " + trocas);
        }
    }
}
