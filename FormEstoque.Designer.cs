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
            this.components = new System.ComponentModel.Container();
            this.btVoltarE = new System.Windows.Forms.Button();
            this.btCadastrarEntrada = new System.Windows.Forms.Button();
            this.lNomePeca = new System.Windows.Forms.Label();
            this.txNomePeca = new System.Windows.Forms.TextBox();
            this.lCodigoPeca = new System.Windows.Forms.Label();
            this.lDataEntradaPeca = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lQuantidadePeca = new System.Windows.Forms.Label();
            this.txQuantidadePeca = new System.Windows.Forms.TextBox();
            this.lNfPeca = new System.Windows.Forms.Label();
            this.txNfPeca = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_CodigoProduto = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip7 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip8 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView_Quantidade = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltarE
            // 
            this.btVoltarE.BackColor = System.Drawing.Color.RoyalBlue;
            this.btVoltarE.ForeColor = System.Drawing.Color.White;
            this.btVoltarE.Location = new System.Drawing.Point(1542, 7);
            this.btVoltarE.Name = "btVoltarE";
            this.btVoltarE.Size = new System.Drawing.Size(163, 67);
            this.btVoltarE.TabIndex = 19;
            this.btVoltarE.Text = "Tela Inicial";
            this.btVoltarE.UseVisualStyleBackColor = false;
            this.btVoltarE.Click += new System.EventHandler(this.btVoltarE_Click);
            // 
            // btCadastrarEntrada
            // 
            this.btCadastrarEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCadastrarEntrada.Location = new System.Drawing.Point(510, 216);
            this.btCadastrarEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadastrarEntrada.Name = "btCadastrarEntrada";
            this.btCadastrarEntrada.Size = new System.Drawing.Size(201, 71);
            this.btCadastrarEntrada.TabIndex = 6;
            this.btCadastrarEntrada.Text = "Finalizar Entrada Estoque";
            this.btCadastrarEntrada.UseVisualStyleBackColor = false;
            this.btCadastrarEntrada.Click += new System.EventHandler(this.btCadastrarEntrada_Click);
            // 
            // lNomePeca
            // 
            this.lNomePeca.AutoSize = true;
            this.lNomePeca.Location = new System.Drawing.Point(321, 92);
            this.lNomePeca.Name = "lNomePeca";
            this.lNomePeca.Size = new System.Drawing.Size(98, 16);
            this.lNomePeca.TabIndex = 29;
            this.lNomePeca.Text = "Nome da Peça";
            // 
            // txNomePeca
            // 
            this.txNomePeca.Location = new System.Drawing.Point(464, 85);
            this.txNomePeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNomePeca.Name = "txNomePeca";
            this.txNomePeca.Size = new System.Drawing.Size(332, 22);
            this.txNomePeca.TabIndex = 3;
            // 
            // lCodigoPeca
            // 
            this.lCodigoPeca.AutoSize = true;
            this.lCodigoPeca.Location = new System.Drawing.Point(321, 51);
            this.lCodigoPeca.Name = "lCodigoPeca";
            this.lCodigoPeca.Size = new System.Drawing.Size(105, 16);
            this.lCodigoPeca.TabIndex = 27;
            this.lCodigoPeca.Text = "Codigo da Peça";
            // 
            // lDataEntradaPeca
            // 
            this.lDataEntradaPeca.AutoSize = true;
            this.lDataEntradaPeca.Location = new System.Drawing.Point(32, 7);
            this.lDataEntradaPeca.Name = "lDataEntradaPeca";
            this.lDataEntradaPeca.Size = new System.Drawing.Size(121, 16);
            this.lDataEntradaPeca.TabIndex = 25;
            this.lDataEntradaPeca.Text = "Data Entrada Peca";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // lQuantidadePeca
            // 
            this.lQuantidadePeca.AutoSize = true;
            this.lQuantidadePeca.Location = new System.Drawing.Point(321, 130);
            this.lQuantidadePeca.Name = "lQuantidadePeca";
            this.lQuantidadePeca.Size = new System.Drawing.Size(112, 16);
            this.lQuantidadePeca.TabIndex = 41;
            this.lQuantidadePeca.Text = "Quantidade Peça";
            this.toolTip1.SetToolTip(this.lQuantidadePeca, "Atenção: Insira apenas números (ex: 1, 5, 10).");
            // 
            // txQuantidadePeca
            // 
            this.txQuantidadePeca.Location = new System.Drawing.Point(464, 123);
            this.txQuantidadePeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txQuantidadePeca.Name = "txQuantidadePeca";
            this.txQuantidadePeca.Size = new System.Drawing.Size(332, 22);
            this.txQuantidadePeca.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txQuantidadePeca, "Este campo aceita apenas números. Letras e símbolos serão recusados.");
            // 
            // lNfPeca
            // 
            this.lNfPeca.AutoSize = true;
            this.lNfPeca.Location = new System.Drawing.Point(321, 170);
            this.lNfPeca.Name = "lNfPeca";
            this.lNfPeca.Size = new System.Drawing.Size(79, 16);
            this.lNfPeca.TabIndex = 43;
            this.lNfPeca.Text = "Numero NF ";
            this.toolTip1.SetToolTip(this.lNfPeca, "Atenção: Insira apenas números (ex: 1, 5, 10).");
            // 
            // txNfPeca
            // 
            this.txNfPeca.Location = new System.Drawing.Point(464, 163);
            this.txNfPeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNfPeca.Name = "txNfPeca";
            this.txNfPeca.Size = new System.Drawing.Size(332, 22);
            this.txNfPeca.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txNfPeca, "Este campo aceita apenas números. Letras e símbolos serão recusados.");
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 211);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox_CodigoProduto
            // 
            this.comboBox_CodigoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_CodigoProduto.FormattingEnabled = true;
            this.comboBox_CodigoProduto.Location = new System.Drawing.Point(464, 43);
            this.comboBox_CodigoProduto.Name = "comboBox_CodigoProduto";
            this.comboBox_CodigoProduto.Size = new System.Drawing.Size(332, 24);
            this.comboBox_CodigoProduto.TabIndex = 2;
            // 
            // dataGridView_Quantidade
            // 
            this.dataGridView_Quantidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Quantidade.Location = new System.Drawing.Point(1113, 314);
            this.dataGridView_Quantidade.Name = "dataGridView_Quantidade";
            this.dataGridView_Quantidade.RowHeadersWidth = 51;
            this.dataGridView_Quantidade.RowTemplate.Height = 24;
            this.dataGridView_Quantidade.Size = new System.Drawing.Size(592, 211);
            this.dataGridView_Quantidade.TabIndex = 45;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1732, 639);
            this.Controls.Add(this.dataGridView_Quantidade);
            this.Controls.Add(this.comboBox_CodigoProduto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lNfPeca);
            this.Controls.Add(this.txNfPeca);
            this.Controls.Add(this.lQuantidadePeca);
            this.Controls.Add(this.txQuantidadePeca);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btCadastrarEntrada);
            this.Controls.Add(this.lNomePeca);
            this.Controls.Add(this.txNomePeca);
            this.Controls.Add(this.lCodigoPeca);
            this.Controls.Add(this.lDataEntradaPeca);
            this.Controls.Add(this.btVoltarE);
            this.Name = "FormEstoque";
            this.Text = "FormEstoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btVoltarE;
        private System.Windows.Forms.Button btCadastrarEntrada;
        private System.Windows.Forms.Label lNomePeca;
        private System.Windows.Forms.TextBox txNomePeca;
        private System.Windows.Forms.Label lCodigoPeca;
        private System.Windows.Forms.Label lDataEntradaPeca;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lQuantidadePeca;
        private System.Windows.Forms.TextBox txQuantidadePeca;
        private System.Windows.Forms.Label lNfPeca;
        private System.Windows.Forms.TextBox txNfPeca;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_CodigoProduto;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.ToolTip toolTip7;
        private System.Windows.Forms.ToolTip toolTip8;
        private System.Windows.Forms.DataGridView dataGridView_Quantidade;
    }
}