namespace ProjetoSenac
{
    partial class FormRelatorio
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
            this.btVoltarR = new System.Windows.Forms.Button();
            this.lRelacaoPecasProduto = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.btConsultar = new System.Windows.Forms.Button();
            this.lNomeProduto = new System.Windows.Forms.Label();
            this.txnomeProduto = new System.Windows.Forms.TextBox();
            this.lCodigoProduto = new System.Windows.Forms.Label();
            this.txProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarR
            // 
            this.btVoltarR.BackColor = System.Drawing.Color.OrangeRed;
            this.btVoltarR.ForeColor = System.Drawing.Color.White;
            this.btVoltarR.Location = new System.Drawing.Point(650, 45);
            this.btVoltarR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btVoltarR.Name = "btVoltarR";
            this.btVoltarR.Size = new System.Drawing.Size(122, 54);
            this.btVoltarR.TabIndex = 19;
            this.btVoltarR.Text = "Tela Inicial";
            this.btVoltarR.UseVisualStyleBackColor = false;
            this.btVoltarR.Click += new System.EventHandler(this.btVoltarR_Click);
            // 
            // lRelacaoPecasProduto
            // 
            this.lRelacaoPecasProduto.AutoSize = true;
            this.lRelacaoPecasProduto.BackColor = System.Drawing.Color.Red;
            this.lRelacaoPecasProduto.Location = new System.Drawing.Point(105, 205);
            this.lRelacaoPecasProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lRelacaoPecasProduto.Name = "lRelacaoPecasProduto";
            this.lRelacaoPecasProduto.Size = new System.Drawing.Size(211, 13);
            this.lRelacaoPecasProduto.TabIndex = 32;
            this.lRelacaoPecasProduto.Text = "Relação_LISTA de PEÇAS por PRODUTO";
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Location = new System.Drawing.Point(108, 236);
            this.dgvRelatorio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.RowHeadersWidth = 51;
            this.dgvRelatorio.RowTemplate.Height = 24;
            this.dgvRelatorio.Size = new System.Drawing.Size(448, 163);
            this.dgvRelatorio.TabIndex = 31;
            // 
            // btConsultar
            // 
            this.btConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btConsultar.Location = new System.Drawing.Point(253, 158);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(112, 30);
            this.btConsultar.TabIndex = 30;
            this.btConsultar.Text = "Consultar Produto";
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // lNomeProduto
            // 
            this.lNomeProduto.AutoSize = true;
            this.lNomeProduto.Location = new System.Drawing.Point(87, 129);
            this.lNomeProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNomeProduto.Name = "lNomeProduto";
            this.lNomeProduto.Size = new System.Drawing.Size(90, 13);
            this.lNomeProduto.TabIndex = 29;
            this.lNomeProduto.Text = "Nome do Produto";
            // 
            // txnomeProduto
            // 
            this.txnomeProduto.Location = new System.Drawing.Point(233, 124);
            this.txnomeProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txnomeProduto.Name = "txnomeProduto";
            this.txnomeProduto.Size = new System.Drawing.Size(144, 20);
            this.txnomeProduto.TabIndex = 28;
            // 
            // lCodigoProduto
            // 
            this.lCodigoProduto.AutoSize = true;
            this.lCodigoProduto.Location = new System.Drawing.Point(87, 96);
            this.lCodigoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCodigoProduto.Name = "lCodigoProduto";
            this.lCodigoProduto.Size = new System.Drawing.Size(95, 13);
            this.lCodigoProduto.TabIndex = 27;
            this.lCodigoProduto.Text = "Codigo do Produto";
            // 
            // txProduto
            // 
            this.txProduto.Location = new System.Drawing.Point(233, 91);
            this.txProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txProduto.Name = "txProduto";
            this.txProduto.Size = new System.Drawing.Size(144, 20);
            this.txProduto.TabIndex = 26;
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lRelacaoPecasProduto);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.lNomeProduto);
            this.Controls.Add(this.txnomeProduto);
            this.Controls.Add(this.lCodigoProduto);
            this.Controls.Add(this.txProduto);
            this.Controls.Add(this.btVoltarR);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.Load += new System.EventHandler(this.FormRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltarR;
        private System.Windows.Forms.Label lRelacaoPecasProduto;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Label lNomeProduto;
        private System.Windows.Forms.TextBox txnomeProduto;
        private System.Windows.Forms.Label lCodigoProduto;
        private System.Windows.Forms.TextBox txProduto;
    }
}