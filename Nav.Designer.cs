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
            this.btEstoqueEntrada = new System.Windows.Forms.Button();
            this.btProdutoXPeca = new System.Windows.Forms.Button();
            this.btAcessarRelatorioN = new System.Windows.Forms.Button();
            this.btPaginaLogin = new System.Windows.Forms.Button();
            this.btEstoqueSaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOrdemServico
            // 
            this.btOrdemServico.BackColor = System.Drawing.Color.Yellow;
            this.btOrdemServico.Location = new System.Drawing.Point(80, 106);
            this.btOrdemServico.Name = "btOrdemServico";
            this.btOrdemServico.Size = new System.Drawing.Size(154, 171);
            this.btOrdemServico.TabIndex = 0;
            this.btOrdemServico.Text = "Ordens de Serviços(OS)";
            this.btOrdemServico.UseVisualStyleBackColor = false;
            this.btOrdemServico.Click += new System.EventHandler(this.btOrdemServico_Click);
            // 
            // btEstoqueEntrada
            // 
            this.btEstoqueEntrada.BackColor = System.Drawing.Color.Lime;
            this.btEstoqueEntrada.Location = new System.Drawing.Point(80, 283);
            this.btEstoqueEntrada.Name = "btEstoqueEntrada";
            this.btEstoqueEntrada.Size = new System.Drawing.Size(154, 171);
            this.btEstoqueEntrada.TabIndex = 1;
            this.btEstoqueEntrada.Text = "Estoque - ENTRADA";
            this.btEstoqueEntrada.UseVisualStyleBackColor = false;
            this.btEstoqueEntrada.Click += new System.EventHandler(this.btEstoque_Click);
            // 
            // btProdutoXPeca
            // 
            this.btProdutoXPeca.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btProdutoXPeca.Location = new System.Drawing.Point(240, 106);
            this.btProdutoXPeca.Name = "btProdutoXPeca";
            this.btProdutoXPeca.Size = new System.Drawing.Size(154, 171);
            this.btProdutoXPeca.TabIndex = 2;
            this.btProdutoXPeca.Text = "Relação Produtos á Produzir X Peças";
            this.btProdutoXPeca.UseVisualStyleBackColor = false;
            // 
            // btAcessarRelatorioN
            // 
            this.btAcessarRelatorioN.BackColor = System.Drawing.Color.LightBlue;
            this.btAcessarRelatorioN.Location = new System.Drawing.Point(400, 106);
            this.btAcessarRelatorioN.Name = "btAcessarRelatorioN";
            this.btAcessarRelatorioN.Size = new System.Drawing.Size(151, 171);
            this.btAcessarRelatorioN.TabIndex = 3;
            this.btAcessarRelatorioN.Text = "Acessar os Relatórios";
            this.btAcessarRelatorioN.UseVisualStyleBackColor = false;
            // 
            // btPaginaLogin
            // 
            this.btPaginaLogin.Location = new System.Drawing.Point(544, 13);
            this.btPaginaLogin.Name = "btPaginaLogin";
            this.btPaginaLogin.Size = new System.Drawing.Size(163, 65);
            this.btPaginaLogin.TabIndex = 4;
            this.btPaginaLogin.Text = "Acessar Pagina Login";
            this.btPaginaLogin.UseVisualStyleBackColor = true;
            this.btPaginaLogin.Click += new System.EventHandler(this.btPaginaLogin_Click);
            // 
            // btEstoqueSaida
            // 
            this.btEstoqueSaida.BackColor = System.Drawing.Color.Red;
            this.btEstoqueSaida.Location = new System.Drawing.Point(397, 283);
            this.btEstoqueSaida.Name = "btEstoqueSaida";
            this.btEstoqueSaida.Size = new System.Drawing.Size(154, 171);
            this.btEstoqueSaida.TabIndex = 5;
            this.btEstoqueSaida.Text = "Estoque - SAIDA";
            this.btEstoqueSaida.UseVisualStyleBackColor = false;
            // 
            // Nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 497);
            this.Controls.Add(this.btEstoqueSaida);
            this.Controls.Add(this.btPaginaLogin);
            this.Controls.Add(this.btAcessarRelatorioN);
            this.Controls.Add(this.btProdutoXPeca);
            this.Controls.Add(this.btEstoqueEntrada);
            this.Controls.Add(this.btOrdemServico);
            this.Name = "Nav";
            this.Text = "Nav";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOrdemServico;
        private System.Windows.Forms.Button btEstoqueEntrada;
        private System.Windows.Forms.Button btProdutoXPeca;
        private System.Windows.Forms.Button btAcessarRelatorioN;
        private System.Windows.Forms.Button btPaginaLogin;
        private System.Windows.Forms.Button btEstoqueSaida;
    }
}