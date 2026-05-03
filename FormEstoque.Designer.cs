namespace ProjetoSenac
{
    partial class FormEstoque
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
            this.btRelacaoProdutoE = new System.Windows.Forms.Button();
            this.btAcessarEstoqueE = new System.Windows.Forms.Button();
            this.btPaginaLoginE = new System.Windows.Forms.Button();
            this.btAcessarRelatorioE = new System.Windows.Forms.Button();
            this.btVoltarE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRelacaoProdutoE
            // 
            this.btRelacaoProdutoE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btRelacaoProdutoE.Location = new System.Drawing.Point(640, 383);
            this.btRelacaoProdutoE.Name = "btRelacaoProdutoE";
            this.btRelacaoProdutoE.Size = new System.Drawing.Size(148, 55);
            this.btRelacaoProdutoE.TabIndex = 23;
            this.btRelacaoProdutoE.Text = "Acessar Relaçao Produto";
            this.btRelacaoProdutoE.UseVisualStyleBackColor = false;
            // 
            // btAcessarEstoqueE
            // 
            this.btAcessarEstoqueE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btAcessarEstoqueE.Location = new System.Drawing.Point(640, 322);
            this.btAcessarEstoqueE.Name = "btAcessarEstoqueE";
            this.btAcessarEstoqueE.Size = new System.Drawing.Size(148, 55);
            this.btAcessarEstoqueE.TabIndex = 22;
            this.btAcessarEstoqueE.Text = "Acessar Estoque";
            this.btAcessarEstoqueE.UseVisualStyleBackColor = false;
            // 
            // btPaginaLoginE
            // 
            this.btPaginaLoginE.BackColor = System.Drawing.Color.Lime;
            this.btPaginaLoginE.Location = new System.Drawing.Point(625, 184);
            this.btPaginaLoginE.Name = "btPaginaLoginE";
            this.btPaginaLoginE.Size = new System.Drawing.Size(163, 65);
            this.btPaginaLoginE.TabIndex = 21;
            this.btPaginaLoginE.Text = "Acessar Pagina Login";
            this.btPaginaLoginE.UseVisualStyleBackColor = false;
            // 
            // btAcessarRelatorioE
            // 
            this.btAcessarRelatorioE.BackColor = System.Drawing.Color.Yellow;
            this.btAcessarRelatorioE.Location = new System.Drawing.Point(625, 97);
            this.btAcessarRelatorioE.Name = "btAcessarRelatorioE";
            this.btAcessarRelatorioE.Size = new System.Drawing.Size(163, 64);
            this.btAcessarRelatorioE.TabIndex = 20;
            this.btAcessarRelatorioE.Text = "Acessar os Relatórios";
            this.btAcessarRelatorioE.UseVisualStyleBackColor = false;
            // 
            // btVoltarE
            // 
            this.btVoltarE.BackColor = System.Drawing.Color.OrangeRed;
            this.btVoltarE.ForeColor = System.Drawing.Color.White;
            this.btVoltarE.Location = new System.Drawing.Point(625, 12);
            this.btVoltarE.Name = "btVoltarE";
            this.btVoltarE.Size = new System.Drawing.Size(163, 67);
            this.btVoltarE.TabIndex = 19;
            this.btVoltarE.Text = "Tela Inicial";
            this.btVoltarE.UseVisualStyleBackColor = false;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRelacaoProdutoE);
            this.Controls.Add(this.btAcessarEstoqueE);
            this.Controls.Add(this.btPaginaLoginE);
            this.Controls.Add(this.btAcessarRelatorioE);
            this.Controls.Add(this.btVoltarE);
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRelacaoProdutoE;
        private System.Windows.Forms.Button btAcessarEstoqueE;
        private System.Windows.Forms.Button btPaginaLoginE;
        private System.Windows.Forms.Button btAcessarRelatorioE;
        private System.Windows.Forms.Button btVoltarE;
    }
}