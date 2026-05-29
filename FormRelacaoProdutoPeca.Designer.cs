namespace ProjetoSenac
{
    partial class FormRelacaoProdutoPeca
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
            this.btVoltarOS = new System.Windows.Forms.Button();
            this.lRelacaoPecasProduto = new System.Windows.Forms.Label();
            this.dGVRelacaoProduto = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lNomeProduto = new System.Windows.Forms.Label();
            this.txNomeProduto = new System.Windows.Forms.TextBox();
            this.lCodigoProduto = new System.Windows.Forms.Label();
            this.txProduto = new System.Windows.Forms.TextBox();
            this.txCodigoPeca = new System.Windows.Forms.TextBox();
            this.lCodigoPeca = new System.Windows.Forms.Label();
            this.lNomePeca = new System.Windows.Forms.Label();
            this.txNomePeca = new System.Windows.Forms.TextBox();
            this.lQuantidade = new System.Windows.Forms.Label();
            this.txQuantidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRelacaoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarOS
            // 
            this.btVoltarOS.BackColor = System.Drawing.Color.OrangeRed;
            this.btVoltarOS.ForeColor = System.Drawing.Color.White;
            this.btVoltarOS.Location = new System.Drawing.Point(472, 10);
            this.btVoltarOS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btVoltarOS.Name = "btVoltarOS";
            this.btVoltarOS.Size = new System.Drawing.Size(122, 54);
            this.btVoltarOS.TabIndex = 28;
            this.btVoltarOS.Text = "Tela Inicial";
            this.btVoltarOS.UseVisualStyleBackColor = false;
            this.btVoltarOS.Click += new System.EventHandler(this.btVoltarOS_Click);
            // 
            // lRelacaoPecasProduto
            // 
            this.lRelacaoPecasProduto.AutoSize = true;
            this.lRelacaoPecasProduto.BackColor = System.Drawing.Color.Red;
            this.lRelacaoPecasProduto.Location = new System.Drawing.Point(14, 242);
            this.lRelacaoPecasProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRelacaoPecasProduto.Name = "lRelacaoPecasProduto";
            this.lRelacaoPecasProduto.Size = new System.Drawing.Size(211, 13);
            this.lRelacaoPecasProduto.TabIndex = 27;
            this.lRelacaoPecasProduto.Text = "Relação_LISTA de PEÇAS por PRODUTO";
            // 
            // dGVRelacaoProduto
            // 
            this.dGVRelacaoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRelacaoProduto.Location = new System.Drawing.Point(16, 258);
            this.dGVRelacaoProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dGVRelacaoProduto.Name = "dGVRelacaoProduto";
            this.dGVRelacaoProduto.RowHeadersWidth = 51;
            this.dGVRelacaoProduto.RowTemplate.Height = 24;
            this.dGVRelacaoProduto.Size = new System.Drawing.Size(268, 124);
            this.dGVRelacaoProduto.TabIndex = 26;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCadastrar.Location = new System.Drawing.Point(154, 200);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(143, 30);
            this.btCadastrar.TabIndex = 25;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lNomeProduto
            // 
            this.lNomeProduto.AutoSize = true;
            this.lNomeProduto.Location = new System.Drawing.Point(9, 55);
            this.lNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeProduto.Name = "lNomeProduto";
            this.lNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.lNomeProduto.TabIndex = 24;
            this.lNomeProduto.Text = "Nome do Produto";
            // 
            // txNomeProduto
            // 
            this.txNomeProduto.Location = new System.Drawing.Point(154, 50);
            this.txNomeProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNomeProduto.Name = "txNomeProduto";
            this.txNomeProduto.Size = new System.Drawing.Size(144, 20);
            this.txNomeProduto.TabIndex = 23;
            // 
            // lCodigoProduto
            // 
            this.lCodigoProduto.AutoSize = true;
            this.lCodigoProduto.Location = new System.Drawing.Point(9, 22);
            this.lCodigoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCodigoProduto.Name = "lCodigoProduto";
            this.lCodigoProduto.Size = new System.Drawing.Size(95, 13);
            this.lCodigoProduto.TabIndex = 22;
            this.lCodigoProduto.Text = "Codigo do Produto";
            // 
            // txProduto
            // 
            this.txProduto.Location = new System.Drawing.Point(154, 17);
            this.txProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txProduto.Name = "txProduto";
            this.txProduto.Size = new System.Drawing.Size(144, 20);
            this.txProduto.TabIndex = 21;
            // 
            // txCodigoPeca
            // 
            this.txCodigoPeca.Location = new System.Drawing.Point(154, 85);
            this.txCodigoPeca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txCodigoPeca.Name = "txCodigoPeca";
            this.txCodigoPeca.Size = new System.Drawing.Size(144, 20);
            this.txCodigoPeca.TabIndex = 33;
            // 
            // lCodigoPeca
            // 
            this.lCodigoPeca.AutoSize = true;
            this.lCodigoPeca.Location = new System.Drawing.Point(9, 91);
            this.lCodigoPeca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCodigoPeca.Name = "lCodigoPeca";
            this.lCodigoPeca.Size = new System.Drawing.Size(83, 13);
            this.lCodigoPeca.TabIndex = 34;
            this.lCodigoPeca.Text = "Codigo da Peça";
            // 
            // lNomePeca
            // 
            this.lNomePeca.AutoSize = true;
            this.lNomePeca.Location = new System.Drawing.Point(9, 128);
            this.lNomePeca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomePeca.Name = "lNomePeca";
            this.lNomePeca.Size = new System.Drawing.Size(78, 13);
            this.lNomePeca.TabIndex = 36;
            this.lNomePeca.Text = "Nome da Peça";
            // 
            // txNomePeca
            // 
            this.txNomePeca.Location = new System.Drawing.Point(154, 123);
            this.txNomePeca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txNomePeca.Name = "txNomePeca";
            this.txNomePeca.Size = new System.Drawing.Size(144, 20);
            this.txNomePeca.TabIndex = 35;
            // 
            // lQuantidade
            // 
            this.lQuantidade.AutoSize = true;
            this.lQuantidade.Location = new System.Drawing.Point(9, 167);
            this.lQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lQuantidade.Name = "lQuantidade";
            this.lQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lQuantidade.TabIndex = 38;
            this.lQuantidade.Text = "Quantidade";
            // 
            // txQuantidade
            // 
            this.txQuantidade.Location = new System.Drawing.Point(154, 162);
            this.txQuantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txQuantidade.Name = "txQuantidade";
            this.txQuantidade.Size = new System.Drawing.Size(144, 20);
            this.txQuantidade.TabIndex = 37;
            // 
            // FormRelacaoProdutoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 391);
            this.Controls.Add(this.lQuantidade);
            this.Controls.Add(this.txQuantidade);
            this.Controls.Add(this.lNomePeca);
            this.Controls.Add(this.txNomePeca);
            this.Controls.Add(this.lCodigoPeca);
            this.Controls.Add(this.txCodigoPeca);
            this.Controls.Add(this.btVoltarOS);
            this.Controls.Add(this.lRelacaoPecasProduto);
            this.Controls.Add(this.dGVRelacaoProduto);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lNomeProduto);
            this.Controls.Add(this.txNomeProduto);
            this.Controls.Add(this.lCodigoProduto);
            this.Controls.Add(this.txProduto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRelacaoProdutoPeca";
            this.Text = "FormRelacaoProdutoPeca";
            this.Load += new System.EventHandler(this.FormRelacaoProdutoPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVRelacaoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltarOS;
        private System.Windows.Forms.Label lRelacaoPecasProduto;
        private System.Windows.Forms.DataGridView dGVRelacaoProduto;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lNomeProduto;
        private System.Windows.Forms.TextBox txNomeProduto;
        private System.Windows.Forms.Label lCodigoProduto;
        private System.Windows.Forms.TextBox txProduto;
        private System.Windows.Forms.TextBox txCodigoPeca;
        private System.Windows.Forms.Label lCodigoPeca;
        private System.Windows.Forms.Label lNomePeca;
        private System.Windows.Forms.TextBox txNomePeca;
        private System.Windows.Forms.Label lQuantidade;
        private System.Windows.Forms.TextBox txQuantidade;
    }
}