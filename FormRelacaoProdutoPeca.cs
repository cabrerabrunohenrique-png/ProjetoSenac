using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySqlConnector;

namespace ProjetoSenac
{
    public partial class FormRelacaoProdutoPeca : Form
    {
        BindingList<RelacaoProdutoPeca> listaRelacaoProdutoPeca = new BindingList<RelacaoProdutoPeca>();

        public FormRelacaoProdutoPeca()
        {
            InitializeComponent();
        }



            private void btVoltarOS_Click(object sender, EventArgs e)
            {

             DialogResult resposta = MessageBox.Show("Deseja realmente voltar para a tela de login?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (resposta == DialogResult.Yes)
             {
                this.Owner.Show();
                this.Close();
             }


                //this.Owner.Show();
                //this.Close();   


                /*FormRelacaoProdutoPeca formRelacaoProdutoPeca = new FormRelacaoProdutoPeca();
                Nav formNav = new Nav();
                formNav.Owner = this;
                // Quando o formRelacaoProdutoPeca fechar, executa o código para mostrar este form de novo
                formRelacaoProdutoPeca.FormClosed += (s, args) => this.Show();
                this.Show();*/

            }

        private void FormRelacaoProdutoPeca_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            string codigoProduto =txProduto.Text;
            string nomeProduto = txNomeProduto.Text;
            string codigoPeca = txCodigoPeca.Text;
            string nomePeca = txNomePeca.Text;
            string quantidade = txQuantidade.Text;


            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

            if(string.IsNullOrEmpty(codigoPeca) || string.IsNullOrEmpty(nomeProduto) 
                || string.IsNullOrEmpty(codigoPeca) || string.IsNullOrEmpty(nomePeca)
                || string.IsNullOrEmpty(quantidade))          
            {
                MessageBox.Show("Todos os campos tem que estar preenchidos", "Atenção");
            }

            else if (listaRelacaoProdutoPeca.Any(c => c.CODIGOPRODUTO ==codigoProduto ) )
            {
                MessageBox.Show("Esse codigo: " + codigoProduto + "Ja exite. Cadastrar outro numero", "Atenção");
                txProduto.Clear();
                return;
            }

            else if (listaRelacaoProdutoPeca.Any(c => c.NOMEPRODUTO == nomeProduto))
            {
                MessageBox.Show("Esse codigo: " + nomeProduto + "Ja exite. Cadastrar outro numero", "Atenção");
                txNomeProduto.Clear();
                return;
            }

            else if (listaRelacaoProdutoPeca.Any(c => c.CODIGOPECA == codigoPeca))
            {
                MessageBox.Show("Esse codigo: " + codigoPeca + "Ja exite. Cadastrar outro numero", "Atenção");
                txCodigoPeca.Clear();
                return;
            }
            else if (listaRelacaoProdutoPeca.Any(c => c.NOMEPECA == nomePeca))
            {
                MessageBox.Show("Esse codigo: " + nomePeca + "Ja exite. Cadastrar outro numero", "Atenção");
                txNomePeca.Clear();
                return;
            }


            else {
                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                conn.Open();
                string scriptInsert = "INSERT INTO tbrelacaoprodutopeca" +
                    " (codigoProduto,nomeProtuo,codigoPeca,nomePeca,quantidadePeca)" +
                    " VALUE(@codigoProduto,@nomeProtuo,@codigoPeca,@nomePeca,@quantidadePeca)";


                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                    comando.Parameters.AddWithValue("@nomeProtuo", nomeProduto);
                    comando.Parameters.AddWithValue("@codigoPeca", codigoPeca);
                    comando.Parameters.AddWithValue("@nomePeca", nomePeca);
                    comando.Parameters.AddWithValue("@quantidadePeca", quantidade);

                    comando.ExecuteNonQuery();
                }
                RelacaoProdutoPeca relacaoProdutoPeca = new RelacaoProdutoPeca();
                relacaoProdutoPeca.CODIGOPRODUTO = codigoProduto;
                relacaoProdutoPeca.NOMEPRODUTO = nomeProduto;
                relacaoProdutoPeca.CODIGOPECA = codigoPeca;
                relacaoProdutoPeca.NOMEPECA = nomePeca;
                relacaoProdutoPeca.QUANTIDADE = quantidade;
                listaRelacaoProdutoPeca.Add(relacaoProdutoPeca);

                MessageBox.Show("Relação Produto-Peça cadastrada com sucesso!", "Cadastro Realizado");

                txProduto.Clear();
                txNomeProduto.Clear();
                txCodigoPeca.Clear();
                txNomePeca.Clear();
                txQuantidade.Clear();


                conn.Clone();

                }
            }
            

        }
    }
}
