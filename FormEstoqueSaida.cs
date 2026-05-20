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

        BindingList <SaidaEstoqueSaida> listasaida = new BindingList<SaidaEstoqueSaida>();

        public FormEstoqueSaida()
        {
            InitializeComponent();
        }

        private void btVoltarE_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btFinalizarSaidaPeca_Click(object sender, EventArgs e)
        {
            DateTime dataSaida = monthCalendar1.SelectionStart;
            int codigoPeca = txCodigoPecaS.Text != "" ? int.Parse(txCodigoPecaS.Text) : 0;
            string nomePeca = txNomePecaS.Text;
            int quantidadePeca = txQuatidadePeca.Text != "" ? int.Parse(txQuatidadePeca.Text) : 0;
            int numeroNf = txNF.Text != "" ? int.Parse(txNF.Text) : 0;
            int cpfNf = txNF.Text != "" ? int.Parse(txNF.Text) : 0;
            int numeroOs = txNumeroOS.Text != "" ? int.Parse(txNumeroOS.Text) : 0;
            string situacaoPeca = txSituacaoPeca.Text;


            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {

                conn.Open();
                string scriptInsert = "INSERT INTO tbentradaestoque" +
                    " (dataSaisaPeca,codigoPeca,nomePeca,quantidadePeca,nfPeca,cpfPeca,mumeroOS,situacaoPeca)" +
                    " VALUES(@dataSaisaPeca,@codigoPeca,@nomePeca,@quantidadePeca,@nfPeca,@cpfPeca,@mumeroOS,@situacaoPeca)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@dataEntradaPeca", dataEntradaPeca);
                   




                    comando.ExecuteNonQuery();
                }
                SaidaEstoqueSaida saindaEstoque = new SaidaEstoqueSaida();
                saindaEstoque.DATA_SAIDA = 


                listasaida.Add(saindaEstoque);

                conn.Clone();
            }
    }
}
