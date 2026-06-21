using Microsoft.WindowsAPICodePack.Dialogs;
using MySqlConnector;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProjetoSenac
{
    public partial class FormEstoque : Form

    {
        ErrorProvider errorProvider = new ErrorProvider();

        TaskDialog taskDialog = new TaskDialog();

        BindingList <EstoqueEntrada> listaEstoque = new BindingList<EstoqueEntrada>();
       
        public FormEstoque()    
        {
            InitializeComponent();

            EstoqueEntrada estoqueEntrada = new EstoqueEntrada();

            List<string> codigosDoBanco = estoqueEntrada.listaSuspensa();

            // 2. Alimenta o ComboBox com a lista completa de uma vez só
            comboBox_CodigoProduto.DataSource = codigosDoBanco;

            DateTime dataEntradaPeca = monthCalendar1.SelectionStart;
            string nomePeca = txNomePeca.Text.Trim().ToLower();
            
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

            errorProvider.SetError(txQuantidadePeca, "");
            errorProvider.SetError(txNfPeca, "");
            DateTime dataEntradaPeca = monthCalendar1.SelectionStart;
            string nomePeca = txNomePeca.Text.Trim();
            




            if (!int.TryParse(txQuantidadePeca.Text, out int quantidaPeca) || quantidaPeca < 0)
            {
                errorProvider.SetError(txQuantidadePeca, "Quantidade inválida.");

                taskDialog.Caption = "Validação de Itens / Peças";
                taskDialog.InstructionText = "Quantidade incorreta";
                taskDialog.Text = "A quantidade da peça deve ser um número inteiro válido (ex: 1, 5, 10).";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();

                txQuantidadePeca.Clear();
                txQuantidadePeca.Focus();
                return;

               
            }

            if (!int.TryParse(comboBox_CodigoProduto.Text, out int codigoPeca) || codigoPeca <= 0)

            {
                errorProvider.SetError(comboBox_CodigoProduto, "Código do produto inválido.");

                taskDialog.Caption = "Validação de Itens / Peças";
                taskDialog.InstructionText = "Código da peça incorreto";
                taskDialog.Text = "Selecione ou insira um código numérico válido para a peça.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();

                // Reseta a lista suspensa para a opção inicial (em branco ou padrão)
                comboBox_CodigoProduto.SelectedIndex = 0;
                comboBox_CodigoProduto.Focus();
                return;
            }






            if (!int.TryParse(txNfPeca.Text, out int numeroNf) || numeroNf <=0)
            {
                errorProvider.SetError(txNfPeca, "Nota Fiscal inválida.");

                taskDialog.Caption = "Validação de Documento Fiscal";
                taskDialog.InstructionText = "Número de Nota Fiscal incorreto";
                taskDialog.Text = "O número da Nota Fiscal deve ser um valor numérico maior que zero.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();

                txNfPeca.Clear();
                txNfPeca.Focus();
                return;
            }


           


            EstoqueEntrada estoqueEntradaValidacao = new EstoqueEntrada();

            if (estoqueEntradaValidacao.validarEntradas(codigoPeca, numeroNf, quantidaPeca))

            {
                    // Mensagem formatada com interpolação de string ($) e quebras de linha (\n) para leitura clara
                    string mensagemDuplicidade = $"Possível duplicidade de informação!\n\n" +
                                                 $"Já existe um registro com estes dados:\n" +
                                                 $"• Código da Peça: {codigoPeca}\n" +
                                                 $"• Nota Fiscal: {numeroNf}\n" +
                                                 $"• Quantidade: {quantidaPeca}";

                    MessageBox.Show(mensagemDuplicidade, "Aviso de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Limpeza dos campos de forma padronizada
                    //comboBox_CodigoProduto.SelectedIndex = -1; // Remove a seleção do ComboBox de forma segura
                    txNfPeca.Clear();
                    txQuantidadePeca.Clear();

                // Foca o cursor de volta no primeiro campo para o usuário digitar novamente
                    txQuantidadePeca.Focus();

                    return;
                }



           
            

            if (!estoqueEntradaValidacao.FcValidarCodigoProduto(codigoPeca, nomePeca))
            {

                    // Mensagem formatada e clara para o usuário identificar o erro rapidamente
                    string mensagemIncompatibilidade = $"Incompatibilidade de dados!\n\n" +
                                                       $"O Código e o Nome do produto informado não correspondem.\n\n" +
                                                       $"• Código digitado: {codigoPeca}\n" +
                                                       $"• Nome digitado: {nomePeca}\n\n" +
                                                       $"Por favor, verifique as informações e tente novamente.";

                    MessageBox.Show(mensagemIncompatibilidade, "Aviso de Inconsistência", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Limpeza segura dos campos em conflito
                    //comboBox_CodigoProduto.SelectedIndex = -1;
                    //comboBox_CodigoProduto.Text = string.Empty;
                    txNomePeca.Clear();

                    // Retorna o cursor para o código do produto para reiniciar a busca correta
                    txNomePeca.Focus();

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


                    MessageBox.Show("Nota Fiscal validada e processada com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);



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

        private void txCodigoPeca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
