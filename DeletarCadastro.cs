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
    public partial class DeletarCadastro : Form
    {
        public DeletarCadastro()
        {
            InitializeComponent();
        }

        private void button_deletar_Click(object sender, EventArgs e)
        {

        }

        private void button_voltar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente voltar para a tela de login?\nQualquer alteração não salva será perdida.",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); if (resposta == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }
    }
}
