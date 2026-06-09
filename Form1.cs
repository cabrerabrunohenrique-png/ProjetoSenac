using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// tem que instalar o MySqlConnector
// com esse comando
using MySqlConnector;

namespace ProjetoSenac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            

            string nomeUsuario = tbNomeUsuario.Text;
            string senha = tbSenhaAcesso.Text;

            CadastroUsuario validarsenha = new CadastroUsuario();

            if(validarsenha.validarSenha(senha, nomeUsuario))
            {
               
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNomeUsuario.Clear();
                tbSenhaAcesso.Clear();

                Nav formNav = new Nav();
                formNav.Owner = this;
                this.Hide();
                formNav.Show();
            }
            else
            {
                MessageBox.Show("Nome de usuário ou senha incorretos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btCadastrarNovoUsuario_Click(object sender, EventArgs e)
        {
            //Para usar um formulario dentro de outro é necessario criar uma variavel do tipo do formulario que deseja abrir,
            CadastroNovoUsuario formCadastro = new CadastroNovoUsuario();
            //Esse código define que o formulário atual (Form1) é o proprietário do "formulariuo".
            formCadastro.Owner = this;
            //formCadastro.Show();
            //Esse código escode a tabela do formulário atual (Form1)
            //para que o usuário não possa interagir com ele enquanto o formCadastro estiver aberto.  
            this.Hide();
            //Esse código exibe outro formulario e deixa o foco para ele,
            //ou seja, o usuário só poderá interagir com o formCadastro enquanto ele estiver aberto.
            formCadastro.ShowDialog();
            // CadastroNovoUsuario formCadastro = new CadastroNovoUsuario();
            // formCadastro.ShowDialog();
            // DialogResult = DialogResult.OK;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                Nav formNav = new Nav();
            formNav.Owner = this;
        }
    }
}
