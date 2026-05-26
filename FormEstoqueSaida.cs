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
    public partial class FormEstoqueSaida : Form
    {

        BindingList<SaidaEstoqueSaida> listasaida = new BindingList<SaidaEstoqueSaida>();

        public FormEstoqueSaida()
        {
            InitializeComponent();
        }

        private void btVoltarE_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente voltar para a tela de login?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }

            //this.Owner.Show();
            //this.Close();
        }

        private void btFinalizarSaidaPeca_Click(object sender, EventArgs e)
        {
            DateTime dataSaida = monthCalendar1.SelectionStart;
            string nomePeca = txNomePecaS.Text;
            string situacaoPeca = txSituacaoPeca.Text;
            
            if (!int.TryParse(txCodigoPecaS.Text, out int codigoPeca))
            {
                MessageBox.Show("Código da peça inválido. Por favor, insira um número inteiro.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigoPeca1 = int.Parse(txCodigoPecaS.Text);

            if (codigoPeca1 < 0)
            {
                MessageBox.Show("Código da peça inválido. Por favor, insira um número positivo.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCodigoPecaS.Clear();
                return;
            }


            if(!int.TryParse(txQuatidadePeca.Text, out int quantidadePeca))
            {
                MessageBox.Show("Quantidade da peça inválida. Por favor, insira um número inteiro.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int quantidadePeca1 = int.Parse(txQuatidadePeca.Text);

            if(quantidadePeca1 < 0)
            {
                MessageBox.Show("Quantidade da peça inválida. Por favor, insira um número positivo.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning   );
                txQuatidadePeca.Clear();
                return;
             }


            int numeroNf = txNF.Text != "" ? int.Parse(txNF.Text) : 0;
            int cpfNf = txNF.Text != "" ? int.Parse(txNF.Text) : 0;
            int numeroOs = txNumeroOS.Text != "" ? int.Parse(txNumeroOS.Text) : 0;
            


            if (dataSaida == null || codigoPeca == 0 || nomePeca == null
                || quantidadePeca == 0 || numeroNf == 0 || cpfNf == 0
                || numeroOs == 0 || situacaoPeca == null) ;



            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {

                conn.Open();
                string scriptInsert = "INSERT INTO tbsaidaestoque" +
                    " (dataSaida,codigoPeca,nomePeca,quantidaPeca,numeroNf,cpfPeca,numeroOs,situacaoPeca)" +
                    " VALUES(@dataSaida,@codigoPeca,@nomePeca,@quantidadePeca,@nfPeca,@cpfPeca,@mumeroOS,@situacaoPeca)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@dataSaida", dataSaida);
                    comando.Parameters.AddWithValue("@codigoPeca", codigoPeca);
                    comando.Parameters.AddWithValue("@nomePeca", nomePeca);
                    comando.Parameters.AddWithValue("@quantidadePeca", quantidadePeca);
                    comando.Parameters.AddWithValue("@nfPeca", numeroNf);
                    comando.Parameters.AddWithValue("@cpfPeca", cpfNf);
                    comando.Parameters.AddWithValue("@mumeroOS", numeroOs);
                    comando.Parameters.AddWithValue("@situacaoPeca", situacaoPeca);
                    comando.ExecuteNonQuery();
                }
                SaidaEstoqueSaida saidaEstoque = new SaidaEstoqueSaida();
                saidaEstoque.DATA_SAIDA = dataSaida;
                saidaEstoque.CODIGOPECA = codigoPeca;
                saidaEstoque.NOMEPECA = nomePeca;
                saidaEstoque.QUANTIDADEPECA = quantidadePeca;
                saidaEstoque.NUMERONF = numeroNf;
                saidaEstoque.CPFPECA = cpfNf;
                saidaEstoque.NUMEROOS = numeroOs;
                saidaEstoque.SITUACAO = situacaoPeca;


                listasaida.Add(saidaEstoque);

                conn.Clone();
            }
        }
    }
}
