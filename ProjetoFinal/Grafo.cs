using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public class Grafo
    {
        public int[,] matrizAdjacencia { get; private set; }
        public int numVertices { get; private set; }
        public List<string> nomesCidades;
        public Grafo(int numVertices)
        {
            this.numVertices = numVertices;
            matrizAdjacencia = new int[numVertices, numVertices];
            nomesCidades = new List<string>(numVertices);

            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    matrizAdjacencia[i, j] = 0;
                }
            }
        }
        public void AdicionarAresta(int origem, int destino, int peso)
        {
            if (origem >= 0 && origem < numVertices && destino >= 0 && destino < numVertices)
            {
                matrizAdjacencia[origem, destino] = peso;
                matrizAdjacencia[destino, origem] = peso;
            }
            else
                MessageBox.Show("Índice de vértice inválido.");
        }
        
        public void ExibirMatriz()
        {
            for (int i = 0; i < numVertices; i++)
            {
                for (int j = 0; j < numVertices; j++)
                {
                    Console.Write(matrizAdjacencia[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public bool VerificarGrafoSimples()
        {
            for (int i = 0; i < numVertices; i++)
            {

                if (matrizAdjacencia[i, i] != 0)
                    return false;


                for (int j = 0; j < numVertices; j++)
                {
                    if (matrizAdjacencia[i, j] > 1)
                        return false;
                }

            }
            return true;
        }


        public bool VerificarGrafoEuleriano()
        {
            for (int i = 0; i < numVertices; i++)
            {
                int grau = 0;
                for (int j = 0; j < numVertices; j++)
                {
                    if (matrizAdjacencia[i, j] != 0)
                        grau++;
                }
                if (grau % 2 != 0)
                    return false;
            }
            return true;
        }

        public void AdicionarCidade(int indice, string nome)
        {
            if (indice >= 0 && indice < numVertices)
            {
                if (nomesCidades.Count > indice)
                {
                    nomesCidades[indice] = nome;
                }
                else
                {
                    while (nomesCidades.Count <= indice)
                    {
                        nomesCidades.Add("");
                    }
                    nomesCidades[indice] = nome;
                }
            }
            else
            {
                MessageBox.Show("Índice inválido.");
            }
        }
        public List<string> ObterListaCidades()
        {
            List<string> listaCidadesComIndice = new List<string>();
            for (int i = 0; i < nomesCidades.Count; i++)
            {
                if (!string.IsNullOrEmpty(nomesCidades[i]))
                {
                    listaCidadesComIndice.Add($"{i}: {nomesCidades[i]}");
                }
            }
            return listaCidadesComIndice;
        }
        public string ObterNomeCidade(int indice)
        {
            if (indice >= 0 && indice < nomesCidades.Count)
            {
                return nomesCidades[indice];
            }
            return null;
        }
        public int ObterDistancia(int origem, int destino)
        {
            return matrizAdjacencia[origem, destino];
        }

        public (int[], int) EncontrarCaminhoMinimo(int origem, int destino)
        {
            int[] distancias = new int[numVertices];
            bool[] visitados = new bool[numVertices];
            int[] anteriores = new int[numVertices];

            for (int i = 0; i < numVertices; i++)
            {
                distancias[i] = int.MaxValue;
                anteriores[i] = -1;
            }
            distancias[origem] = 0;

            for (int i = 0; i < numVertices - 1; i++)
            {
                
                int proximoVertice = -1;

                for (int j = 0; j < numVertices; j++)
                {
                    if (!visitados[j] && (proximoVertice == -1 || distancias[j] < distancias[proximoVertice]))
                    {
                        proximoVertice = j;
                    }
                }

                if (proximoVertice == -1)
                    break;

                visitados[proximoVertice] = true;

                for (int j = 0; j < numVertices; j++)
                {
                    if (matrizAdjacencia[proximoVertice, j] > 0)
                    {
                        int novaDistancia = distancias[proximoVertice] + matrizAdjacencia[proximoVertice, j];

                        if (novaDistancia < distancias[j])
                        {
                            distancias[j] = novaDistancia;
                            anteriores[j] = proximoVertice;
                        }
                    }
                }
            }

            if (distancias[destino] == int.MaxValue)
            {
                return (new int[0], int.MaxValue);
            }

            List<int> caminho = new List<int>();
            for (int v = destino; v != -1; v = anteriores[v])
            {
                caminho.Add(v);
            }
            caminho.Reverse();

            return (caminho.ToArray(), distancias[destino]);
        }

    }
}
