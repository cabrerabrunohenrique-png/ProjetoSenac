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
            this.Owner.Show();
            this.Close();




        }

        private void btAcessarRelatorioOS_Click(object sender, EventArgs e)
        {

        }

        private void btValidarOS_Click(object sender, EventArgs e)
        {
            string codigoOS = txOS.Text;
            string codigoProduto = txProduto.Text;
            string nomeProduto = txNomeProduto.Text;
            

            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

            if (string.IsNullOrEmpty(codigoOS) || string.IsNullOrEmpty(codigoProduto)
                || string.IsNullOrEmpty(nomeProduto))
            {
                MessageBox.Show("Preencha todos os campos para validar a ordem de serviço.");
                return;
            }

            else if (listaOS.Any(c => c.CODIGOOS == codigoOS))

            {
                MessageBox.Show("Já existe uma ordem de serviço com esse código." +
                    " Por favor, utilize um código diferente.", "Atenção");
                txOS.Clear();
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
            {
                conn.Open();
                string scriptInsert = "INSERT INTO tbordemservico" +
                    " (codigoOs,codigoProduto,nomeProduto)" +
                    " VALUES(@codigoOs,@codigoProduto,@nomeProduto)";

                using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                {
                    comando.Parameters.AddWithValue("@codigoOs", codigoOS);
                    comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                    comando.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                    
                    comando.ExecuteNonQuery();
                }

                OrdemServico novaOS = new OrdemServico();
                {
                    novaOS.CODIGOOS = codigoOS;
                    novaOS.CODIGOPRODUTO = codigoProduto;
                    novaOS.NOMEPRODUTO = nomeProduto;   
                    listaOS.Add(novaOS);

                    MessageBox.Show("Ordem de serviço validada com sucesso!", "Sucesso");
                    txOS.Clear() ;
                    txProduto.Clear();
                    txNomeProduto.Clear();
                }
                ;

                conn.Clone();
            }
        }
    }
} 
