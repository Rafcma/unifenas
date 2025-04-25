using ProjetoFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal
{
    public partial class frmGrafoNaoDirecionado : Form
    {
        public frmGrafoNaoDirecionado()
        {
            InitializeComponent();
        }

        private Grafo grafo;

        private void btnCriarGrafo_Click(object sender, EventArgs e)
        {
            try
            {
                int numVertices = int.Parse(txtNumVertices.Text);

                grafo = new Grafo(numVertices);

                MessageBox.Show("Grafo criado com " + numVertices + " vértices.");
                AtualizarMatrizAdjacencia();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido de vértices.");
            }
        }
        private void AtualizarMatrizAdjacencia()
        {
            dgvMatrizAdjacencia.Columns.Clear();
            dgvMatrizAdjacencia.Rows.Clear();

            for (int i = 0; i < grafo.numVertices; i++)
            {
                dgvMatrizAdjacencia.Columns.Add($"Vértice {i + 1}", $"Vértice {i + 1}");
                dgvMatrizAdjacencia.Rows.Add();
                dgvMatrizAdjacencia.Rows[i].HeaderCell.Value = $"Vértice {i + 1}";
            }

            for (int i = 0; i < grafo.numVertices; i++)
            {
                for (int j = 0; j < grafo.numVertices; j++)
                {
                    dgvMatrizAdjacencia.Rows[i].Cells[j].Value = grafo.matrizAdjacencia[i, j] != 0 ? grafo.matrizAdjacencia[i, j].ToString() : "0";
                }
            }
        }

        private void btnAdicionarAresta_Click(object sender, EventArgs e)
        {
            try
            {
                int origem = int.Parse(txtOrigem.Text);
                int destino = int.Parse(txtDestino.Text);
                int peso = int.Parse(txtPeso.Text);

                if (grafo == null)
                {
                    MessageBox.Show("Por favor, crie o grafo primeiro.");
                    return;
                }

                grafo.AdicionarAresta(origem - 1, destino - 1, peso);
                MessageBox.Show("Aresta adicionada entre Vértice " + origem + " e Vértice " + destino + " com peso " + peso);

                AtualizarMatrizAdjacencia();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos para os vértices e o peso da aresta.");
            }
        }

        private void btnMostraMatriz_Click(object sender, EventArgs e)
        {
            if (grafo == null)
            {
                MessageBox.Show("Por favor, crie o grafo primeiro.");
                return;
            }

            for (int i = 0; i < grafo.numVertices; i++)
            {
                for (int j = 0; j < grafo.numVertices; j++)
                {
                    dgvMatrizAdjacencia.Rows[i].Cells[j].Value = grafo.matrizAdjacencia[i, j] != 0 ? grafo.matrizAdjacencia[i, j].ToString() : "0";
                }
            }
            MessageBox.Show("Matriz de adjacência atualizada com as arestas.");
        }

        private void btnVerificaSimples_Click(object sender, EventArgs e)
        {
            if (grafo.VerificarGrafoSimples())
            {
                MessageBox.Show("O grafo é simples.");
            }
            else
            {
                MessageBox.Show("O grafo não é simples.");
            }
        }

        private void btnVerificaEuleriano_Click(object sender, EventArgs e)
        {
            if (grafo.VerificarGrafoEuleriano())
            {
                MessageBox.Show("O grafo é Euleriano.");
            }
            else
            {
                MessageBox.Show("O grafo não é Euleriano.");
            }
        }

        private void btnVoltaMenu_Click(object sender, EventArgs e)
        {
            frmPrincipal menu = new frmPrincipal();
            menu.Show();
            this.Close();
        }
    }
}

