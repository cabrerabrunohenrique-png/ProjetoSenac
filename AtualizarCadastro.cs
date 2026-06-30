using Microsoft.WindowsAPICodePack.Dialogs;

using MySqlConnector;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProjetoSenac



{
    public partial class AtualizarCadastro : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        TaskDialog taskDialog = new TaskDialog();
        BindingList<CadastroUsuario> listaCadastroUsuario = new BindingList<CadastroUsuario>();
        public AtualizarCadastro()
        {

            InitializeComponent();
            cbNivelPermisao.Items.Add("");
            cbNivelPermisao.Items.Add("Administrador");
            cbNivelPermisao.Items.Add("Usuário Comum");
            cbNivelPermisao.Items.Add("Usuário Restrito");
        }

        private void btVoltarCNU_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Se nao atualizar os dados, todas as alteracoes serão perdidas.", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Owner.Show();
                this.Close();
            }
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = txNomeCompleto.Text.Trim();

            string nivelPermissao = cbNivelPermisao.Text;
            string nomeUsuario = txNomeUsuario.Text.Trim();
            string senhaAcesso = txSenhaAcesso.Text;

            int controleLinhasAftadas = 0;
            string DADOS_CONEXAO = "server=localhost; user=root; password=; database=bdprojetosenac;";



            errorProvider.SetError(txNomeCompleto, "");

            if (nomeCompleto.Length < 5 || nomeCompleto.Length > 50)
            {
                errorProvider.SetError(txNomeCompleto, "O nome completo deve ter entre 5 e 50 caracteres.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O nome inserido deve conter entre 5 e 50 caracteres.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();


                txNomeCompleto.Clear();
                txNomeCompleto.Focus();



                return;
            }


            else if (nomeCompleto.Split(' ').Length < 2)
            {

                errorProvider.SetError(txNomeCompleto, "Nome completo inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O nome completo deve conter pelo menos um sobrenome.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                return;
            }

            else if (nomeCompleto.Any(c => char.IsDigit(c)))

            {
                errorProvider.SetError(txNomeCompleto, "Nome completo inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O campo nome completo não pode conter números.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                return;

            }

            else if (nomeCompleto.Any(c => char.IsPunctuation(c) || char.IsSymbol(c)))
            {
                errorProvider.SetError(txNomeCompleto, "Nome completo inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome Completo Inválido";
                taskDialog.Text = "O campo nome completo não pode conter caracteres especiais.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeCompleto.Clear();
                txNomeCompleto.Focus();
                return;
            }

            else
            {

                errorProvider.SetError(txNomeCompleto, string.Empty);
                errorProvider.Clear();


            }

            /*if (string.IsNullOrWhiteSpace(numeroRegistro))
            {
                errorProvider.SetError(txNumeroRegistro, "Numero de Registro Invalido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Registro incompleto";
                taskDialog.Text = "Todos os campos devem ser preenchidos.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNumeroRegistro.Focus();
                txNumeroRegistro.Clear();

                
                return;
            }
            char[] numeroValidado = numeroRegistro.ToCharArray();



            if (numeroRegistro.Any(c => char.IsPunctuation(c) || char.IsSymbol(c) || char.IsLetter(c)))
            {
                errorProvider.SetError(txNumeroRegistro, "Numero de Registro Invalido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Numero ja Cadastrado";
                taskDialog.Text = "Só pode NUMERO INTEIRO POSITIVO.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNumeroRegistro.Clear();
                txNumeroRegistro.Focus();
                return;



            }

            if (numeroRegistro.Length > 10)
            {


                errorProvider.SetError(txNumeroRegistro, "Numero de Registro Invalido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Maximo de caracteres";
                taskDialog.Text = "O numero não pode ter mais que 10 caracteres.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNumeroRegistro.Clear();
                txNumeroRegistro.Focus();
                return;
                

            }*/




            if (string.IsNullOrEmpty(nivelPermissao) || nivelPermissao.Any(c => char.IsPunctuation(c) || char.IsSymbol(c) || char.IsNumber(c)))
            {
                errorProvider.SetError(cbNivelPermisao, "Nível de Permissão inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nível de Permissão não selecionado";
                taskDialog.Text = "Selecione um nível de permissão válido.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                cbNivelPermisao.SelectedIndex = 0;
                cbNivelPermisao.Focus();
                return;
            }


            //|| string.IsNullOrEmpty(nivelPermissao)


            if (string.IsNullOrWhiteSpace(nomeUsuario))
            {
                errorProvider.SetError(txNomeUsuario, "Nome de usuário inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome de usuário não informado";
                taskDialog.Text = "Informe um nome de usuário válido.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeUsuario.Clear();
                txNomeUsuario.Focus();
                return;
            }

            else if (nomeUsuario.Length > 15)
            {
                errorProvider.SetError(txNomeUsuario, "Nome de usuário inválido.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Nome de usuario maior que 15 caracteres";
                taskDialog.Text = "Nome de usuário nao pode ser maior que 15 caracteres.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txNomeUsuario.Clear();
                txNomeUsuario.Focus();
                return;

            }

            if (string.IsNullOrWhiteSpace(senhaAcesso))
            {
                errorProvider.SetError(txSenhaAcesso, "Senha de acesso inválida.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Senha de acesso não informada";
                taskDialog.Text = "Informe uma senha de acesso válida.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txSenhaAcesso.Clear();
                txSenhaAcesso.Focus();
                return;

            }


            if (string.IsNullOrWhiteSpace(txConfirmacaoSenha.Text.Trim()))
            {
                errorProvider.SetError(txConfirmacaoSenha, "Confirmação de senha inválida.");
                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Confirmação de senha não informada";
                taskDialog.Text = "Informe a confirmação de senha válida.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txConfirmacaoSenha.Clear();
                txConfirmacaoSenha.Focus();
                return;


            }


            CadastroUsuario cadastroRegistro = new CadastroUsuario();

            if (listaCadastroUsuario.Any(c => c.NOMEUSUARIO == nomeUsuario))
            {
                MessageBox.Show("O NOME DE USUARIO" + nomeUsuario + " já existe. Por favor, escolha outro.", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                txNomeUsuario.Clear();
                return;

            }

            if (senhaAcesso != txConfirmacaoSenha.Text)
            {
                errorProvider.SetError(txSenhaAcesso, "Numero de Registro Invalido.");
                errorProvider.SetError(txConfirmacaoSenha, "Numero de Registro Invalido.");

                taskDialog.Caption = "Validação Cadastro Novo Usuário";
                taskDialog.InstructionText = "Senhas";
                taskDialog.Text = "As senhas não coincidem.";
                taskDialog.Icon = TaskDialogStandardIcon.Warning;
                taskDialog.Show();
                txSenhaAcesso.Clear();
                txSenhaAcesso.Focus();
                txConfirmacaoSenha.Clear();

                return;


            }


            try
            {
                using (MySqlConnection conn = new MySqlConnection(DADOS_CONEXAO))
                {
                    conn.Open();
                    // tem que colocar esse comando para conecatar com o banco criado
                    //value @---serve para passar o valor do campo do formulario para o banco de dados
                    string scriptInsert = "UPDATE  tbcadastronovousuario set nomecompleto=@nomeCompleto, " +
                        "nivelPermisao=@nivelPermisao, nomeUsuario=@nomeUsuario, senhaAcesso=@senhaAcesso where nomecompleto=@nomeCompleto";


                    using (MySqlCommand comando = new MySqlCommand(scriptInsert, conn))
                    {
                        comando.Parameters.AddWithValue("@nomeCompleto", nomeCompleto);

                        comando.Parameters.AddWithValue("@nivelPermisao", nivelPermissao);
                        comando.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                        comando.Parameters.AddWithValue("@senhaAcesso", senhaAcesso);


                        controleLinhasAftadas = comando.ExecuteNonQuery();
                    }

                    if (controleLinhasAftadas == 0)
                    {
                        taskDialog.Caption = "Aviso do Sistema";
                        taskDialog.InstructionText = "Usuário não encontrado";
                        taskDialog.Text = "Não foi possível atualizar. O nome inserido não existe no banco de dados.";
                        taskDialog.Icon = TaskDialogStandardIcon.Warning;
                        taskDialog.Show();

                        txNomeCompleto.Clear();

                        cbNivelPermisao.SelectedIndex = -1;
                        txNomeUsuario.Clear();
                        txSenhaAcesso.Clear();
                        txConfirmacaoSenha.Clear();
                        conn.Close();

                        return; // O return impede que o código abaixo seja executado

                    }

                    CadastroUsuario cadastroUsuario = new CadastroUsuario();
                    cadastroUsuario.NOMECOMPLETO = nomeCompleto;

                    cadastroUsuario.NIVELPERMISSAO = nivelPermissao;
                    cadastroUsuario.NOMEUSUARIO = nomeUsuario;
                    cadastroUsuario.SENHAACESSO = senhaAcesso;
                    listaCadastroUsuario.Add(cadastroUsuario);


                    MessageBox.Show("Dados alterado  com sucesso!", "Altercao Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txNomeCompleto.Clear();

                    cbNivelPermisao.SelectedIndex = -1;
                    txNomeUsuario.Clear();
                    txSenhaAcesso.Clear();
                    txConfirmacaoSenha.Clear();
                    conn.Close();

                }
            }
            catch (MySqlException ex)
            {
                taskDialog.Caption = "Erro no Banco de Dados";
                taskDialog.InstructionText = "Falha na conexão ou execução";
                taskDialog.Text = "Ocorreu um erro técnico: " + ex.Message;
                taskDialog.Icon = TaskDialogStandardIcon.Error;
                taskDialog.Show();
            }


        }

        private void button_deletar_Click(object sender, EventArgs e)
        {
            DeletarCadastro formDeletarCadastro = new DeletarCadastro();

            DialogResult resposta = MessageBox.Show("As alterações foram salvas?\nCertifique-se de salvar antes de sair para não perder os dados.", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                formDeletarCadastro.Owner = this;
                this.Hide();
                formDeletarCadastro.ShowDialog();
            }
        }
        /*if (controleLinhasAftadas > 0){MessageBox.Show("Cadastro realizado com sucesso!");}*/




    } }

