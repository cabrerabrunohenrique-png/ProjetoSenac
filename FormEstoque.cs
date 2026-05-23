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
    public partial class FormEstoque : Form
    {
        
        BindingList <EstoqueEntrada> listaEstoque = new BindingList<EstoqueEntrada>();
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void btPaginaIncialE_Click(object sender, EventArgs e)
        {
            Nav formNav = new Nav();
            this.Hide();
            formNav.Show();
            DialogResult = DialogResult.OK;
            this.Show();
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
           //  this.Close();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {

        }

        private void btCadastrarEntrada_Click(object sender, EventArgs e)
        {

            int codigoPeca = txCodigoPeca.Text != "" ? int.Parse(txCodigoPeca.Text) : 0;
            double pesoPeca = txPesoPeca.Text != "" ? double.Parse(txPesoPeca.Text) : 0.0;
            double alturaPeca = txAlturaPeca.Text != "" ? double.Parse(txAlturaPeca.Text) : 0.0;
            DateTime dataEntradaPeca = monthCalendar1.SelectionStart;
            string nomePeca = txNomePeca.Text;
            string fabricante = txFabricantePeca.Text;
            double comprimentoPeca = txComprimentoPeca.Text != "" ? double.Parse(txComprimentoPeca.Text) : 0.0;
            int quantidaPeca = txQuantidadePeca.Text != "" ? int.Parse(txQuantidadePeca.Text) : 0;
            int numeroNf = txNfPeca.Text != "" ? int.Parse(txNfPeca.Text) : 0;


            if (codigoPeca == 0 || pesoPeca == 0 || alturaPeca == 0 || comprimentoPeca == 0 || quantidaPeca == 0 || numeroNf == 0)
            {
                MessageBox.Show("Todos os campos tem que estar preenchidos", "Atenção");
                return;
            }

            else
            {
                MessageBox.Show("ok");

                txCodigoPeca.Clear();
                txPesoPeca.Clear();
                txAlturaPeca.Clear();
                txNomePeca.Clear();
                txFabricantePeca.Clear();
                txComprimentoPeca.Clear();
                txQuantidadePeca.Clear();
                txNfPeca.Clear();
                monthCalendar1.SelectionEnd = DateTime.Today;
            }

            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                




                conn.Open();
                string scriptInsert = "INSERT INTO tbentradaestoque" +
                    " (dataEntradaPeca,codigoPeca,nomePeca,fabricantePeca,pesoPeca,alturaPeca,comprimenetoPeca,quantidadePeca,nfPeca)" +
                    " VALUES(@dataEntradaPeca,@codigoPeca,@nomePeca,@fabricantePeca,@pesoPeca,@alturaPeca,@comprimenetoPeca,@quantidadePeca,@nfPeca)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@dataEntradaPeca", dataEntradaPeca);
                    comando.Parameters.AddWithValue("@codigoPeca", codigoPeca);
                    comando.Parameters.AddWithValue("@nomePeca", nomePeca);
                    comando.Parameters.AddWithValue("@fabricantePeca", fabricante);
                    comando.Parameters.AddWithValue("@pesoPeca", pesoPeca);
                    comando.Parameters.AddWithValue("@alturaPeca", alturaPeca);
                    comando.Parameters.AddWithValue("@comprimenetoPeca", comprimentoPeca);
                    comando.Parameters.AddWithValue("@quantidadePeca", quantidaPeca);
                    comando.Parameters.AddWithValue("@nfPeca", numeroNf);




                    comando.ExecuteNonQuery();
                }
                EstoqueEntrada estoqueEntrada = new EstoqueEntrada();
                estoqueEntrada.DATAENTRADA = dataEntradaPeca;
                estoqueEntrada.CODIGOPECA = codigoPeca;
                estoqueEntrada.NOMEPECA = nomePeca;
                estoqueEntrada.FABRICANTE = fabricante;
                estoqueEntrada.PESOPECA = pesoPeca;
                estoqueEntrada.ALTURAPECA = alturaPeca;
                estoqueEntrada.COMPRIMENTOPECA = comprimentoPeca;
                estoqueEntrada.QUANTIDADEPECA = quantidaPeca;
                estoqueEntrada.NUMERONF = numeroNf;

                listaEstoque.Add(estoqueEntrada);

                conn.Clone();
            }
        }
    }
}
