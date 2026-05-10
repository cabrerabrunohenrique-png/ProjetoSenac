namespace ProjetoSenac
{
    partial class FormOrdemServico
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
            this.txOS = new System.Windows.Forms.TextBox();
            this.lCodigoOS = new System.Windows.Forms.Label();
            this.lCodigoProduto = new System.Windows.Forms.Label();
            this.txProduto = new System.Windows.Forms.TextBox();
            this.lNomeProduto = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btValidarOS = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lRelacaoPecasProduto = new System.Windows.Forms.Label();
            this.btVoltarOS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txOS
            // 
            this.txOS.Location = new System.Drawing.Point(197, 37);
            this.txOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txOS.Name = "txOS";
            this.txOS.Size = new System.Drawing.Size(191, 22);
            this.txOS.TabIndex = 0;
            // 
            // lCodigoOS
            // 
            this.lCodigoOS.AutoSize = true;
            this.lCodigoOS.Location = new System.Drawing.Point(3, 43);
            this.lCodigoOS.Name = "lCodigoOS";
            this.lCodigoOS.Size = new System.Drawing.Size(190, 16);
            this.lCodigoOS.TabIndex = 1;
            this.lCodigoOS.Text = "Codigo Ordem de Serviço(OS)";
            // 
            // lCodigoProduto
            // 
            this.lCodigoProduto.AutoSize = true;
            this.lCodigoProduto.Location = new System.Drawing.Point(3, 80);
            this.lCodigoProduto.Name = "lCodigoProduto";
            this.lCodigoProduto.Size = new System.Drawing.Size(120, 16);
            this.lCodigoProduto.TabIndex = 3;
            this.lCodigoProduto.Text = "Codigo do Produto";
            this.lCodigoProduto.Click += new System.EventHandler(this.label2_Click);
            // 
            // txProduto
            // 
            this.txProduto.Location = new System.Drawing.Point(197, 74);
            this.txProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txProduto.Name = "txProduto";
            this.txProduto.Size = new System.Drawing.Size(191, 22);
            this.txProduto.TabIndex = 2;
            // 
            // lNomeProduto
            // 
            this.lNomeProduto.AutoSize = true;
            this.lNomeProduto.Location = new System.Drawing.Point(3, 121);
            this.lNomeProduto.Name = "lNomeProduto";
            this.lNomeProduto.Size = new System.Drawing.Size(113, 16);
            this.lNomeProduto.TabIndex = 5;
            this.lNomeProduto.Text = "Nome do Produto";
            this.lNomeProduto.Click += new System.EventHandler(this.lNomeProduto_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(197, 114);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 22);
            this.textBox3.TabIndex = 4;
            // 
            // btValidarOS
            // 
            this.btValidarOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btValidarOS.Location = new System.Drawing.Point(224, 156);
            this.btValidarOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btValidarOS.Name = "btValidarOS";
            this.btValidarOS.Size = new System.Drawing.Size(149, 37);
            this.btValidarOS.TabIndex = 6;
            this.btValidarOS.Text = "Validar OS";
            this.btValidarOS.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 252);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 153);
            this.dataGridView1.TabIndex = 7;
            // 
            // lRelacaoPecasProduto
            // 
            this.lRelacaoPecasProduto.AutoSize = true;
            this.lRelacaoPecasProduto.BackColor = System.Drawing.Color.Red;
            this.lRelacaoPecasProduto.Location = new System.Drawing.Point(28, 233);
            this.lRelacaoPecasProduto.Name = "lRelacaoPecasProduto";
            this.lRelacaoPecasProduto.Size = new System.Drawing.Size(264, 16);
            this.lRelacaoPecasProduto.TabIndex = 8;
            this.lRelacaoPecasProduto.Text = "Relação_LISTA de PEÇAS por PRODUTO";
            // 
            // btVoltarOS
            // 
            this.btVoltarOS.BackColor = System.Drawing.Color.OrangeRed;
            this.btVoltarOS.ForeColor = System.Drawing.Color.White;
            this.btVoltarOS.Location = new System.Drawing.Point(625, 12);
            this.btVoltarOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVoltarOS.Name = "btVoltarOS";
            this.btVoltarOS.Size = new System.Drawing.Size(163, 66);
            this.btVoltarOS.TabIndex = 14;
            this.btVoltarOS.Text = "Tela Inicial";
            this.btVoltarOS.UseVisualStyleBackColor = false;
            this.btVoltarOS.Click += new System.EventHandler(this.btVoltarOS_Click);
            // 
            // FormOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 450);
            this.Controls.Add(this.btVoltarOS);
            this.Controls.Add(this.lRelacaoPecasProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btValidarOS);
            this.Controls.Add(this.lNomeProduto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lCodigoProduto);
            this.Controls.Add(this.txProduto);
            this.Controls.Add(this.lCodigoOS);
            this.Controls.Add(this.txOS);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormOrdemServico";
            this.Text = "FormOrdemServico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txOS;
        private System.Windows.Forms.Label lCodigoOS;
        private System.Windows.Forms.Label lCodigoProduto;
        private System.Windows.Forms.TextBox txProduto;
        private System.Windows.Forms.Label lNomeProduto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btValidarOS;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lRelacaoPecasProduto;
        private System.Windows.Forms.Button btVoltarOS;
    }
}