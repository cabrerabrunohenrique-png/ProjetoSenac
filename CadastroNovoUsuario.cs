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
        }

        const string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

        private void btVoltarCNU_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            DialogResult = DialogResult.OK;
            this.Owner.Show();
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = txNomeCompleto.Text;
            string numeroRegistro = txNumeroRegistro.Text;
            string nivelPermissao = txPermissao.Text;
            string nomeUsuario = txNomeUsuario.Text;
            string senhaAcesso = txSenhaAcesso.Text;

            //DateTime dateTime = DateTime.Now;


            int controleLinhasAftadas = 0;

            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";


           


            if (string.IsNullOrEmpty(nomeCompleto) || string.IsNullOrEmpty(numeroRegistro) || string.IsNullOrEmpty(nivelPermissao) || string.IsNullOrEmpty(nomeUsuario)
            || string.IsNullOrEmpty(senhaAcesso))
            {
                             
                MessageBox.Show("Todos tem que estar preenchidos", "Atenção");
                return;

            }

            else if (listaCadastroUsuario.Any(c => c.NOMECOMPLETO == nomeCompleto))
            {
                MessageBox.Show("O NOME  existe. Por favor, escolha outro.", "Atenção");
                

                txNomeCompleto.Clear();
                return;

            }


            else if (listaCadastroUsuario.Any(c => c.NOMEUSUARIO == nomeUsuario))
            {
                MessageBox.Show("O NOME DE USUARIO  já existe. Por favor, escolha outro.", "Atenção");
                    

                txNomeUsuario.Clear();
                return;

            }

            else if (listaCadastroUsuario.Any(c => c.NUMEROREGISTRO == numeroRegistro))
            {
                MessageBox.Show("o NUMERO DE REGISTRO já existe. Por favor, escolha outro.", "Atenção");


                txNumeroRegistro.Clear();
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
                    txPermissao.Clear();
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
    }
}
