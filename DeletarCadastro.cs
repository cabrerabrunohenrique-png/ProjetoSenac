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
           
            string nomeCompleto = txNomeCompleto.Text.Trim();
            string nomeUsuario = txNomeUsuario.Text.Trim();

            CadastroUsuario cadastroUsuario = new CadastroUsuario();

            bool resultado = cadastroUsuario.FcExcluir(nomeCompleto, nomeUsuario);

            if (resultado)
            {
                MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Falha ao excluir o usuário. Verifique se os dados estão corretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txNomeCompleto.Clear();
            txNomeUsuario.Clear();
            txNomeCompleto.Focus();
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
