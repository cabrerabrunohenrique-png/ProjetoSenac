namespace ProjetoSenac
{
    partial class Nav
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
            this.btOrdemServico = new System.Windows.Forms.Button();
            this.btEstoque = new System.Windows.Forms.Button();
            this.btProdutoXPeca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOrdemServico
            // 
            this.btOrdemServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btOrdemServico.Location = new System.Drawing.Point(74, 154);
            this.btOrdemServico.Name = "btOrdemServico";
            this.btOrdemServico.Size = new System.Drawing.Size(154, 171);
            this.btOrdemServico.TabIndex = 0;
            this.btOrdemServico.Text = "Ordens de Serviços(OS)";
            this.btOrdemServico.UseVisualStyleBackColor = false;
            // 
            // btEstoque
            // 
            this.btEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btEstoque.Location = new System.Drawing.Point(282, 154);
            this.btEstoque.Name = "btEstoque";
            this.btEstoque.Size = new System.Drawing.Size(154, 171);
            this.btEstoque.TabIndex = 1;
            this.btEstoque.Text = "Estoque( Entrada de Produtos)";
            this.btEstoque.UseVisualStyleBackColor = false;
            // 
            // btProdutoXPeca
            // 
            this.btProdutoXPeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btProdutoXPeca.Location = new System.Drawing.Point(473, 154);
            this.btProdutoXPeca.Name = "btProdutoXPeca";
            this.btProdutoXPeca.Size = new System.Drawing.Size(154, 171);
            this.btProdutoXPeca.TabIndex = 2;
            this.btProdutoXPeca.Text = "Relação Produtos á Produzir X Peças";
            this.btProdutoXPeca.UseVisualStyleBackColor = false;
            // 
            // Nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.Controls.Add(this.btProdutoXPeca);
            this.Controls.Add(this.btEstoque);
            this.Controls.Add(this.btOrdemServico);
            this.Name = "Nav";
            this.Text = "Nav";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOrdemServico;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btProdutoXPeca;
    }
}