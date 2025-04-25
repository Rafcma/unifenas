namespace ProjetoFinal
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grafoNãoDirecionadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponderadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nãoPonderadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafoNãoDirecionadoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // grafoNãoDirecionadoToolStripMenuItem
            // 
            this.grafoNãoDirecionadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponderadoToolStripMenuItem,
            this.nãoPonderadoToolStripMenuItem});
            this.grafoNãoDirecionadoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grafoNãoDirecionadoToolStripMenuItem.Name = "grafoNãoDirecionadoToolStripMenuItem";
            this.grafoNãoDirecionadoToolStripMenuItem.Size = new System.Drawing.Size(113, 41);
            this.grafoNãoDirecionadoToolStripMenuItem.Text = "Grafos";
            // 
            // ponderadoToolStripMenuItem
            // 
            this.ponderadoToolStripMenuItem.Name = "ponderadoToolStripMenuItem";
            this.ponderadoToolStripMenuItem.Size = new System.Drawing.Size(455, 42);
            this.ponderadoToolStripMenuItem.Text = "Não Direcionado";
            this.ponderadoToolStripMenuItem.Click += new System.EventHandler(this.ponderadoToolStripMenuItem_Click);
            // 
            // nãoPonderadoToolStripMenuItem
            // 
            this.nãoPonderadoToolStripMenuItem.Name = "nãoPonderadoToolStripMenuItem";
            this.nãoPonderadoToolStripMenuItem.Size = new System.Drawing.Size(455, 42);
            this.nãoPonderadoToolStripMenuItem.Text = "Não Direcionado Ponderado";
            this.nãoPonderadoToolStripMenuItem.Click += new System.EventHandler(this.nãoPonderadoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(53, 41);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu Principal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem grafoNãoDirecionadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ponderadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nãoPonderadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}