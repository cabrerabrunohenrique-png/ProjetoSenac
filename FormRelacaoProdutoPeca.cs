//
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
            string nomeProduto = txNomeProduto.Text.Trim();
            string nomePeca = txNomePeca.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("O campo nome do produto não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                txNomeProduto.Clear();
                return;

            }

            char[] nomeProdutoValidado = nomeProduto.ToCharArray();
           
            if(nomeProdutoValidado.Any(c => char.IsPunctuation(c) || char.IsSymbol(c) || char.IsNumber(c)))
            {
                MessageBox.Show("O nome nao pode conter caracteres especias e numeros","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNomeProduto.Clear();
                return;

            }




            if (string.IsNullOrWhiteSpace(nomePeca))
            {
                MessageBox.Show("O campo nome da peça não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNomePeca.Clear();
                return;
            }



            if (!int.TryParse(txProduto.Text, out int codigoProduto) || codigoProduto < 0)
            {
                MessageBox.Show("O campo código do produto deve conter um valor numérico válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txProduto.Clear();
                return;
            }

            if(!int.TryParse(txQuantidade.Text, out int quantidade) || quantidade <0)
            {
                MessageBox.Show("O campo quantidade deve conter um valor numérico válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txQuantidade.Clear();   
                return;
            }

            if(!int.TryParse(txCodigoPeca.Text, out int codigoPeca) || codigoPeca < 0)
            {
                MessageBox.Show("O campo código da peça deve conter um valor numérico válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCodigoPeca.Clear();
                return;
            }

            
            else if (listaRelacaoProdutoPeca.Any(c => c.CODIGOPRODUTO == codigoProduto))
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
                string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";


                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                conn.Open();
                string scriptInsert = "INSERT INTO tbrelacaoprodupeca" +
                    " (codigoProduto,nomeProduto,codigoPeca,nomePeca,quantidade)" +
                    " VALUE(@codigoProduto,@nomeProduto,@codigoPeca,@nomePeca,@quantidade)";


                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                    comando.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                    comando.Parameters.AddWithValue("@codigoPeca", codigoPeca);
                    comando.Parameters.AddWithValue("@nomePeca", nomePeca);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);

                    comando.ExecuteNonQuery();
                }
                RelacaoProdutoPeca relacaoProdutoPeca = new RelacaoProdutoPeca();
                relacaoProdutoPeca.CODIGOPRODUTO = codigoProduto;
                relacaoProdutoPeca.NOMEPRODUTO = nomeProduto;
                relacaoProdutoPeca.CODIGOPECA = codigoPeca;
                relacaoProdutoPeca.NOMEPECA = nomePeca;
                relacaoProdutoPeca.QUANTIDADE = quantidade;
                listaRelacaoProdutoPeca.Add(relacaoProdutoPeca);
                dGVRelacaoProduto.DataSource = listaRelacaoProdutoPeca;


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
