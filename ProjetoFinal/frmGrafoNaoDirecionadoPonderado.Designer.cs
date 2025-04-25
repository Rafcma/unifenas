namespace ProjetoFinal
{
    partial class frmGrafoNaoDirecionadoPonderado
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumCidades = new System.Windows.Forms.TextBox();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIndiceCidade = new System.Windows.Forms.TextBox();
            this.btnCriarGrafo = new System.Windows.Forms.Button();
            this.dgvMatrizAdjacencia = new System.Windows.Forms.DataGridView();
            this.btnAdcionarCidade = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdicionarDistancia = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnVerificarDistancia = new System.Windows.Forms.Button();
            this.btnCaminhoMinimo = new System.Windows.Forms.Button();
            this.btnVoltaMenu = new System.Windows.Forms.Button();
            this.lstCidades = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizAdjacencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Cidades ->";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome da Cidade - >";
            // 
            // txtNumCidades
            // 
            this.txtNumCidades.Location = new System.Drawing.Point(179, 68);
            this.txtNumCidades.Name = "txtNumCidades";
            this.txtNumCidades.Size = new System.Drawing.Size(28, 20);
            this.txtNumCidades.TabIndex = 2;
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(153, 204);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(126, 20);
            this.txtNomeCidade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Índice da Cidade - >";
            // 
            // txtIndiceCidade
            // 
            this.txtIndiceCidade.Location = new System.Drawing.Point(153, 173);
            this.txtIndiceCidade.Name = "txtIndiceCidade";
            this.txtIndiceCidade.Size = new System.Drawing.Size(27, 20);
            this.txtIndiceCidade.TabIndex = 5;
            // 
            // btnCriarGrafo
            // 
            this.btnCriarGrafo.Location = new System.Drawing.Point(64, 94);
            this.btnCriarGrafo.Name = "btnCriarGrafo";
            this.btnCriarGrafo.Size = new System.Drawing.Size(143, 23);
            this.btnCriarGrafo.TabIndex = 6;
            this.btnCriarGrafo.Text = "Criar Mapa";
            this.btnCriarGrafo.UseVisualStyleBackColor = true;
            this.btnCriarGrafo.Click += new System.EventHandler(this.btnCriarGrafo_Click);
            // 
            // dgvMatrizAdjacencia
            // 
            this.dgvMatrizAdjacencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrizAdjacencia.Location = new System.Drawing.Point(316, 41);
            this.dgvMatrizAdjacencia.Name = "dgvMatrizAdjacencia";
            this.dgvMatrizAdjacencia.Size = new System.Drawing.Size(478, 259);
            this.dgvMatrizAdjacencia.TabIndex = 7;
            // 
            // btnAdcionarCidade
            // 
            this.btnAdcionarCidade.Location = new System.Drawing.Point(64, 230);
            this.btnAdcionarCidade.Name = "btnAdcionarCidade";
            this.btnAdcionarCidade.Size = new System.Drawing.Size(188, 23);
            this.btnAdcionarCidade.TabIndex = 8;
            this.btnAdcionarCidade.Text = "Adicionar Cidade";
            this.btnAdcionarCidade.UseVisualStyleBackColor = true;
            this.btnAdcionarCidade.Click += new System.EventHandler(this.btnAdcionarCidade_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Índice da Cidade de Origem - >";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Índice da Cidade de Destino - >";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Distância Entre as Cidades em KM - >";
            // 
            // btnAdicionarDistancia
            // 
            this.btnAdicionarDistancia.Location = new System.Drawing.Point(64, 380);
            this.btnAdicionarDistancia.Name = "btnAdicionarDistancia";
            this.btnAdicionarDistancia.Size = new System.Drawing.Size(188, 23);
            this.btnAdicionarDistancia.TabIndex = 12;
            this.btnAdicionarDistancia.Text = "Adicionar Distância";
            this.btnAdicionarDistancia.UseVisualStyleBackColor = true;
            this.btnAdicionarDistancia.Click += new System.EventHandler(this.btnAdicionarDistancia_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(234, 302);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(45, 20);
            this.txtOrigem.TabIndex = 13;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(234, 328);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(45, 20);
            this.txtDestino.TabIndex = 14;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(234, 354);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(45, 20);
            this.txtPeso.TabIndex = 15;
            // 
            // btnVerificarDistancia
            // 
            this.btnVerificarDistancia.Location = new System.Drawing.Point(369, 322);
            this.btnVerificarDistancia.Name = "btnVerificarDistancia";
            this.btnVerificarDistancia.Size = new System.Drawing.Size(170, 23);
            this.btnVerificarDistancia.TabIndex = 16;
            this.btnVerificarDistancia.Text = "Verificar Distância";
            this.btnVerificarDistancia.UseVisualStyleBackColor = true;
            this.btnVerificarDistancia.Click += new System.EventHandler(this.btnVerificarDistancia_Click);
            // 
            // btnCaminhoMinimo
            // 
            this.btnCaminhoMinimo.Location = new System.Drawing.Point(369, 351);
            this.btnCaminhoMinimo.Name = "btnCaminhoMinimo";
            this.btnCaminhoMinimo.Size = new System.Drawing.Size(170, 23);
            this.btnCaminhoMinimo.TabIndex = 17;
            this.btnCaminhoMinimo.Text = "Verificar Caminho Mínimo";
            this.btnCaminhoMinimo.UseVisualStyleBackColor = true;
            this.btnCaminhoMinimo.Click += new System.EventHandler(this.btnCaminhoMinimo_Click);
            // 
            // btnVoltaMenu
            // 
            this.btnVoltaMenu.Location = new System.Drawing.Point(369, 380);
            this.btnVoltaMenu.Name = "btnVoltaMenu";
            this.btnVoltaMenu.Size = new System.Drawing.Size(170, 23);
            this.btnVoltaMenu.TabIndex = 18;
            this.btnVoltaMenu.Text = "Voltar ao Menu";
            this.btnVoltaMenu.UseVisualStyleBackColor = true;
            this.btnVoltaMenu.Click += new System.EventHandler(this.btnVoltaMenu_Click);
            // 
            // lstCidades
            // 
            this.lstCidades.FormattingEnabled = true;
            this.lstCidades.Location = new System.Drawing.Point(626, 322);
            this.lstCidades.Name = "lstCidades";
            this.lstCidades.Size = new System.Drawing.Size(168, 82);
            this.lstCidades.TabIndex = 19;
            // 
            // frmGrafoNaoDirecionadoPonderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lstCidades);
            this.Controls.Add(this.btnVoltaMenu);
            this.Controls.Add(this.btnCaminhoMinimo);
            this.Controls.Add(this.btnVerificarDistancia);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigem);
            this.Controls.Add(this.btnAdicionarDistancia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdcionarCidade);
            this.Controls.Add(this.dgvMatrizAdjacencia);
            this.Controls.Add(this.btnCriarGrafo);
            this.Controls.Add(this.txtIndiceCidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeCidade);
            this.Controls.Add(this.txtNumCidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGrafoNaoDirecionadoPonderado";
            this.Text = "frmGrafoNaoDirecionadoPonderado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrizAdjacencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumCidades;
        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIndiceCidade;
        private System.Windows.Forms.Button btnCriarGrafo;
        private System.Windows.Forms.DataGridView dgvMatrizAdjacencia;
        private System.Windows.Forms.Button btnAdcionarCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarDistancia;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnVerificarDistancia;
        private System.Windows.Forms.Button btnCaminhoMinimo;
        private System.Windows.Forms.Button btnVoltaMenu;
        private System.Windows.Forms.ListBox lstCidades;
    }
}