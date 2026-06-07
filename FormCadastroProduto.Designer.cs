namespace ProjetoSenac
{
    partial class FormCadastroProduto
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
            this.dGVRelacaoProduto = new System.Windows.Forms.DataGridView();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lNomeProduto = new System.Windows.Forms.Label();
            this.TXNomeProduto = new System.Windows.Forms.TextBox();
            this.lCodigoProduto = new System.Windows.Forms.Label();
            this.TXCodigoProduto = new System.Windows.Forms.TextBox();
            this.TXFabricanteProduto = new System.Windows.Forms.TextBox();
            this.lCodigoPeca = new System.Windows.Forms.Label();
            this.lNomePeca = new System.Windows.Forms.Label();
            this.TXPesoPeca = new System.Windows.Forms.TextBox();
            this.lQuantidade = new System.Windows.Forms.Label();
            this.TXAlturaPeca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXComprimentoProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVRelacaoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarOS
            // 
            this.btVoltarOS.BackColor = System.Drawing.Color.OrangeRed;
            this.btVoltarOS.ForeColor = System.Drawing.Color.White;
            this.btVoltarOS.Location = new System.Drawing.Point(629, 12);
            this.btVoltarOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVoltarOS.Name = "btVoltarOS";
            this.btVoltarOS.Size = new System.Drawing.Size(163, 66);
            this.btVoltarOS.TabIndex = 8;
            this.btVoltarOS.Text = "Tela Inicial";
            this.btVoltarOS.UseVisualStyleBackColor = false;
            this.btVoltarOS.Click += new System.EventHandler(this.btVoltarOS_Click);
            // 
            // dGVRelacaoProduto
            // 
            this.dGVRelacaoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVRelacaoProduto.Location = new System.Drawing.Point(21, 372);
            this.dGVRelacaoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dGVRelacaoProduto.Name = "dGVRelacaoProduto";
            this.dGVRelacaoProduto.RowHeadersWidth = 51;
            this.dGVRelacaoProduto.RowTemplate.Height = 24;
            this.dGVRelacaoProduto.Size = new System.Drawing.Size(1058, 250);
            this.dGVRelacaoProduto.TabIndex = 26;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCadastrar.Location = new System.Drawing.Point(205, 312);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(191, 37);
            this.btCadastrar.TabIndex = 7;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // lNomeProduto
            // 
            this.lNomeProduto.AutoSize = true;
            this.lNomeProduto.Location = new System.Drawing.Point(12, 68);
            this.lNomeProduto.Name = "lNomeProduto";
            this.lNomeProduto.Size = new System.Drawing.Size(113, 16);
            this.lNomeProduto.TabIndex = 24;
            this.lNomeProduto.Text = "Nome do Produto";
            // 
            // TXNomeProduto
            // 
            this.TXNomeProduto.Location = new System.Drawing.Point(205, 62);
            this.TXNomeProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXNomeProduto.Name = "TXNomeProduto";
            this.TXNomeProduto.Size = new System.Drawing.Size(191, 22);
            this.TXNomeProduto.TabIndex = 2;
            // 
            // lCodigoProduto
            // 
            this.lCodigoProduto.AutoSize = true;
            this.lCodigoProduto.Location = new System.Drawing.Point(12, 27);
            this.lCodigoProduto.Name = "lCodigoProduto";
            this.lCodigoProduto.Size = new System.Drawing.Size(120, 16);
            this.lCodigoProduto.TabIndex = 22;
            this.lCodigoProduto.Text = "Codigo do Produto";
            // 
            // TXCodigoProduto
            // 
            this.TXCodigoProduto.Location = new System.Drawing.Point(205, 21);
            this.TXCodigoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXCodigoProduto.Name = "TXCodigoProduto";
            this.TXCodigoProduto.Size = new System.Drawing.Size(191, 22);
            this.TXCodigoProduto.TabIndex = 1;
            // 
            // TXFabricanteProduto
            // 
            this.TXFabricanteProduto.Location = new System.Drawing.Point(205, 105);
            this.TXFabricanteProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXFabricanteProduto.Name = "TXFabricanteProduto";
            this.TXFabricanteProduto.Size = new System.Drawing.Size(191, 22);
            this.TXFabricanteProduto.TabIndex = 3;
            // 
            // lCodigoPeca
            // 
            this.lCodigoPeca.AutoSize = true;
            this.lCodigoPeca.Location = new System.Drawing.Point(12, 112);
            this.lCodigoPeca.Name = "lCodigoPeca";
            this.lCodigoPeca.Size = new System.Drawing.Size(71, 16);
            this.lCodigoPeca.TabIndex = 34;
            this.lCodigoPeca.Text = "Fabricante";
            // 
            // lNomePeca
            // 
            this.lNomePeca.AutoSize = true;
            this.lNomePeca.Location = new System.Drawing.Point(12, 158);
            this.lNomePeca.Name = "lNomePeca";
            this.lNomePeca.Size = new System.Drawing.Size(108, 16);
            this.lNomePeca.TabIndex = 36;
            this.lNomePeca.Text = "Peso do Produto";
            // 
            // TXPesoPeca
            // 
            this.TXPesoPeca.Location = new System.Drawing.Point(205, 151);
            this.TXPesoPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXPesoPeca.Name = "TXPesoPeca";
            this.TXPesoPeca.Size = new System.Drawing.Size(191, 22);
            this.TXPesoPeca.TabIndex = 4;
            // 
            // lQuantidade
            // 
            this.lQuantidade.AutoSize = true;
            this.lQuantidade.Location = new System.Drawing.Point(12, 206);
            this.lQuantidade.Name = "lQuantidade";
            this.lQuantidade.Size = new System.Drawing.Size(110, 16);
            this.lQuantidade.TabIndex = 38;
            this.lQuantidade.Text = "Altura do Produto";
            // 
            // TXAlturaPeca
            // 
            this.TXAlturaPeca.Location = new System.Drawing.Point(205, 199);
            this.TXAlturaPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXAlturaPeca.Name = "TXAlturaPeca";
            this.TXAlturaPeca.Size = new System.Drawing.Size(191, 22);
            this.TXAlturaPeca.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Comprimento Produto";
            // 
            // TXComprimentoProduto
            // 
            this.TXComprimentoProduto.Location = new System.Drawing.Point(205, 243);
            this.TXComprimentoProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXComprimentoProduto.Name = "TXComprimentoProduto";
            this.TXComprimentoProduto.Size = new System.Drawing.Size(191, 22);
            this.TXComprimentoProduto.TabIndex = 6;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXComprimentoProduto);
            this.Controls.Add(this.lQuantidade);
            this.Controls.Add(this.TXAlturaPeca);
            this.Controls.Add(this.lNomePeca);
            this.Controls.Add(this.TXPesoPeca);
            this.Controls.Add(this.lCodigoPeca);
            this.Controls.Add(this.TXFabricanteProduto);
            this.Controls.Add(this.btVoltarOS);
            this.Controls.Add(this.dGVRelacaoProduto);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lNomeProduto);
            this.Controls.Add(this.TXNomeProduto);
            this.Controls.Add(this.lCodigoProduto);
            this.Controls.Add(this.TXCodigoProduto);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastroProduto";
            this.Text = "FormCadastroProduto";
            this.Load += new System.EventHandler(this.FormRelacaoProdutoPeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVRelacaoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltarOS;
        private System.Windows.Forms.DataGridView dGVRelacaoProduto;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lNomeProduto;
        private System.Windows.Forms.TextBox TXNomeProduto;
        private System.Windows.Forms.Label lCodigoProduto;
        private System.Windows.Forms.TextBox TXCodigoProduto;
        private System.Windows.Forms.TextBox TXFabricanteProduto;
        private System.Windows.Forms.Label lCodigoPeca;
        private System.Windows.Forms.Label lNomePeca;
        private System.Windows.Forms.TextBox TXPesoPeca;
        private System.Windows.Forms.Label lQuantidade;
        private System.Windows.Forms.TextBox TXAlturaPeca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXComprimentoProduto;
    }
}