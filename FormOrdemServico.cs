using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//
using MySqlConnector;


namespace ProjetoSenac
{
    public partial class FormOrdemServico : Form
    {

        BindingList<OrdemServico> listaOS = new BindingList<OrdemServico>();
        public FormOrdemServico()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lNomeProduto_Click(object sender, EventArgs e)
        {

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




        }

        private void btAcessarRelatorioOS_Click(object sender, EventArgs e)
        {

        }

        private void btValidarOS_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(txOS.Text.Trim(), out int codigoOs) || codigoOs < 0)
            {
                MessageBox.Show("O código da ordem de serviço deve ser um valor numérico positivo.", "Atenção");
                txOS.Clear();
                return;
            }

            if(!int.TryParse(txProduto.Text.Trim(), out int codigoProduto) || codigoProduto < 0)
            {
                MessageBox.Show("O codigo do Produto tem que ser um numero inteiro positivo");
                txProduto.Clear();
                return;

            }
            string nomeProduto = txNomeProduto.Text.Trim();
            
            char[] nomeEspecial = nomeProduto.ToCharArray();

            if (nomeEspecial.Any(char.IsSymbol) || nomeEspecial.Any(char.IsPunctuation) || nomeEspecial.Any(char.IsNumber))
            {
                MessageBox.Show("O nome do produto não pode conter caracteres especiais e NUMERO", "Atenção");
                txNomeProduto.Clear();
                return;
            }
                       
                                    
            if ( string.IsNullOrEmpty(nomeProduto))
            {
                MessageBox.Show("Preencha todos os campos para validar a ordem de serviço.");
                return;
            }

            if(nomeProduto.Length < 4)
            {
                MessageBox.Show("O nome do produto deve conter pelo menos 4 caracteres.", "Atenção");
                return;
            }

            else if (listaOS.Any(c => c.CODIGOOS == codigoOs))

            {
                MessageBox.Show("Já existe uma ordem de serviço com esse código." +
                    " Por favor, utilize um código diferente.", "Atenção");
                txOS.Clear();
                return;
            }

            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptInsert = "INSERT INTO tbordemservico" +
                    " (codigoOs,codigoProduto,nomeProduto)" +
                    " VALUES(@codigoOs,@codigoProduto,@nomeProduto)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@codigoOs", codigoOs);
                    comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                    comando.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                    
                    comando.ExecuteNonQuery();
                }

                OrdemServico novaOS = new OrdemServico();
                {
                    novaOS.CODIGOOS = codigoOs;
                    //novaOS.CODIGOPRODUTO = codigoProduto;
                    novaOS.NOMEPRODUTO = nomeProduto;   
                    listaOS.Add(novaOS);
                    dGVOS.DataSource = listaOS;


                    MessageBox.Show("Ordem de serviço validada com sucesso!", "Sucesso");
                    txOS.Clear() ;
                    txProduto.Clear();
                    txNomeProduto.Clear();
                }
                ;

                conn.Clone();
            }
        }

        private void FormOrdemServico_Load(object sender, EventArgs e)
        {

        }
    }
} 
