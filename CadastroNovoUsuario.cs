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
            string dadosCadastro =
                "server=localhost; user=root; password=; database=db_senac;";
            using (MysqlConnection conn = new MysqlConnection(dadosCadastro))
            {

            }
        }
    }
}
