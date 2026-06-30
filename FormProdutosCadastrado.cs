using MySqlX.XDevAPI;
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
    public partial class FormProdutosCadastrado : Form
    {

        public FormProdutosCadastrado()
        {
            InitializeComponent();
            CadastroProduto pesquisa = new CadastroProduto();

            string nomePesquisado = TXNomeProduto.Text.Trim();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            CadastroProduto pesquisa = new CadastroProduto();
            


            string nomePesquisado = TXNomeProduto.Text.Trim();

            if (string.IsNullOrEmpty(nomePesquisado))
            {
                MessageBox.Show("Por favor, informe o nome do produto a ser pesquisado.");
                TXNomeProduto.Focus();
                return;
            }

            // funcao criada na Class do tipo LISTA
            List<CadastroProduto> resultadoBusca = pesquisa.FcPesquisaNome(nomePesquisado);

            // Se a contagem (Count) for maior que zero, significa que o produto foi encontrado!
            if (resultadoBusca.Count > 0)
            {
                // ASSOCIAÇÃO CORRETA: O DataGridView recebe a lista preenchida
                dgvPesquisa.DataSource = resultadoBusca;

                MessageBox.Show("Produto encontrado no banco de dados e exibido na tabela!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Limpa a tabela caso pesquise algo que não existe
                dgvPesquisa.DataSource = null;

                MessageBox.Show("Produto não encontrado no banco de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
    }
}   
