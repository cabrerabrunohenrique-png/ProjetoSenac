using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// tem que instalar o MySqlConnector
using MySqlConnector;

namespace ProjetoSenac
{
    public partial class CadastroNovoUsuario : Form

    {
        //Comando para criar uma lista
        //No caso eu estou criando uma lista do tipo CadastroUsuario, que é a CLASSE que
        //eu criei para receber os dados do banco de dados
        BindingList<CadastroUsuario> listaCadastroUsuario = new BindingList<CadastroUsuario>();


        public CadastroNovoUsuario()
        {
            InitializeComponent();

            cbNivelPermisao.Items.Add("Administrador");
            cbNivelPermisao.Items.Add("Usuário Comum");
            cbNivelPermisao.Items.Add("Usuário Restrito");

        }

        const string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

        private void btVoltarCNU_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            //DialogResult = DialogResult.OK;
            DialogResult resposta = MessageBox.Show("Deseja realmente voltar para a tela de login?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCompletoSem = txNomeCompleto.Text;
            string nomeCompleto = nomeCompletoSem.Trim();
            string numeroRegistro = txNumeroRegistro.Text;
            string nivelPermissao = cbNivelPermisao.Text;
            
            string nomeUsuarioSem = txNomeUsuario.Text;
            string nomeUsuario = nomeUsuarioSem.Trim();
            string senhaAcesso = txSenhaAcesso.Text;

            //DateTime dateTime = DateTime.Now;


            int controleLinhasAftadas = 0;

            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

                       
            if (nomeCompleto.Length < 5)
            {
                MessageBox.Show("Digite o nome completo","NOME COMPLETO");

                return;
            }

            if (nomeCompleto.Length > 50)
            {
                MessageBox.Show("O nome completo deve ter no máximo 50 caracteres", "ATENÇÃO");
                return;
            }

            if (nomeCompleto.Split(' ').Length <2)
            {

                MessageBox.Show("O nome completo deve conter pelo menos um sobrenome", "ATENÇÃO");
                return;
            }

           

            char[] nomeComletoLetra = nomeCompleto.ToCharArray();

            if (nomeComletoLetra.Any(c => char.IsDigit(c)))

            {
                MessageBox.Show("Você não pode usar números no nome completo", "ATENÇÃO");

                return;
            
            }

            char[] nomeComEspecial = nomeCompleto.ToCharArray();

            if (nomeComEspecial.Any(c => char.IsPunctuation(c) || char.IsSymbol(c)))
            {
                MessageBox.Show("Seu nome tem caracteres inválidos", "ATENÇÃO");
                return;
            }

            char[] numeroValidado = numeroRegistro.ToCharArray();

            if (numeroValidado.Any(c => char.IsPunctuation(c) || char.IsSymbol(c) || char.IsLetter(c)))
            {
                MessageBox.Show("Só PODE NUMERO", "ATENÇÃO");
                txNumeroRegistro.Clear();
                return;
            }

            if (numeroRegistro.Length >10 )
            {
                MessageBox.Show(" Numero nao pode ter menos que 3 casas decimais e nao pode ter mais que 5 casas ", "ATENÇÃO");
                txNumeroRegistro.Clear();
                return;
            }

            
            
            if (nomeUsuario.Length >10)
            {
                MessageBox.Show("Nome de usuário nao pode ser maior que 10 caracteres", "ATENÇÃO");
                txNomeUsuario.Clear();
                return;
            }


            if (string.IsNullOrEmpty(nomeCompleto) || string.IsNullOrEmpty(numeroRegistro) || string.IsNullOrEmpty(nivelPermissao) || string.IsNullOrEmpty(nomeUsuario)
            || string.IsNullOrEmpty(senhaAcesso))
            {
                             
                MessageBox.Show("Todos tem que estar preenchidos", "ATENÇÃO");
                return;

            }

            if (listaCadastroUsuario.Any(c => c.NOMECOMPLETO == nomeCompleto))
            {
                MessageBox.Show("O NOME COMPLETO" + nomeCompleto + " já existe. Por favor, escolha outro.", "ATENÇÃO");
                

                txNomeCompleto.Clear();
                return;
            }

            if (listaCadastroUsuario.Any(c => c.NUMEROREGISTRO == numeroRegistro))
            {
                MessageBox.Show("o NUMERO DE REGISTRO"+ numeroRegistro + " já existe. Por favor, escolha outro.", "ATENÇÃO");


                txNumeroRegistro.Clear();
                return;

            }

            if (listaCadastroUsuario.Any(c => c.NOMEUSUARIO == nomeUsuario))
            {
                MessageBox.Show("O NOME DE USUARIO" + nomeUsuario + " já existe. Por favor, escolha outro.", "ATENÇÃO");
                    

                txNomeUsuario.Clear();
                return;

            }
            


                else
                {
                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                    conn.Open();
                    // tem que colocar esse comando para conecatar com o banco criado
                    //value @---serve para passar o valor do campo do formulario para o banco de dados
                    string scriptInsert = "INSERT INTO tbcadastronovousuario " +
                        "(nomeCompleto,numeroRegistro,nivelPermissao,nomeUsuario,senhaAcesso)" +
                        " VALUE(@nomeCompleto,@numeroRegistro,@nivelPermissao,@nomeUsuario,@senhaAcesso)";


                    using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                    {
                        comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);
                        comando.Parameters.AddWithValue("@numeroRegistro", numeroRegistro);
                        comando.Parameters.AddWithValue("@nivelPermissao", nivelPermissao);
                        comando.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                        comando.Parameters.AddWithValue("@senhaAcesso", senhaAcesso);


                        controleLinhasAftadas = comando.ExecuteNonQuery();
                    }

                    CadastroUsuario cadastroUsuario = new CadastroUsuario();
                    cadastroUsuario.NOMECOMPLETO = nomeCompleto;
                    cadastroUsuario.NUMEROREGISTRO = numeroRegistro;
                    cadastroUsuario.NIVELPERMISSAO = nivelPermissao;
                    cadastroUsuario.NOMEUSUARIO = nomeUsuario;
                    cadastroUsuario.SENHAACESSO = senhaAcesso;
                    listaCadastroUsuario.Add(cadastroUsuario);


                    MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro Realizado");

                    txNomeCompleto.Clear();
                    txNumeroRegistro.Clear();
                    cbNivelPermisao.SelectedIndex = -1;
                    txNomeUsuario.Clear();
                    txSenhaAcesso.Clear();
                    txConfirmacaoSenha.Clear();
                    conn.Close();

                }
            }
        }
        /*if (controleLinhasAftadas > 0){MessageBox.Show("Cadastro realizado com sucesso!");}*/


        private void lNomeCompleto_Click(object sender, EventArgs e)
        {

        }

        private void CadastroNovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void txSenhaAcesso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
