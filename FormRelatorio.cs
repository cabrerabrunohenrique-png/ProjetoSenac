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
            /*using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAOO))
            {
                
                {
                    conn.Open();
                    string scriptConsulta = "SELECT * FROM tb_cadastronovousuario";
                    using (MySqlCommand comando = new MySqlCommand(scriptConsulta,conn))
                    {
                        var dadosResultado = comando.ExecuteNonQuery();
                        MessageBox.Show("Consulta realizada com sucesso!");
                    }
                }*/
        }
    }
}
