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

            EstoqueEntrada estoqueEntrada = new EstoqueEntrada();

            List<string> codigosDoBanco = estoqueEntrada.listaSuspensa();

            // 2. Alimenta o ComboBox com a lista completa de uma vez só
            comboBox_CodigoProduto.DataSource = codigosDoBanco;

            DateTime dataEntradaPeca = monthCalendar1.SelectionStart;
            string nomePecaSem = txNomePeca.Text;
            string nomePeca = nomePecaSem.Trim();
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
            

            DateTime dataEntradaPeca = monthCalendar1.SelectionStart;
            string nomePecaSem = txNomePeca.Text;
            string nomePeca = nomePecaSem.Trim();




            if (!int.TryParse(txQuantidadePeca.Text, out int quantidaPeca) || quantidaPeca < 0)
            {
                MessageBox.Show("A quantidade da peça deve ser um número válido", "ATENÇÃO");
                txQuantidadePeca.Clear();
                return;
            }

            if (!int.TryParse(comboBox_CodigoProduto.Text, out int codigoPeca) || codigoPeca <= 0)

            {
                MessageBox.Show("O código da peça deve ser um número válido", "ATENÇÃO");
                comboBox_CodigoProduto.Text = "";
                return;
            }






            if (!int.TryParse(txNfPeca.Text, out int numeroNf))
            {
                MessageBox.Show("O número da nota fiscal deve ser um número válido", "ATENÇÃO");
                txNfPeca.Clear();
                return;
            }


            int numeroNfPeca = int.Parse(txNfPeca.Text);
            {
                if (numeroNfPeca < 0)
                {
                    MessageBox.Show("O número da nota fiscal deve ser um número inteiro positivo", "ATENÇÃO");
                    txNfPeca.Clear();
                    return;
                }
            }


            EstoqueEntrada estoqueEntradaValidacao = new EstoqueEntrada();

            if (estoqueEntradaValidacao.validarEntradas(codigoPeca, numeroNf, quantidaPeca))

            {
                MessageBox.Show("Possivel duplicidade de informãção Já foi inserido esse numero de codigo" + codigoPeca + "nf" + numeroNf + "quantidade" + quantidaPeca);
                comboBox_CodigoProduto.Text = "";
                txNfPeca.Clear();
                txQuantidadePeca.Clear();
                return;
            }

            

            if (!estoqueEntradaValidacao.FcValidarCodigoProduto(codigoPeca, nomePeca))
            {
                MessageBox.Show("O codigo e o nome da peça não correspondem, verifique os dados e tente novamente", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }

           

            if (nomePeca.Length < 2 || nomePeca.Length > 20)
            {
                MessageBox.Show("Nome da peça deve conter entre 2 e 20 caracteres", "ATENÇÃO");
                txNomePeca.Clear();
                return;
            }




            //if (codigoPeca.Lenght > 0) {


            char[] nomeEspecial = nomePeca.ToCharArray();

            if (nomeEspecial.Any(char.IsSymbol) || nomeEspecial.Any(char.IsPunctuation))
            {
                MessageBox.Show("O nome da peça não pode conter caracteres especiais", "ATENÇÃO");
                txNomePeca.Clear();
                return;
            }

           

            if (codigoPeca == 0 || quantidaPeca == 0 || numeroNf == 0)
            {
                MessageBox.Show("Todos os campos tem que estar preenchidos", "Atenção");
                return;
            }


            if( listaEstoque.Any(c => c.NUMERONF == numeroNf && c.CODIGOPECA == codigoPeca && c.QUANTIDADEPECA == quantidaPeca))
            {
               MessageBox.Show("Já existe uma peça com esse código e número de nota fiscal", "ATENÇÃO");
               return;
            }

            

            else
            {



                string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {





                    conn.Open();
                    string scriptInsert = "INSERT INTO tbentradaestoque" +
                        " (dataEntradaProduto,codigoProduto,nomeProduto,quantidadeProduto,nFProduto)" +
                        " VALUES(@dataEntradaProduto,@codigoProduto,@nomeProduto,@quantidadeProduto,@nFProduto)";

                    using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                    {
                        comando.Parameters.AddWithValue("@dataEntradaProduto", dataEntradaPeca);
                        comando.Parameters.AddWithValue("@codigoProduto", codigoPeca);
                        comando.Parameters.AddWithValue("@nomeProduto", nomePeca);
                   
                        comando.Parameters.AddWithValue("@quantidadeProduto", quantidaPeca);
                        comando.Parameters.AddWithValue("@nFProduto", numeroNf);




                        comando.ExecuteNonQuery();
                    }
                    EstoqueEntrada estoqueEntrada = new EstoqueEntrada();
                    estoqueEntrada.DATAENTRADA = dataEntradaPeca;
                    estoqueEntrada.CODIGOPECA = codigoPeca;
                    estoqueEntrada.NOMEPECA = nomePeca;
                 
                    estoqueEntrada.QUANTIDADEPECA = quantidaPeca;
                    estoqueEntrada.NUMERONF = numeroNf;

                    listaEstoque.Add(estoqueEntrada);
                    dataGridView1.DataSource = listaEstoque;


                    MessageBox.Show("ok");

                    txCodigoPeca.Clear();
                   
                    txNomePeca.Clear();
                  
                    txQuantidadePeca.Clear();
                    txNfPeca.Clear();
                    monthCalendar1.SelectionEnd = DateTime.Today;



                    conn.Clone();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
