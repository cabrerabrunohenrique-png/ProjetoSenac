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

            int codigoPeca = int.TryParse(txCodigoPeca.Text, out int codigo) ? codigo : 0;

            //double pesoPeca = txPesoPeca.Text != "" ? double.Parse(txPesoPeca.Text) : 0.0;

            //double alturaPeca = txAlturaPeca.Text != "" ? double.Parse(txAlturaPeca.Text) : 0.0;
            DateTime dataEntradaPeca = monthCalendar1.SelectionStart;
            string nomePecaSem = txNomePeca.Text;
            string nomePeca = nomePecaSem.Trim();
            string fabricanteSem = txFabricantePeca.Text;
            string fabricante = fabricanteSem.Trim();
            //double comprimentoPeca = txComprimentoPeca.Text != "" ? double.Parse(txComprimentoPeca.Text) : 0.0;
            //int quantidaPeca = txQuantidadePeca.Text != "" ? int.Parse(txQuantidadePeca.Text) : 0;
            //int numeroNf = txNfPeca.Text != "" ? int.Parse(txNfPeca.Text) : 0;

            if (!double.TryParse(txPesoPeca.Text, out double pesoPeca))
            {
                MessageBox.Show("O peso da peça deve ser um número válido", "ATENÇÃO");
                txPesoPeca.Clear();
                return;
            }

            if (!double.TryParse(txAlturaPeca.Text, out double alturaPeca))
            {   
                MessageBox.Show("A altura da peça deve ser um número válido", "ATENÇÃO");
                txAlturaPeca.Clear();
                return;
            }

            if (!double.TryParse(txComprimentoPeca.Text, out double comprimentoPeca))
            {
                MessageBox.Show("O comprimento da peça deve ser um número válido", "ATENÇÃO");
                txComprimentoPeca.Clear();
                return;
            }

            if (!int.TryParse(txQuantidadePeca.Text, out int quantidaPeca))
            {
                MessageBox.Show("A quantidade da peça deve ser um número válido", "ATENÇÃO");
                txQuantidadePeca.Clear();
                return;
            }

            if (!int.TryParse(txNfPeca.Text, out int numeroNf))
            {
                MessageBox.Show("O número da nota fiscal deve ser um número válido", "ATENÇÃO");
                txNfPeca.Clear();
                return;
            }

            if(codigoPeca ==0 || codigoPeca < 0)
            {
                MessageBox.Show("O código da peça tem que ser um número inteiro"+ codigoPeca, "ATENÇÃO");
                txCodigoPeca.Clear(); 
                return;
            }

           
            
            if (nomePeca.Length <2 || nomePeca.Length > 20)
            {
                MessageBox.Show("Nome da peça deve conter entre 2 e 20 caracteres", "ATENÇÃO");
                txNomePeca.Clear();
                return;
            }




            //if (codigoPeca.Lenght > 0) {


            char[] nomeEspecial = nomePeca.ToCharArray();

            if(nomeEspecial.Any(char.IsSymbol) || nomeEspecial.Any(char.IsPunctuation))
            {
                MessageBox.Show("O nome da peça não pode conter caracteres especiais", "ATENÇÃO");
                txNomePeca.Clear();
                return;
            }

            if (fabricante.Length < 2 || fabricante.Length > 20)
            {
                MessageBox.Show("O nome do fabricante deve conter entre 2 e 20 caracteres", "ATENÇÃO");
                txFabricantePeca.Clear();
                return;
            }

            char[] fabricanteEspecial = fabricante.ToCharArray();
            if(fabricanteEspecial.Any(char.IsSymbol) || fabricanteEspecial.Any(char.IsPunctuation))
            {
                MessageBox.Show("O nome do fabricante não pode conter caracteres especiais", "ATENÇÃO");
                txFabricantePeca.Clear();
                return;
            }

            if (codigoPeca == 0 || pesoPeca == 0 || alturaPeca == 0 || comprimentoPeca == 0 || quantidaPeca == 0 || numeroNf == 0)
            {
                MessageBox.Show("Todos os campos tem que estar preenchidos", "Atenção");
                return;
            }

            else
            {
               
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



                conn.Clone();
            }
        }
    }
}
