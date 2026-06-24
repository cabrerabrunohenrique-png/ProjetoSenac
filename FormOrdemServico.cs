using Microsoft.WindowsAPICodePack.Dialogs;

//
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
    public partial class FormOrdemServico : Form
    {
        
        ErrorProvider errorProvider = new ErrorProvider();

        TaskDialog taskDialog = new TaskDialog();

        BindingList<OrdemServico> listaEstoque = new BindingList<OrdemServico>();

        public FormOrdemServico()
        {
            InitializeComponent();
            OrdemServico ordemServico = new OrdemServico();

            List<string> codigosDoBanco = ordemServico.listaSuspensa();

            // 2. Alimenta o ComboBox com a lista completa de uma vez só
            comboBox1.DataSource = codigosDoBanco;

            
            string nomePeca = txNomeProduto.Text.Trim().ToLower();
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
            errorProvider.SetError(txNomeProduto, "");
            errorProvider.SetError(textBox1, "");



            if (!int.TryParse(txOS.Text.Trim(), out int codigoOs) || codigoOs <= 0)
            {
                MessageBox.Show("O código da ordem de serviço deve ser um valor numérico positivo.", "Atenção");
                txOS.Clear();
                txOS.Focus();
                return;
            }

            if (!int.TryParse(comboBox1.Text.Trim(), out int codigoProduto) || codigoProduto <= 0)
            {
                MessageBox.Show("O codigo do Produto tem que ser um numero inteiro positivo");
                comboBox1.Focus();
                comboBox1.Focus();
                return;

            }


            string nomeProduto = txNomeProduto.Text.Trim();

            /*char[] nomeEspecial = nomeProduto.ToCharArray();

            if (nomeEspecial.Any(char.IsSymbol) || nomeEspecial.Any(char.IsPunctuation) || nomeEspecial.Any(char.IsNumber))
            {
                MessageBox.Show("O nome do produto não pode conter caracteres especiais e NUMERO", "Atenção");
                txNomeProduto.Clear();
                return;
            }*/


            if (string.IsNullOrEmpty(nomeProduto) || nomeProduto.Any(char.IsNumber) || nomeProduto.Any(char.IsSymbol) || nomeProduto.Any(char.IsPunctuation))
            {
                errorProvider.SetError(txNomeProduto, "Nome do Produto incorreto.");
                taskDialog.Caption = "Validação Ordem Saída";
                taskDialog.InstructionText = "Nome incorreto incorreta";
                taskDialog.Text = "Nome do Produto Errado";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();

                txNomeProduto.Clear();
                txNomeProduto.Focus();


                return;
            }



            /*else if (listaOS.Any(c => c.CODIGOOS == codigoOs))

            {
                MessageBox.Show("Já existe uma ordem de serviço com esse código." +
                    " Por favor, utilize um código diferente.", "Atenção");
                txOS.Clear();
                return;
            }*/

            

            if (!int.TryParse(textBox1.Text, out int quantidade))
            {

                errorProvider.SetError(textBox1, "A quantidade deve ser um número inteiro maior que zero.");
                taskDialog.Caption = "Validação Saída de Produto";
                taskDialog.InstructionText = "Quantidade Inválida";
                taskDialog.Text = "Por favor, insira um número inteiro válido e positivo no campo de quantidade.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                textBox1.Clear();
                textBox1.Focus();
                return;
            }


           



            EstoqueEntrada estoqueEntradaValidacao = new EstoqueEntrada();








            if (estoqueEntradaValidacao.validarEntradas(codigoProduto, codigoOs, quantidade))

            {
                // Mensagem formatada com interpolação de string ($) e quebras de linha (\n) para leitura clara
                string mensagemDuplicidade = $"Possível duplicidade de informação!\n\n" +
                                             $"Já existe um registro com estes dados:\n" +
                                             $"• Código da Peça: {codigoProduto}\n" +
                                             $"• Codigo da OS: {codigoOs}\n" +
                                             $"• Quantidade: {quantidade}";

                MessageBox.Show(mensagemDuplicidade, "Aviso de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpeza dos campos de forma padronizada
                //comboBox_CodigoProduto.SelectedIndex = -1; // Remove a seleção do ComboBox de forma segura
                txOS.Clear();
                textBox1.Clear();

                // Foca o cursor de volta no primeiro campo para o usuário digitar novamente
                textBox1.Focus();

                return;
            }



            if (!estoqueEntradaValidacao.FcValidarCodigoProduto(codigoProduto, nomeProduto))
            {

                // Mensagem formatada e clara para o usuário identificar o erro rapidamente
                string mensagemIncompatibilidade = $"Incompatibilidade de dados!\n\n" +
                                                   $"O Código e o Nome do produto informado não correspondem.\n\n" +
                                                   $"• Código digitado: {codigoProduto}\n" +
                                                   $"• Nome digitado: {nomeProduto}\n\n" +
                                                   $"Por favor, verifique as informações e tente novamente.";

                MessageBox.Show(mensagemIncompatibilidade, "Aviso de Inconsistência", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpeza segura dos campos em conflito
                //comboBox_CodigoProduto.SelectedIndex = -1;
                //comboBox_CodigoProduto.Text = string.Empty;
                txNomeProduto.Clear();

                // Retorna o cursor para o código do produto para reiniciar a busca correta
                txNomeProduto.Focus();

                return;
            }

            


            else
            {

                string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";

                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                    conn.Open();
                    string scriptInsert = "INSERT INTO tbordemservico" +
                        " (codigoOs,codigoProduto,nomeProduto, quantidadeProduzida)" +
                        " VALUES(@codigoOs,@codigoProduto,@nomeProduto, @quantidadeProduzida)";

                    using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                    {
                        comando.Parameters.AddWithValue("@codigoOs", codigoOs);
                        comando.Parameters.AddWithValue("@codigoProduto", codigoProduto);
                        comando.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                        comando.Parameters.AddWithValue("@quantidadeProduzida", quantidade);

                        comando.ExecuteNonQuery();
                    }

                    OrdemServico ordemServico = new OrdemServico();

                    ordemServico.CODIGOOS = codigoOs;
                    ordemServico.CODIGOPRODUTO = codigoProduto;
                    ordemServico.NOMEPRODUTO = nomeProduto;
                    ordemServico.QUANTIDADEPECA = quantidade;
                    

                    listaEstoque.Add(ordemServico);
                    dGVOS.DataSource = listaEstoque;


                    MessageBox.Show("Ordem de serviço validada com sucesso!", "Sucesso");
                    txOS.Clear();
                    comboBox1.SelectedIndex = -1;
                    txNomeProduto.Clear();


                    conn.Clone();
                }

            }
        }

        private void FormOrdemServico_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
