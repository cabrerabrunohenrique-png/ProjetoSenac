using Microsoft.WindowsAPICodePack.Dialogs;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoSenac
{
    public partial class FormEstoqueSaida : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        TaskDialog taskDialog = new TaskDialog();
        BindingList<SaidaEstoqueSaida> listasaida = new BindingList<SaidaEstoqueSaida>();

        public FormEstoqueSaida()
        {
            InitializeComponent();
            
            SaidaEstoqueSaida saidaEstoqueSaida = new SaidaEstoqueSaida();

            List<string> codigo = saidaEstoqueSaida.FclistaSuspensa();
            tbCodigoPecaS.DataSource= codigo;


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
            DateTime dataEntradaPeca = monthCalendar1.SelectionStart;
            errorProvider.SetError(txNomePecaS, "");
            errorProvider.SetError(txQuatidadePeca, "");
            errorProvider.SetError(txNF, "");
            errorProvider.SetError(txCpfPeca, "");
            errorProvider.SetError(txNumeroOS, "");
            errorProvider.SetError(txSituacaoPeca, "");



            if (!int.TryParse(tbCodigoPecaS.Text, out int codigoPeca))
            {
                MessageBox.Show("Código da peça inválido. Por favor, insira um número inteiro.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EstoqueEntrada estoqueEntradaValidacao = new EstoqueEntrada();

            if (!estoqueEntradaValidacao.FcValidarCodigoProduto(codigoPeca, nomePeca))
            {

                // Mensagem formatada e clara para o usuário identificar o erro rapidamente
                string mensagemIncompatibilidade = $"Incompatibilidade de dados!\n\n" +
                                                   $"O Código e o Nome do produto informado não correspondem.\n\n" +
                                                   $"• Código digitado: {codigoPeca}\n" +
                                                   $"• Nome digitado: {nomePeca}\n\n" +
                                                   $"Por favor, verifique as informações e tente novamente.";
                errorProvider.SetError(txNomePecaS, "O nome nao pode estar vazio, conter numeros, simbolos ou pontuacoes.");
                

                MessageBox.Show(mensagemIncompatibilidade, "Aviso de Inconsistência", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Limpeza segura dos campos em conflito
                //comboBox_CodigoProduto.SelectedIndex = -1;
                //comboBox_CodigoProduto.Text = string.Empty;
                txNomePecaS.Clear();

                // Retorna o cursor para o código do produto para reiniciar a busca correta
                txNomePecaS.Focus();

                return;
            }

            /*SaidaEstoqueSaida saidaEstoqueSaida = new SaidaEstoqueSaida();


            if (saidaEstoqueSaida.FcValidarNome(codigoPeca, nomePeca))
            {
                string mensagemDuplicidade = $"Possível duplicidade de informação!\n\n" +
                                                $"Já existe um registro com estes dados:\n" +
                                                $"• Código da Peça: {codigoPeca}\n" +
                                                $"• Nota Fiscal: {nomePeca})";

                MessageBox.Show(mensagemDuplicidade, "Aviso de Duplicidade", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/


            if (string.IsNullOrWhiteSpace(nomePeca) || txNomePecaS.Text.Length < 5 || nomePeca.Length > 50 || nomePeca.Any(c=> char.IsNumber(c))
                || nomePeca.Any(c=> char.IsSymbol(c)) || nomePeca.Any(c=> char.IsPunctuation(c)))
            {
                            
                errorProvider.SetError(txNomePecaS, "O nome nao pode estar vazio, conter numeros, simbolos ou pontuacoes.");
                taskDialog.Caption = "Validação Saída de Produto";
                taskDialog.InstructionText = "Nome do Produto Inválido";
                taskDialog.Text = "O nome nao pode conter numeros, simbolos ou pontuacoes.\n O nome inserido deve conter entre 5 e 50 caracteres.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();

                //MessageBox.Show("O nome completo deve ter entre 5 e 50 caracteres.", "NOME COMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txNomePecaS.Clear();
                txNomePecaS.Focus();

                return;
            }



            if (!int.TryParse(txQuatidadePeca.Text, out int quantidadePeca))
            {

                errorProvider.SetError(txQuatidadePeca, "A quantidade deve ser um número inteiro maior que zero.");
                taskDialog.Caption = "Validação Saída de Produto";
                taskDialog.InstructionText = "Quantidade Inválida";
                taskDialog.Text = "Por favor, insira um número inteiro válido e positivo no campo de quantidade.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txQuatidadePeca.Clear();
                txQuatidadePeca.Focus();
                return;
            }

            if (!int.TryParse(txNF.Text, out int numeroNF) || numeroNF < 0)
            {
                errorProvider.SetError(txNF, "O numero da NF tem que ser maior que 0.");
                taskDialog.Caption = "Validação Saída de Produto";
                taskDialog.InstructionText = "Numero da NF invaladio";
                taskDialog.Text = "Por favor, insira um número inteiro sem virgula e ponto.\n Exemplo:123458 e NAO 123.458";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNF.Clear();
                txNF.Focus();
                return;
            }

            if (!int.TryParse(txCpfPeca.Text, out int cpfNf) || cpfNf < 0)
            {
                errorProvider.SetError(txCpfPeca, "O numero do CPF tem que ser inteiro positivo. \nExemplo: 123458.\nNÃO 123.458");
                taskDialog.Caption = "Validação Saída de Produto";
                taskDialog.InstructionText = "Numero do CPF Invalido";
                taskDialog.Text = "Por favor, insira um número inteiro sem virgula e ponto.\n Exemplo:123458 e NAO 123.458";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txCpfPeca.Clear();
                txCpfPeca.Focus();
                return;
            }



            if (!int.TryParse(txNumeroOS.Text, out int numeroOs) || numeroOs < 0)
            {
                errorProvider.SetError(txNumeroOS, "O numero da OS tem que ser inteiro positivo. \nExemplo: 123458.\nNÃO 123.458");
                taskDialog.Caption = "Validação Saída de Produto";
                taskDialog.InstructionText = "Numero da OS Invalido";
                taskDialog.Text = "Por favor, insira um número inteiro sem virgula e ponto.\n Exemplo:123458 e NAO 123.458";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNumeroOS.Clear();
                txNumeroOS.Focus();
                return;
            }



          
            if (string.IsNullOrWhiteSpace(situacaoPeca) || txSituacaoPeca.Text.Length < 5 || situacaoPeca.Length > 50 || situacaoPeca.Any(c => char.IsNumber(c))
                || situacaoPeca.Any(c => char.IsSymbol(c)) || situacaoPeca.Any(c => char.IsPunctuation(c)))
            {

                errorProvider.SetError(txSituacaoPeca, "A Situacao da peça NAO PODE  estar vazio.");
                taskDialog.Caption = "Validação Saída de Produto";
                taskDialog.InstructionText = "Situação da Peça";
                taskDialog.Text = "Descreva a situação da peça. Nao pode conter numeros, simbolos ou pontuacoes.\n Minimio de  5 e maximo de 50 caracteres.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txSituacaoPeca.Clear();
                txSituacaoPeca.Focus();

                return;
            }

            /*int codigoPeca1 = int.Parse(tbCodigoPecaS.Text);

            if (codigoPeca1 < 0)
            {
                MessageBox.Show("Código da peça inválido. Por favor, insira um número positivo.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCodigoPecaS.SelectedIndex = -1;
                return;
            }

            int quantidadePeca1 = int.Parse(txQuatidadePeca.Text);

            if (quantidadePeca1 < 0)
            {
                MessageBox.Show("Quantidade da peça inválida. Por favor, insira um número positivo.",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txQuatidadePeca.Clear();
                return;
            }*/

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
                    tbCodigoPecaS.SelectedIndex = -1;
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
