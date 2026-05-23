namespace ProjetoSenac
{
    partial class CadastroNovoUsuario
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
            this.txNomeCompleto = new System.Windows.Forms.TextBox();
            this.txNumeroRegistro = new System.Windows.Forms.TextBox();
            this.txNomeUsuario = new System.Windows.Forms.TextBox();
            this.txSenhaAcesso = new System.Windows.Forms.TextBox();
            this.lNomeCompleto = new System.Windows.Forms.Label();
            this.lNumeroRegistro = new System.Windows.Forms.Label();
            this.lNivelPermissao = new System.Windows.Forms.Label();
            this.lNomeUsuario = new System.Windows.Forms.Label();
            this.lSenhaAcesso = new System.Windows.Forms.Label();
            this.lConfirmacaoSenha = new System.Windows.Forms.Label();
            this.txConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btVoltarCNU = new System.Windows.Forms.Button();
            this.cbNivelPermisao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txNomeCompleto
            // 
            this.txNomeCompleto.Location = new System.Drawing.Point(271, 95);
            this.txNomeCompleto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNomeCompleto.Name = "txNomeCompleto";
            this.txNomeCompleto.Size = new System.Drawing.Size(324, 22);
            this.txNomeCompleto.TabIndex = 0;
            this.txNomeCompleto.TextChanged += new System.EventHandler(this.txNomeCompleto_TextChanged);
            // 
            // txNumeroRegistro
            // 
            this.txNumeroRegistro.Location = new System.Drawing.Point(271, 143);
            this.txNumeroRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNumeroRegistro.Name = "txNumeroRegistro";
            this.txNumeroRegistro.Size = new System.Drawing.Size(324, 22);
            this.txNumeroRegistro.TabIndex = 1;
            // 
            // txNomeUsuario
            // 
            this.txNomeUsuario.Location = new System.Drawing.Point(271, 241);
            this.txNomeUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txNomeUsuario.Name = "txNomeUsuario";
            this.txNomeUsuario.Size = new System.Drawing.Size(324, 22);
            this.txNomeUsuario.TabIndex = 3;
            // 
            // txSenhaAcesso
            // 
            this.txSenhaAcesso.Location = new System.Drawing.Point(271, 289);
            this.txSenhaAcesso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txSenhaAcesso.Name = "txSenhaAcesso";
            this.txSenhaAcesso.Size = new System.Drawing.Size(324, 22);
            this.txSenhaAcesso.TabIndex = 4;
            this.txSenhaAcesso.TextChanged += new System.EventHandler(this.txSenhaAcesso_TextChanged);
            // 
            // lNomeCompleto
            // 
            this.lNomeCompleto.AutoSize = true;
            this.lNomeCompleto.Location = new System.Drawing.Point(63, 95);
            this.lNomeCompleto.Name = "lNomeCompleto";
            this.lNomeCompleto.Size = new System.Drawing.Size(105, 16);
            this.lNomeCompleto.TabIndex = 10;
            this.lNomeCompleto.Text = "Nome Completo";
            this.lNomeCompleto.Click += new System.EventHandler(this.lNomeCompleto_Click);
            // 
            // lNumeroRegistro
            // 
            this.lNumeroRegistro.AutoSize = true;
            this.lNumeroRegistro.Location = new System.Drawing.Point(63, 143);
            this.lNumeroRegistro.Name = "lNumeroRegistro";
            this.lNumeroRegistro.Size = new System.Drawing.Size(128, 16);
            this.lNumeroRegistro.TabIndex = 11;
            this.lNumeroRegistro.Text = "Numero de Registro";
            // 
            // lNivelPermissao
            // 
            this.lNivelPermissao.AutoSize = true;
            this.lNivelPermissao.Location = new System.Drawing.Point(63, 194);
            this.lNivelPermissao.Name = "lNivelPermissao";
            this.lNivelPermissao.Size = new System.Drawing.Size(125, 16);
            this.lNivelPermissao.TabIndex = 12;
            this.lNivelPermissao.Text = "Nivel de Permissão";
            // 
            // lNomeUsuario
            // 
            this.lNomeUsuario.AutoSize = true;
            this.lNomeUsuario.Location = new System.Drawing.Point(63, 247);
            this.lNomeUsuario.Name = "lNomeUsuario";
            this.lNomeUsuario.Size = new System.Drawing.Size(110, 16);
            this.lNomeUsuario.TabIndex = 13;
            this.lNomeUsuario.Text = "Nome de usuário";
            // 
            // lSenhaAcesso
            // 
            this.lSenhaAcesso.AutoSize = true;
            this.lSenhaAcesso.Location = new System.Drawing.Point(63, 295);
            this.lSenhaAcesso.Name = "lSenhaAcesso";
            this.lSenhaAcesso.Size = new System.Drawing.Size(114, 16);
            this.lSenhaAcesso.TabIndex = 14;
            this.lSenhaAcesso.Text = "Senha de Acesso";
            // 
            // lConfirmacaoSenha
            // 
            this.lConfirmacaoSenha.AutoSize = true;
            this.lConfirmacaoSenha.Location = new System.Drawing.Point(63, 343);
            this.lConfirmacaoSenha.Name = "lConfirmacaoSenha";
            this.lConfirmacaoSenha.Size = new System.Drawing.Size(193, 16);
            this.lConfirmacaoSenha.TabIndex = 15;
            this.lConfirmacaoSenha.Text = "Confirmacao Senha de Acesso";
            // 
            // txConfirmacaoSenha
            // 
            this.txConfirmacaoSenha.Location = new System.Drawing.Point(271, 337);
            this.txConfirmacaoSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txConfirmacaoSenha.Name = "txConfirmacaoSenha";
            this.txConfirmacaoSenha.Size = new System.Drawing.Size(324, 22);
            this.txConfirmacaoSenha.TabIndex = 5;
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btCadastrar.Location = new System.Drawing.Point(280, 384);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(199, 39);
            this.btCadastrar.TabIndex = 6;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btVoltarCNU
            // 
            this.btVoltarCNU.BackColor = System.Drawing.Color.Blue;
            this.btVoltarCNU.ForeColor = System.Drawing.Color.White;
            this.btVoltarCNU.Location = new System.Drawing.Point(635, 25);
            this.btVoltarCNU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btVoltarCNU.Name = "btVoltarCNU";
            this.btVoltarCNU.Size = new System.Drawing.Size(137, 66);
            this.btVoltarCNU.TabIndex = 13;
            this.btVoltarCNU.Text = "Tela Inicial";
            this.btVoltarCNU.UseVisualStyleBackColor = false;
            this.btVoltarCNU.Click += new System.EventHandler(this.btVoltarCNU_Click);
            // 
            // cbNivelPermisao
            // 
            this.cbNivelPermisao.FormattingEnabled = true;
            this.cbNivelPermisao.Location = new System.Drawing.Point(271, 191);
            this.cbNivelPermisao.MaxDropDownItems = 2;
            this.cbNivelPermisao.Name = "cbNivelPermisao";
            this.cbNivelPermisao.Size = new System.Drawing.Size(324, 24);
            this.cbNivelPermisao.TabIndex = 14;
            // 
            // CadastroNovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbNivelPermisao);
            this.Controls.Add(this.txNomeCompleto);
            this.Controls.Add(this.btVoltarCNU);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lConfirmacaoSenha);
            this.Controls.Add(this.txConfirmacaoSenha);
            this.Controls.Add(this.lSenhaAcesso);
            this.Controls.Add(this.lNomeUsuario);
            this.Controls.Add(this.lNivelPermissao);
            this.Controls.Add(this.lNumeroRegistro);
            this.Controls.Add(this.lNomeCompleto);
            this.Controls.Add(this.txSenhaAcesso);
            this.Controls.Add(this.txNomeUsuario);
            this.Controls.Add(this.txNumeroRegistro);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CadastroNovoUsuario";
            this.Text = "CadastroNovoUsuario";
            this.Load += new System.EventHandler(this.CadastroNovoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNomeCompleto;
        private System.Windows.Forms.TextBox txNumeroRegistro;
        private System.Windows.Forms.TextBox txNomeUsuario;
        private System.Windows.Forms.TextBox txSenhaAcesso;
        private System.Windows.Forms.Label lNomeCompleto;
        private System.Windows.Forms.Label lNumeroRegistro;
        private System.Windows.Forms.Label lNivelPermissao;
        private System.Windows.Forms.Label lNomeUsuario;
        private System.Windows.Forms.Label lSenhaAcesso;
        private System.Windows.Forms.Label lConfirmacaoSenha;
        private System.Windows.Forms.TextBox txConfirmacaoSenha;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btVoltarCNU;
        private System.Windows.Forms.ComboBox cbNivelPermisao;
    }
}