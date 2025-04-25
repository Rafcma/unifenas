namespace ProjetoFinal
{
    partial class frmGrafoNaoDirecionado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumVertices = new System.Windows.Forms.TextBox();
            this.btnVerificaSimples = new System.Windows.Forms.Button();
            this.btnVerificaEuleriano = new System.Windows.Forms.Button();
            this.btnVoltaMenu = new System.Windows.Forms.Button();
            this.dgvMatrizAdjacencia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCriarGrafo = new System.Windows.Forms.Button();
            this.btnAdicionarAresta = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizAdjacencia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumVertices
            // 
            this.txtNumVertices.Location = new System.Drawing.Point(179, 54);
            this.txtNumVertices.Name = "txtNumVertices";
            this.txtNumVertices.Size = new System.Drawing.Size(43, 20);
            this.txtNumVertices.TabIndex = 0;
            // 
            // btnVerificaSimples
            // 
            this.btnVerificaSimples.Location = new System.Drawing.Point(27, 314);
            this.btnVerificaSimples.Name = "btnVerificaSimples";
            this.btnVerificaSimples.Size = new System.Drawing.Size(175, 23);
            this.btnVerificaSimples.TabIndex = 2;
            this.btnVerificaSimples.Text = "Verificar Grafo Simples";
            this.btnVerificaSimples.UseVisualStyleBackColor = true;
            this.btnVerificaSimples.Click += new System.EventHandler(this.btnVerificaSimples_Click);
            // 
            // btnVerificaEuleriano
            // 
            this.btnVerificaEuleriano.Location = new System.Drawing.Point(27, 343);
            this.btnVerificaEuleriano.Name = "btnVerificaEuleriano";
            this.btnVerificaEuleriano.Size = new System.Drawing.Size(175, 23);
            this.btnVerificaEuleriano.TabIndex = 3;
            this.btnVerificaEuleriano.Text = "Verificar Grafo Euleriano";
            this.btnVerificaEuleriano.UseVisualStyleBackColor = true;
            this.btnVerificaEuleriano.Click += new System.EventHandler(this.btnVerificaEuleriano_Click);
            // 
            // btnVoltaMenu
            // 
            this.btnVoltaMenu.Location = new System.Drawing.Point(27, 401);
            this.btnVoltaMenu.Name = "btnVoltaMenu";
            this.btnVoltaMenu.Size = new System.Drawing.Size(175, 23);
            this.btnVoltaMenu.TabIndex = 4;
            this.btnVoltaMenu.Text = "Voltar ao Menu";
            this.btnVoltaMenu.UseVisualStyleBackColor = true;
            this.btnVoltaMenu.Click += new System.EventHandler(this.btnVoltaMenu_Click);
            // 
            // dgvMatrizAdjacencia
            // 
            this.dgvMatrizAdjacencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizAdjacencia.Location = new System.Drawing.Point(248, 54);
            this.dgvMatrizAdjacencia.Name = "dgvMatrizAdjacencia";
            this.dgvMatrizAdjacencia.Size = new System.Drawing.Size(681, 370);
            this.dgvMatrizAdjacencia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insira o Número de Vértices ->";
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(170, 151);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(32, 20);
            this.txtOrigem.TabIndex = 7;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(170, 185);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(32, 20);
            this.txtDestino.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Insira o Vértice de Origem ->";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insira o Vértice de Destino ->";
            // 
            // btnCriarGrafo
            // 
            this.btnCriarGrafo.Location = new System.Drawing.Point(27, 89);
            this.btnCriarGrafo.Name = "btnCriarGrafo";
            this.btnCriarGrafo.Size = new System.Drawing.Size(195, 23);
            this.btnCriarGrafo.TabIndex = 11;
            this.btnCriarGrafo.Text = "Criar Grafo";
            this.btnCriarGrafo.UseVisualStyleBackColor = true;
            this.btnCriarGrafo.Click += new System.EventHandler(this.btnCriarGrafo_Click);
            // 
            // btnAdicionarAresta
            // 
            this.btnAdicionarAresta.Location = new System.Drawing.Point(27, 259);
            this.btnAdicionarAresta.Name = "btnAdicionarAresta";
            this.btnAdicionarAresta.Size = new System.Drawing.Size(175, 23);
            this.btnAdicionarAresta.TabIndex = 14;
            this.btnAdicionarAresta.Text = "Adicionar Aresta";
            this.btnAdicionarAresta.UseVisualStyleBackColor = true;
            this.btnAdicionarAresta.Click += new System.EventHandler(this.btnAdicionarAresta_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(158, 220);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(44, 20);
            this.txtPeso.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Insira o Peso da Aresta ->";
            // 
            // frmGrafoNaoDirecionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 472);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnAdicionarAresta);
            this.Controls.Add(this.btnCriarGrafo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMatrizAdjacencia);
            this.Controls.Add(this.btnVoltaMenu);
            this.Controls.Add(this.btnVerificaEuleriano);
            this.Controls.Add(this.btnVerificaSimples);
            this.Controls.Add(this.txtNumVertices);
            this.Name = "frmGrafoNaoDirecionado";
            this.Text = "GrafoNaoDirecionado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizAdjacencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumVertices;
        private System.Windows.Forms.Button btnVerificaSimples;
        private System.Windows.Forms.Button btnVerificaEuleriano;
        private System.Windows.Forms.Button btnVoltaMenu;
        private System.Windows.Forms.DataGridView dgvMatrizAdjacencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCriarGrafo;
        private System.Windows.Forms.Button btnAdicionarAresta;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label4;
    }
}