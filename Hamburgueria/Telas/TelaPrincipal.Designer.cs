namespace Hamburgueria.Telas
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsiCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsiFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.LblUserLogado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1924, 187);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMO COMER SEU \r\nBURGÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 786);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 64);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsiCadastro
            // 
            this.TsiCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TsiCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiProdutos,
            this.TsiFuncionarios});
            this.TsiCadastro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsiCadastro.ForeColor = System.Drawing.Color.Maroon;
            this.TsiCadastro.Name = "TsiCadastro";
            this.TsiCadastro.Size = new System.Drawing.Size(167, 60);
            this.TsiCadastro.Text = "Cadastro";
            // 
            // TsiProdutos
            // 
            this.TsiProdutos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TsiProdutos.ForeColor = System.Drawing.Color.Maroon;
            this.TsiProdutos.Name = "TsiProdutos";
            this.TsiProdutos.Size = new System.Drawing.Size(303, 50);
            this.TsiProdutos.Text = "Produtos";
            this.TsiProdutos.Click += new System.EventHandler(this.TsiProdutos_Click);
            // 
            // TsiFuncionarios
            // 
            this.TsiFuncionarios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TsiFuncionarios.ForeColor = System.Drawing.Color.Maroon;
            this.TsiFuncionarios.Name = "TsiFuncionarios";
            this.TsiFuncionarios.Size = new System.Drawing.Size(303, 50);
            this.TsiFuncionarios.Text = "Funcionários";
            this.TsiFuncionarios.Click += new System.EventHandler(this.TsiFuncionarios_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(1497, 801);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário logado:";
            // 
            // LblUserLogado
            // 
            this.LblUserLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUserLogado.AutoSize = true;
            this.LblUserLogado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserLogado.ForeColor = System.Drawing.Color.Transparent;
            this.LblUserLogado.Location = new System.Drawing.Point(1729, 801);
            this.LblUserLogado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUserLogado.Name = "LblUserLogado";
            this.LblUserLogado.Size = new System.Drawing.Size(72, 32);
            this.LblUserLogado.TabIndex = 5;
            this.LblUserLogado.Text = "Adm";
            this.LblUserLogado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 187);
            this.panel1.TabIndex = 7;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1924, 850);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblUserLogado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsiCadastro;
        private System.Windows.Forms.ToolStripMenuItem TsiProdutos;
        private System.Windows.Forms.ToolStripMenuItem TsiFuncionarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblUserLogado;
        private System.Windows.Forms.Panel panel1;
    }
}