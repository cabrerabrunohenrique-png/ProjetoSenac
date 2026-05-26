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

            if(string.IsNullOrWhiteSpace(nomePeca))
            {
                MessageBox.Show("O nome da peça não pode estar vazio", "ATENÇÃO");
                txNomePecaS.Clear();
                return;
            };

            if(string.IsNullOrWhiteSpace(situacaoPeca))
            {
                MessageBox.Show("A situação da peça não pode estar vazia", "ATENÇÃO");
                txSituacaoPeca.Clear();
                return;
            }
            ;


            char[] nomePecaespecial = nomePeca.ToCharArray();

            if (nomePecaespecial.Any(char.IsSymbol) || nomePecaespecial.Any(char.IsPunctuation))
            {
                MessageBox.Show("O nome da peça não pode conter caracteres especiais", "ATENÇÃO");
                txNomePecaS.Clear();
                return;
            }


            if (!int.TryParse(txCodigoPecaS.Text, out int codigoPeca))
            {
                MessageBox.Show("Código da peça inválido. Por favor, insira um número inteiro.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            if (!int.TryParse(txQuatidadePeca.Text, out int quantidadePeca))
            {
                MessageBox.Show("Quantidade da peça inválida. Por favor, insira um número inteiro.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txQuatidadePeca.Clear();
                return;
            }

            if(!int.TryParse(txNF.Text, out int numeroNF) || numeroNF < 0)
            {
                MessageBox.Show("Número da nota fiscal inválido. Por favor, insira um número inteiro.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNF.Clear();
                return;
            }

            if(!int.TryParse(txCpfPeca.Text, out int cpfNf) || cpfNf < 0)
            {
                MessageBox.Show("CPF inválido. Por favor, insira um número inteiro.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txCpfPeca.Clear();
                return;
            }


            if (!int.TryParse(txNumeroOS.Text, out int numeroOs) || numeroOs < 0)
            {
                MessageBox.Show("Número da ordem de serviço inválido. Por favor, insira um número positivo.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNumeroOS.Clear();
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

            int quantidadePeca1 = int.Parse(txQuatidadePeca.Text);

            if (quantidadePeca1 < 0)
            {
                MessageBox.Show("Quantidade da peça inválida. Por favor, insira um número positivo.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txQuatidadePeca.Clear();
                return;
            }

            else
            { 



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
                        comando.Parameters.AddWithValue("@nfPeca", numeroNF);
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
                    saidaEstoque.NUMERONF = numeroNF;
                    saidaEstoque.CPFPECA = cpfNf;
                    saidaEstoque.NUMEROOS = numeroOs;
                    saidaEstoque.SITUACAO = situacaoPeca;


                    listasaida.Add(saidaEstoque);

                    MessageBox.Show("Saída da peça registrada com sucesso!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    monthCalendar1.SetDate(DateTime.Today);
                    txCodigoPecaS.Clear();
                    txNomePecaS.Clear();
                    txQuatidadePeca.Clear();
                    txNF.Clear();
                    txSituacaoPeca.Clear();
                    txCpfPeca.Clear();
                    txNumeroOS.Clear();


                    conn.Clone();
                }
            }
        } 
    }
}
