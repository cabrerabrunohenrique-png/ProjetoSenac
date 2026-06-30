namespace ProjetoSenac
{
    partial class FormProdutosCadastrado
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
            this.lQuantidade = new System.Windows.Forms.Label();
            this.lNomePeca = new System.Windows.Forms.Label();
            this.lCodigoPeca = new System.Windows.Forms.Label();
            this.lNomeProduto = new System.Windows.Forms.Label();
            this.lCodigoProduto = new System.Windows.Forms.Label();
            this.btVoltarOS = new System.Windows.Forms.Button();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TXNomeProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TXCodigoProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-148, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Comprimento Produto";
            // 
            // lQuantidade
            // 
            this.lQuantidade.AutoSize = true;
            this.lQuantidade.Location = new System.Drawing.Point(-148, 140);
            this.lQuantidade.Name = "lQuantidade";
            this.lQuantidade.Size = new System.Drawing.Size(110, 16);
            this.lQuantidade.TabIndex = 55;
            this.lQuantidade.Text = "Altura do Produto";
            // 
            // lNomePeca
            // 
            this.lNomePeca.AutoSize = true;
            this.lNomePeca.Location = new System.Drawing.Point(-148, 92);
            this.lNomePeca.Name = "lNomePeca";
            this.lNomePeca.Size = new System.Drawing.Size(108, 16);
            this.lNomePeca.TabIndex = 54;
            this.lNomePeca.Text = "Peso do Produto";
            // 
            // lCodigoPeca
            // 
            this.lCodigoPeca.AutoSize = true;
            this.lCodigoPeca.Location = new System.Drawing.Point(-148, 46);
            this.lCodigoPeca.Name = "lCodigoPeca";
            this.lCodigoPeca.Size = new System.Drawing.Size(71, 16);
            this.lCodigoPeca.TabIndex = 53;
            this.lCodigoPeca.Text = "Fabricante";
            // 
            // lNomeProduto
            // 
            this.lNomeProduto.AutoSize = true;
            this.lNomeProduto.Location = new System.Drawing.Point(-148, 2);
            this.lNomeProduto.Name = "lNomeProduto";
            this.lNomeProduto.Size = new System.Drawing.Size(113, 16);
            this.lNomeProduto.TabIndex = 52;
            this.lNomeProduto.Text = "Nome do Produto";
            // 
            // lCodigoProduto
            // 
            this.lCodigoProduto.AutoSize = true;
            this.lCodigoProduto.Location = new System.Drawing.Point(-148, -39);
            this.lCodigoProduto.Name = "lCodigoProduto";
            this.lCodigoProduto.Size = new System.Drawing.Size(120, 16);
            this.lCodigoProduto.TabIndex = 51;
            this.lCodigoProduto.Text = "Codigo do Produto";
            // 
            // btVoltarOS
            // 
            this.btVoltarOS.BackColor = System.Drawing.Color.RoyalBlue;
            this.btVoltarOS.ForeColor = System.Drawing.Color.White;
            this.btVoltarOS.Location = new System.Drawing.Point(907, 39);
            this.btVoltarOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVoltarOS.Name = "btVoltarOS";
            this.btVoltarOS.Size = new System.Drawing.Size(163, 66);
            this.btVoltarOS.TabIndex = 4;
            this.btVoltarOS.Text = "Tela Inicial";
            this.btVoltarOS.UseVisualStyleBackColor = false;
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Location = new System.Drawing.Point(12, 261);
            this.dgvPesquisa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.RowHeadersWidth = 51;
            this.dgvPesquisa.RowTemplate.Height = 24;
            this.dgvPesquisa.Size = new System.Drawing.Size(1058, 250);
            this.dgvPesquisa.TabIndex = 5;
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btPesquisar.Location = new System.Drawing.Point(266, 177);
            this.btPesquisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(191, 37);
            this.btPesquisar.TabIndex = 3;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Nome do Produto";
            // 
            // TXNomeProduto
            // 
            this.TXNomeProduto.Location = new System.Drawing.Point(275, 102);
            this.TXNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXNomeProduto.Name = "TXNomeProduto";
            this.TXNomeProduto.Size = new System.Drawing.Size(191, 22);
            this.TXNomeProduto.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 67;
            this.label7.Text = "Codigo do Produto";
            // 
            // TXCodigoProduto
            // 
            this.TXCodigoProduto.Location = new System.Drawing.Point(275, 61);
            this.TXCodigoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXCodigoProduto.Name = "TXCodigoProduto";
            this.TXCodigoProduto.Size = new System.Drawing.Size(191, 22);
            this.TXCodigoProduto.TabIndex = 1;
            // 
            // FormProdutosCadastrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 575);
            this.Controls.Add(this.btVoltarOS);
            this.Controls.Add(this.dgvPesquisa);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXNomeProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TXCodigoProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lQuantidade);
            this.Controls.Add(this.lNomePeca);
            this.Controls.Add(this.lCodigoPeca);
            this.Controls.Add(this.lNomeProduto);
            this.Controls.Add(this.lCodigoProduto);
            this.Name = "FormProdutosCadastrado";
            this.Text = "FormProdutosCadastrado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lQuantidade;
        private System.Windows.Forms.Label lNomePeca;
        private System.Windows.Forms.Label lCodigoPeca;
        private System.Windows.Forms.Label lNomeProduto;
        private System.Windows.Forms.Label lCodigoProduto;
        private System.Windows.Forms.Button btVoltarOS;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXNomeProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXCodigoProduto;
    }
}