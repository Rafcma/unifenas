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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ponderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafoNaoDirecionado grafoND = new frmGrafoNaoDirecionado();
            grafoND.Show();
            this.Hide();
        }

        private void nãoPonderadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafoNaoDirecionadoPonderado grafoPonderado = new frmGrafoNaoDirecionadoPonderado();
            grafoPonderado.Show();
            this.Hide();
        }
    }
}
