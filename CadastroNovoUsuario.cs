using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSenac
{
    public partial class CadastroNovoUsuario : Form
    {
        public CadastroNovoUsuario()
        {
            InitializeComponent();
        }

        private void btVoltarCNU_Click(object sender, EventArgs e)
        {
            Form1 formLogin = new Form1();
            DialogResult = DialogResult.OK;
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = txNomeCompleto.Text;
            int controleLinhasAftadas = 0;

            string dadosCadastro =
                "server=localhost; user=root; password=; database=bd_projetosenac;";

            using (MySqlConnection conn = new MySqlConnection(dadosCadastro))
            {
                conn.Open();
                // tem que colocar esse comando para conecatar com o banco criado
                //value @---serve para passar o valor do campo do formulario para o banco de dados
                string scriptInsert = "INSERT INTO tb_cadastronovousuario (nomeCompleto) VALUE(@nomeCompleto)";


                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);

                    controleLinhasAftadas = comando.ExecuteNonQuery();
                        
                }

                conn.Close();

            }

            if (controleLinhasAftadas > 0)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao realizar cadastro.");


            }
        }
    }
}
