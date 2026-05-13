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

            string DADOS_CONEXAO =
                "server=localhost; user=root; password=; database=bdprojetosenac;";

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

                
                conn.Close();

            }

            if (controleLinhasAftadas > 0)
            {
                txNomeCompleto.Clear();
                txNumeroRegistro.Clear();
                txPermissao.Clear();
                txNomeUsuario.Clear();
                txSenhaAcesso.Clear();


                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao realizar cadastro.");


            }

            
        }

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
