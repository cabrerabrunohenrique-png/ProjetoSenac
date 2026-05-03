namespace ProjetoSenac
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lNomeUsuario = new System.Windows.Forms.Label();
            this.lSenhaUsuario = new System.Windows.Forms.Label();
            this.btEntrar = new System.Windows.Forms.Button();
            this.tbNomeUsuario = new System.Windows.Forms.TextBox();
            this.tbSenhaAcesso = new System.Windows.Forms.TextBox();
            this.btCadastrarNovoUsuario = new System.Windows.Forms.Button();
            this.btAcessarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lNomeUsuario
            // 
            this.lNomeUsuario.AutoSize = true;
            this.lNomeUsuario.Location = new System.Drawing.Point(5, 163);
            this.lNomeUsuario.Name = "lNomeUsuario";
            this.lNomeUsuario.Size = new System.Drawing.Size(113, 16);
            this.lNomeUsuario.TabIndex = 0;
            this.lNomeUsuario.Text = "Nome de Usuário";
            // 
            // lSenhaUsuario
            // 
            this.lSenhaUsuario.AutoSize = true;
            this.lSenhaUsuario.Location = new System.Drawing.Point(5, 197);
            this.lSenhaUsuario.Name = "lSenhaUsuario";
            this.lSenhaUsuario.Size = new System.Drawing.Size(113, 16);
            this.lSenhaUsuario.TabIndex = 1;
            this.lSenhaUsuario.Text = "Senha de acesso";
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.Color.Lime;
            this.btEntrar.Location = new System.Drawing.Point(170, 241);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(157, 59);
            this.btEntrar.TabIndex = 5;
            this.btEntrar.Text = "Entrar";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // tbNomeUsuario
            // 
            this.tbNomeUsuario.Location = new System.Drawing.Point(140, 157);
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.Size = new System.Drawing.Size(228, 22);
            this.tbNomeUsuario.TabIndex = 6;
            // 
            // tbSenhaAcesso
            // 
            this.tbSenhaAcesso.Location = new System.Drawing.Point(140, 197);
            this.tbSenhaAcesso.Name = "tbSenhaAcesso";
            this.tbSenhaAcesso.Size = new System.Drawing.Size(228, 22);
            this.tbSenhaAcesso.TabIndex = 7;
            // 
            // btCadastrarNovoUsuario
            // 
            this.btCadastrarNovoUsuario.BackColor = System.Drawing.Color.Red;
            this.btCadastrarNovoUsuario.Location = new System.Drawing.Point(170, 21);
            this.btCadastrarNovoUsuario.Name = "btCadastrarNovoUsuario";
            this.btCadastrarNovoUsuario.Size = new System.Drawing.Size(157, 57);
            this.btCadastrarNovoUsuario.TabIndex = 8;
            this.btCadastrarNovoUsuario.Text = "Cadastrar Novo Usuário";
            this.btCadastrarNovoUsuario.UseVisualStyleBackColor = false;
            this.btCadastrarNovoUsuario.Click += new System.EventHandler(this.btCadastrarNovoUsuario_Click);
            // 
            // btAcessarRelatorios
            // 
            this.btAcessarRelatorios.BackColor = System.Drawing.Color.Yellow;
            this.btAcessarRelatorios.Location = new System.Drawing.Point(170, 382);
            this.btAcessarRelatorios.Name = "btAcessarRelatorios";
            this.btAcessarRelatorios.Size = new System.Drawing.Size(157, 65);
            this.btAcessarRelatorios.TabIndex = 9;
            this.btAcessarRelatorios.Text = "Acessar Relatórios";
            this.btAcessarRelatorios.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 459);
            this.Controls.Add(this.btAcessarRelatorios);
            this.Controls.Add(this.btCadastrarNovoUsuario);
            this.Controls.Add(this.tbSenhaAcesso);
            this.Controls.Add(this.tbNomeUsuario);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.lSenhaUsuario);
            this.Controls.Add(this.lNomeUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNomeUsuario;
        private System.Windows.Forms.Label lSenhaUsuario;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.TextBox tbNomeUsuario;
        private System.Windows.Forms.TextBox tbSenhaAcesso;
        private System.Windows.Forms.Button btCadastrarNovoUsuario;
        private System.Windows.Forms.Button btAcessarRelatorios;
    }
}

