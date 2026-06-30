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
    public partial class FormCadastroProduto : Form
    {
        BindingList<CadastroProduto> listaRelacaoProdutoPeca = new BindingList<CadastroProduto>();

        public FormCadastroProduto()
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
            
            string nomeProduto = TXNomeProduto.Text.Trim().ToLower();
            string nomeFabricante = TXFabricanteProduto.Text.Trim().ToLower();
            





            if (string.IsNullOrWhiteSpace(nomeProduto))
            {
                MessageBox.Show("O campo nome do produto não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);
                TXNomeProduto.Clear();
                TXNomeProduto.Focus();
                return;

            }

            char[] nomeProdutoValidado = nomeProduto.ToCharArray();
           
            if(nomeProdutoValidado.Any(c => char.IsPunctuation(c) || char.IsSymbol(c) || char.IsNumber(c)))
            {
                MessageBox.Show("O nome nao pode conter caracteres especias e numeros","ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXNomeProduto.Clear();
                TXNomeProduto.Focus();      
                return;

            }




            if (string.IsNullOrWhiteSpace(nomeFabricante))
            {
                MessageBox.Show("O campo nome do fabricante não pode estar vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXFabricanteProduto.Clear();
                TXFabricanteProduto.Focus();
                return;
            }


            

            if (!int.TryParse(TXCodigoProduto.Text, out int codigoProduto) || codigoProduto < 0)
            {
                MessageBox.Show("O campo código do produto deve conter um valor numérico válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXCodigoProduto.Clear();
                TXCodigoProduto.Focus();
                return;
            }

            CadastroProduto validador = new CadastroProduto();

            if (validador.ValidarCodigo(codigoProduto))
            { 
                MessageBox.Show("Esse código: " + codigoProduto + " já existe. Cadastrar outro número", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXCodigoProduto.Clear();
                TXCodigoProduto.Focus();
                return;
            }

            if(validador.FcValidarNome(nomeProduto))
            {
                MessageBox.Show("Esse nome: " + nomeProduto + " já existe. Cadastrar outro nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXNomeProduto.Clear();
                TXNomeProduto.Focus();
                return;
            }

            
            /*
                        
            if (listaRelacaoProdutoPeca.Any(c => c.CODIGOPRODUTO == codigoProduto))
            {
                MessageBox.Show("Esse codigo: " + codigoProduto + "Ja exite. Cadastrar outro numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXCodigoProduto.Clear();
                TXCodigoProduto.Focus();
                return;
            }*/

            if (listaRelacaoProdutoPeca.Any(c => c.NOMEPRODUTO == nomeProduto))
            {
                MessageBox.Show("Esse nome: " + nomeProduto + "Ja exite. Cadastrar outro numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                TXNomeProduto.Clear();
                TXNomeProduto.Focus();
                return;
            }

            if(!double.TryParse(TXPesoPeca.Text, out double pesoPeca) || pesoPeca <= 0)
            {
                MessageBox.Show("O campo peso da peça deve conter um valor numérico válido e positivo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXPesoPeca.Clear();
                TXPesoPeca.Focus();
                return;
            }

            if (!double.TryParse(TXAlturaPeca.Text, out double alturaPeca) || alturaPeca <= 0)
            {
                MessageBox.Show("O campo altura da peça deve conter um valor numérico válido e positivo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXAlturaPeca.Clear();
                TXAlturaPeca.Focus();
                return;
            }

            if (!double.TryParse(TXComprimentoProduto.Text, out double comprimentoProduto) || comprimentoProduto <= 0)
            { 
                MessageBox.Show("O campo comprimento da peça deve conter um valor numérico válido e positivo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXComprimentoProduto.Clear();
                TXComprimentoProduto.Focus();
                return;
            }

            if(listaRelacaoProdutoPeca.Any(c => c.CODIGOPRODUTO == codigoProduto))
            {
                MessageBox.Show("Esse código: " + codigoProduto + " já existe. Cadastrar outro número", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXCodigoProduto.Clear();
                TXCodigoProduto.Focus();
                return;
            }

            if (listaRelacaoProdutoPeca.Any(c => c.NOMEPRODUTO == nomeProduto))
            {
                MessageBox.Show("Esse nome: " + nomeProduto + " já existe. Cadastrar outro nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXNomeProduto.Clear();
                TXNomeProduto.Focus();
                return;
            }

            

            else {
                string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";


                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                    conn.Open();
                    string scriptInsert = "INSERT INTO tbcadastropeca" +
                        " (codigoproduto,nomeProduto,fabricanteProduto,pesoProduto,alturaProduto,comprimentoProduto)" +
                        " VALUES (@codigoProduto,@nomeProduto,@fabricanteProduto,@pesoProduto,@alturaProduto,@comprimentoProduto)";

                  
                    using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                    {
                        comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                        comando.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                        comando.Parameters.AddWithValue("@fabricanteProduto", nomeFabricante);
                        comando.Parameters.AddWithValue("@pesoProduto", pesoPeca);
                        comando.Parameters.AddWithValue("@alturaProduto", alturaPeca);
                        comando.Parameters.AddWithValue("@comprimentoProduto", comprimentoProduto);

                        comando.ExecuteNonQuery();
                    }
                    CadastroProduto relacaoProdutoPeca = new CadastroProduto();
                    relacaoProdutoPeca.CODIGOPRODUTO = codigoProduto;
                    relacaoProdutoPeca.NOMEPRODUTO = nomeProduto;
                    relacaoProdutoPeca.FABRICANTEPRODUTO = nomeFabricante;
                    relacaoProdutoPeca.PESOPRODUTO = pesoPeca;
                    relacaoProdutoPeca.ALTURAPRODUTO = alturaPeca;
                    relacaoProdutoPeca.COMPRIMENTOPRODUTO = comprimentoProduto;
                    listaRelacaoProdutoPeca.Add(relacaoProdutoPeca);
                    dGVRelacaoProduto.DataSource = listaRelacaoProdutoPeca;




                    MessageBox.Show("Relação Produto-Peça cadastrada com sucesso!", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    TXCodigoProduto.Clear();
                    TXNomeProduto.Clear();
                    TXFabricanteProduto.Clear();
                    TXPesoPeca.Clear();
                    TXAlturaPeca.Clear();
                    TXComprimentoProduto.Clear();


                    conn.Clone();

                }
            }
            

        }

        private void btProdutosCadastrado_Click(object sender, EventArgs e)
        {
            FormProdutosCadastrado formProdutosCadastrado = new FormProdutosCadastrado();
            formProdutosCadastrado.Owner = this;
            formProdutosCadastrado.Show();
        }
    }
}
