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
    public partial class FormRelatorio : Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAOO))
            {

                {
                    conn.Open();
                    string scriptConsulta = "SELECT * FROM tb_cadastronovousuario";
                    using (MySqlCommand comando = new MySqlCommand(scriptConsulta, conn))
                    {
                        comando.Parameters.AddWithValue("@nome", tbNome.Text);



                        var dadosResultado = comando.ExecuteNonQuery();
                        MessageBox.Show("Consulta realizada com sucesso!");
                    }
                }
                conn.Close();
            }
        }

        private void btPaginaLoginR_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scripetConsulta = "SELECT * FROM tb_cadastronovousuario";

                using (MySqlCommand comando = new MySqlCommand(scripetConsulta, conn))
                {
                    MySqlDataAdapter resultadoConsultaMysql = new MySqlDataAdapter(comando);
                    
                    DataTable dt = new DataTable();

                    resultadoConsultaMysql.Fill(dt);
                    
                    dgvRelatorio.DataSource = dt;


                }
                conn.Close();
            } 
                            
        }
    }

}
