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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1224, 115);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMO COMER SEU \r\nBURGÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 579);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 44);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsiCadastro
            // 
            this.TsiCadastro.BackColor = System.Drawing.Color.White;
            this.TsiCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsiProdutos,
            this.TsiFuncionarios});
            this.TsiCadastro.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsiCadastro.Name = "TsiCadastro";
            this.TsiCadastro.Size = new System.Drawing.Size(135, 40);
            this.TsiCadastro.Text = "Cadastro";
            
            // 
            // TsiProdutos
            // 
            this.TsiProdutos.BackColor = System.Drawing.Color.White;
            this.TsiProdutos.Name = "TsiProdutos";
            this.TsiProdutos.Size = new System.Drawing.Size(244, 42);
            this.TsiProdutos.Text = "Produtos";
            // 
            // TsiFuncionarios
            // 
            this.TsiFuncionarios.BackColor = System.Drawing.Color.White;
            this.TsiFuncionarios.Name = "TsiFuncionarios";
            this.TsiFuncionarios.Size = new System.Drawing.Size(244, 42);
            this.TsiFuncionarios.Text = "Funcionários";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1224, 623);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsiCadastro;
        private System.Windows.Forms.ToolStripMenuItem TsiProdutos;
        private System.Windows.Forms.ToolStripMenuItem TsiFuncionarios;
    }
}