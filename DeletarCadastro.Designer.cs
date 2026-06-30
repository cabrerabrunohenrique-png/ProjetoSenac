namespace ProjetoSenac
{
    partial class DeletarCadastro
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
            this.button_deletar = new System.Windows.Forms.Button();
            this.txNomeCompleto = new System.Windows.Forms.TextBox();
            this.button_voltar = new System.Windows.Forms.Button();
            this.lNomeUsuario = new System.Windows.Forms.Label();
            this.lNomeCompleto = new System.Windows.Forms.Label();
            this.txNomeUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_deletar
            // 
            this.button_deletar.BackColor = System.Drawing.Color.Red;
            this.button_deletar.Location = new System.Drawing.Point(281, 301);
            this.button_deletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_deletar.Name = "button_deletar";
            this.button_deletar.Size = new System.Drawing.Size(199, 39);
            this.button_deletar.TabIndex = 46;
            this.button_deletar.Text = "Deletar";
            this.button_deletar.UseVisualStyleBackColor = false;
            this.button_deletar.Click += new System.EventHandler(this.button_deletar_Click);
            // 
            // txNomeCompleto
            // 
            this.txNomeCompleto.Location = new System.Drawing.Point(210, 107);
            this.txNomeCompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNomeCompleto.Name = "txNomeCompleto";
            this.txNomeCompleto.Size = new System.Drawing.Size(324, 22);
            this.txNomeCompleto.TabIndex = 32;
            // 
            // button_voltar
            // 
            this.button_voltar.BackColor = System.Drawing.Color.RoyalBlue;
            this.button_voltar.ForeColor = System.Drawing.Color.White;
            this.button_voltar.Location = new System.Drawing.Point(609, 24);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(137, 66);
            this.button_voltar.TabIndex = 39;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = false;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // lNomeUsuario
            // 
            this.lNomeUsuario.AutoSize = true;
            this.lNomeUsuario.Location = new System.Drawing.Point(2, 215);
            this.lNomeUsuario.Name = "lNomeUsuario";
            this.lNomeUsuario.Size = new System.Drawing.Size(110, 16);
            this.lNomeUsuario.TabIndex = 43;
            this.lNomeUsuario.Text = "Nome de usuário";
            // 
            // lNomeCompleto
            // 
            this.lNomeCompleto.AutoSize = true;
            this.lNomeCompleto.Location = new System.Drawing.Point(2, 107);
            this.lNomeCompleto.Name = "lNomeCompleto";
            this.lNomeCompleto.Size = new System.Drawing.Size(105, 16);
            this.lNomeCompleto.TabIndex = 40;
            this.lNomeCompleto.Text = "Nome Completo";
            // 
            // txNomeUsuario
            // 
            this.txNomeUsuario.Location = new System.Drawing.Point(210, 209);
            this.txNomeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNomeUsuario.Name = "txNomeUsuario";
            this.txNomeUsuario.Size = new System.Drawing.Size(324, 22);
            this.txNomeUsuario.TabIndex = 35;
            // 
            // DeletarCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 554);
            this.Controls.Add(this.button_deletar);
            this.Controls.Add(this.txNomeCompleto);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.lNomeUsuario);
            this.Controls.Add(this.lNomeCompleto);
            this.Controls.Add(this.txNomeUsuario);
            this.Name = "DeletarCadastro";
            this.Text = "DeletarCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_deletar;
        private System.Windows.Forms.TextBox txNomeCompleto;
        private System.Windows.Forms.Button button_voltar;
        private System.Windows.Forms.Label lNomeUsuario;
        private System.Windows.Forms.Label lNomeCompleto;
        private System.Windows.Forms.TextBox txNomeUsuario;
    }
}