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
    public partial class frmGrafoNaoDirecionadoPonderado : Form
    {
        public frmGrafoNaoDirecionadoPonderado()
        {
            InitializeComponent();
        }

        private Grafo grafo;


        private void btnCriarGrafo_Click(object sender, EventArgs e)
        {
            try
            {
                int numCidades = int.Parse(txtNumCidades.Text);
                grafo = new Grafo(numCidades);

                MessageBox.Show("Grafo criado com " + numCidades + " cidades.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um número válido de cidades.");
            }
        }
        private void btnAdcionarCidade_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceCidade = int.Parse(txtIndiceCidade.Text);
                string nomeCidade = txtNomeCidade.Text;

                grafo.AdicionarCidade(indiceCidade, nomeCidade);

                AtualizarListaCidades();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira valores válidos para o índice e o nome da cidade.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtIndiceCidade.Clear();
            txtNomeCidade.Clear();
        }
        private void AtualizarListaCidades()
        {
            List<string> listaCidades = grafo.ObterListaCidades();

            foreach (string cidade in listaCidades)
            {
                if (!lstCidades.Items.Contains(cidade))
                {
                    lstCidades.Items.Add(cidade);
                }
            }
        }
            private void btnAdicionarDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                int origem = int.Parse(txtOrigem.Text);
                int destino = int.Parse(txtDestino.Text);
                int peso = int.Parse(txtPeso.Text);

                grafo.AdicionarAresta(origem, destino, peso);
                MessageBox.Show("Aresta adicionada entre " + grafo.nomesCidades[origem] + " e " + grafo.nomesCidades[destino] + " com distância " + peso + " KM");
                AtualizarMatrizAdjacencia();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos para os vértices e peso da aresta.");
            }
        }
        private void AtualizarMatrizAdjacencia()
        {
            dgvMatrizAdjacencia.Columns.Clear();
            dgvMatrizAdjacencia.Rows.Clear();

            foreach (var cidade in grafo.nomesCidades)
            {
                dgvMatrizAdjacencia.Columns.Add(cidade, cidade);
            }

            for (int i = 0; i < grafo.numVertices; i++)
            {
                dgvMatrizAdjacencia.Rows.Add();
                for (int j = 0; j < grafo.numVertices; j++)
                {
                    dgvMatrizAdjacencia.Rows[i].Cells[j].Value = grafo.matrizAdjacencia[i, j];
                }
            }
        }

        private void btnCaminhoMinimo_Click(object sender, EventArgs e)
        {
            try
            {
                int origem = int.Parse(txtOrigem.Text);
                int destino = int.Parse(txtDestino.Text);

                if (origem < 0 || origem >= grafo.numVertices || destino < 0 || destino >= grafo.numVertices)
                {
                    MessageBox.Show("Origem ou destino inválidos. Insira valores entre 1 e " + grafo.numVertices + ".");
                    return;
                }

                var resultado = grafo.EncontrarCaminhoMinimo(origem, destino);
                int[] caminho = resultado.Item1;
                int distancia = resultado.Item2;

                if (distancia == int.MaxValue)
                {
                    MessageBox.Show("Não existe caminho entre " + grafo.nomesCidades[origem] + " e " + grafo.nomesCidades[destino] + ".");
                }
                else
                {
                    string caminhoStr = string.Join(" -> ", caminho.Select(i => grafo.nomesCidades[i]));
                    MessageBox.Show("Caminho mínimo: " + caminhoStr + " com distância total de " + distancia + " KM.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos para os vértices.");
            }
        }

        private void btnVerificarDistancia_Click(object sender, EventArgs e)
        {
            try
            {
                int origem = int.Parse(txtOrigem.Text);
                int destino = int.Parse(txtDestino.Text);

                int distancia = grafo.ObterDistancia(origem, destino);

                string nomeOrigem = grafo.ObterNomeCidade(origem);
                string nomeDestino = grafo.ObterNomeCidade(destino);

                if (distancia == 0)
                {
                    MessageBox.Show("Não há uma conexão (aresta) entre " + nomeOrigem + " e " + nomeDestino + ".");
                }
                else
                {
                    MessageBox.Show("A distância entre " + nomeOrigem + " e " + nomeDestino + " é " + distancia + " KM.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos para os vértices.");
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
